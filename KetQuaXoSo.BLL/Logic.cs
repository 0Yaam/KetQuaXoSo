using KetQuaXoSo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KetQuaXoSo.BLL
{
    public class Logic
    {
        private readonly DuLieu _duLieu;

        public Logic()
        {
            _duLieu = new DuLieu();
        }
        public Dictionary<string, List<KetQua>> LayKetQua(string mien, DateTime ngay)
        {
            string rssUrl;
            if (mien == "bac")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-bac-xsmb.rss";
            }
            else if (mien == "trung")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-trung-xsmt.rss";
            }
            else if (mien == "nam")
            {
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-nam-xsmn.rss";
            }
            else
            {
                throw new ArgumentException("Mien khong hop le");
            }
            var ketQua = _duLieu.LayKetQuaTuRSS(rssUrl);

            // Lọc kết quả theo ngày
            ketQua = ketQua.Where(kq => kq.Ngay.Date == ngay.Date).ToList();

            // Nhóm kết quả theo đài
            var ketQuaTheoDai = new Dictionary<string, List<KetQua>>();
            foreach (KetQua kq in ketQua)
            {
                string dai = kq.Dai;
                if (!ketQuaTheoDai.ContainsKey(dai))
                {
                    ketQuaTheoDai[dai] = new List<KetQua>();
                }
                ketQuaTheoDai[dai].Add(kq);
            }
            return ketQuaTheoDai;
        }
    }
}