using System;
using System.Collections.Generic;
using System.Xml;

namespace KetQuaXoSo.DAL
{
    public class DuLieu
    {
        public List<KetQua> LayKetQuaTuRSS(string rssUrl)
        {
            var ketQua = new List<KetQua>();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(rssUrl);

                // Lấy tất cả các mục (item) trong RSS
                XmlNodeList items = doc.SelectNodes("//item");
                foreach (XmlNode item in items)
                {
                    DateTime ngay = LayNgayTuItem(item);

                    string description = item.SelectSingleNode("description").InnerText;
                    string[] lines = description.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    string currentDai = "Unknown";
                    if (rssUrl.Contains("mien-bac"))
                    {
                        currentDai = "Hà Nội"; 
                    }

                    foreach (string line in lines)
                    {
                        string trimmedLine = line.Trim();
                        if (trimmedLine.StartsWith("[") && trimmedLine.Contains("]"))
                        {
                            int start = trimmedLine.IndexOf("[") + 1;
                            int end = trimmedLine.IndexOf("]");
                            if (start < end)
                            {
                                currentDai = trimmedLine.Substring(start, end - start).Trim();
                            }
                        }
                        else if (trimmedLine.Contains(":"))
                        {
                            string[] parts = trimmedLine.Split(':');
                            if (parts.Length == 2)
                            {
                                string giai = parts[0].Trim();
                                string soTrung = parts[1].Trim();

                                ketQua.Add(new KetQua
                                {
                                    Dai = currentDai,
                                    Giai = giai,
                                    SoTrung = soTrung,
                                    Ngay = ngay
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Khong the tai du lieu RSS: " + ex.Message);
            }

            return ketQua;
        }
        private DateTime LayNgayTuItem(XmlNode item)
        {
            DateTime ngay;
            XmlNode pubDateNode = item.SelectSingleNode("pubDate");
            if (pubDateNode != null)
            {
                string dateText = pubDateNode.InnerText.Split(' ')[0];
                string[] dateParts = dateText.Split('/');
                if (dateParts.Length == 3)
                {
                    int ngayPart = int.Parse(dateParts[0]);
                    int thangPart = int.Parse(dateParts[1]);
                    int namPart = int.Parse(dateParts[2]);
                    ngay = new DateTime(namPart, thangPart, ngayPart);
                    return ngay.Date;
                }
            }

            string title = item.SelectSingleNode("title").InnerText;
            string[] titleParts = title.Split(' ');
            foreach (string part in titleParts)
            {
                if (part.Contains("/"))
                {
                    string[] dateParts = part.Split('/');
                    if (dateParts.Length == 3)
                    {
                        int ngayPart = int.Parse(dateParts[0]);
                        int thangPart = int.Parse(dateParts[1]);
                        int namPart = int.Parse(dateParts[2]);
                        ngay = new DateTime(namPart, thangPart, ngayPart);
                        return ngay.Date;
                    }
                }
            }

            return DateTime.Now.Date; 
        }
    }
}