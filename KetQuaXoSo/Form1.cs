//Form1.cs
using KetQuaXoSo.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetQuaXoSo
{
    public partial class Form1 : Form
    {
        private readonly Logic logic;
        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now; 
            dtpNgay.MinDate = now.AddDays(-6); 
            dtpNgay.MaxDate = now; 
            logic = new Logic();
            rdMienBac.Checked = true;
            LoadKetQua();
        }

        private void rdMienBac_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMienBac.Checked) LoadKetQua();
        }

        private void rdMienTrung_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMienTrung.Checked) LoadKetQua();
        }

        private void rdMienNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMienNam.Checked) LoadKetQua();
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void LoadKetQua()
        {
            try
            {
                string mien = rdMienBac.Checked ? "bac" : rdMienTrung.Checked ? "trung" : "nam";
                var ketQua = logic.LayKetQua(mien, dtpNgay.Value);

                tabKetQua.TabPages.Clear();

                foreach (var dai in ketQua.Keys)
                {
                    var tab = new TabPage(dai);
                    var grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = ketQua[dai],
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };
                    tab.Controls.Add(grid);
                    tabKetQua.TabPages.Add(tab);
                }

                if (ketQua.Count == 0)
                {
                    tabKetQua.TabPages.Add(new TabPage("Khong co du lieu"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi: {ex.Message}", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtRandom_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 99999);
            txtRandom.Text = randomNumber.ToString("D5");
        }
    }
}
