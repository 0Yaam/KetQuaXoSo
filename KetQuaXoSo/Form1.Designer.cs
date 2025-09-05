namespace KetQuaXoSo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.rdMienNam = new System.Windows.Forms.RadioButton();
            this.rdMienTrung = new System.Windows.Forms.RadioButton();
            this.rdMienBac = new System.Windows.Forms.RadioButton();
            this.tabKetQua = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMien = new System.Windows.Forms.ComboBox();
            this.dtpDoVeSo = new System.Windows.Forms.DateTimePicker();
            this.txtVeSo = new System.Windows.Forms.TextBox();
            this.cbDai = new System.Windows.Forms.ComboBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabKetQua.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.rdMienNam);
            this.groupBox1.Controls.Add(this.rdMienTrung);
            this.groupBox1.Controls.Add(this.rdMienBac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(14, 104);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(93, 20);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // rdMienNam
            // 
            this.rdMienNam.AutoSize = true;
            this.rdMienNam.Location = new System.Drawing.Point(14, 72);
            this.rdMienNam.Name = "rdMienNam";
            this.rdMienNam.Size = new System.Drawing.Size(73, 17);
            this.rdMienNam.TabIndex = 2;
            this.rdMienNam.TabStop = true;
            this.rdMienNam.Text = "Miền Nam";
            this.rdMienNam.UseVisualStyleBackColor = true;
            this.rdMienNam.CheckedChanged += new System.EventHandler(this.rdMienNam_CheckedChanged);
            // 
            // rdMienTrung
            // 
            this.rdMienTrung.AutoSize = true;
            this.rdMienTrung.Location = new System.Drawing.Point(14, 44);
            this.rdMienTrung.Name = "rdMienTrung";
            this.rdMienTrung.Size = new System.Drawing.Size(79, 17);
            this.rdMienTrung.TabIndex = 1;
            this.rdMienTrung.TabStop = true;
            this.rdMienTrung.Text = "Miền Trung";
            this.rdMienTrung.UseVisualStyleBackColor = true;
            this.rdMienTrung.CheckedChanged += new System.EventHandler(this.rdMienTrung_CheckedChanged);
            // 
            // rdMienBac
            // 
            this.rdMienBac.AutoSize = true;
            this.rdMienBac.Location = new System.Drawing.Point(14, 21);
            this.rdMienBac.Name = "rdMienBac";
            this.rdMienBac.Size = new System.Drawing.Size(70, 17);
            this.rdMienBac.TabIndex = 0;
            this.rdMienBac.TabStop = true;
            this.rdMienBac.Text = "Miền Bắc";
            this.rdMienBac.UseVisualStyleBackColor = true;
            this.rdMienBac.CheckedChanged += new System.EventHandler(this.rdMienBac_CheckedChanged);
            // 
            // tabKetQua
            // 
            this.tabKetQua.Controls.Add(this.tabPage1);
            this.tabKetQua.Controls.Add(this.tabPage2);
            this.tabKetQua.Location = new System.Drawing.Point(155, 12);
            this.tabKetQua.Name = "tabKetQua";
            this.tabKetQua.SelectedIndex = 0;
            this.tabKetQua.Size = new System.Drawing.Size(462, 407);
            this.tabKetQua.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMien);
            this.groupBox2.Controls.Add(this.dtpDoVeSo);
            this.groupBox2.Controls.Add(this.txtVeSo);
            this.groupBox2.Controls.Add(this.cbDai);
            this.groupBox2.Controls.Add(this.btnKiemTra);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 167);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dò vé số";
            // 
            // cbMien
            // 
            this.cbMien.FormattingEnabled = true;
            this.cbMien.Items.AddRange(new object[] {
            "Miền Bắc",
            "Miền Trung",
            "Miền Nam"});
            this.cbMien.Location = new System.Drawing.Point(14, 20);
            this.cbMien.Name = "cbMien";
            this.cbMien.Size = new System.Drawing.Size(93, 21);
            this.cbMien.TabIndex = 7;
            // 
            // dtpDoVeSo
            // 
            this.dtpDoVeSo.Location = new System.Drawing.Point(14, 47);
            this.dtpDoVeSo.Name = "dtpDoVeSo";
            this.dtpDoVeSo.Size = new System.Drawing.Size(93, 20);
            this.dtpDoVeSo.TabIndex = 5;
            // 
            // txtVeSo
            // 
            this.txtVeSo.Location = new System.Drawing.Point(14, 73);
            this.txtVeSo.Name = "txtVeSo";
            this.txtVeSo.Size = new System.Drawing.Size(93, 20);
            this.txtVeSo.TabIndex = 6;
            // 
            // cbDai
            // 
            this.cbDai.FormattingEnabled = true;
            this.cbDai.Location = new System.Drawing.Point(14, 99);
            this.cbDai.Name = "cbDai";
            this.cbDai.Size = new System.Drawing.Size(93, 21);
            this.cbDai.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(18, 126);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 5;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRandom);
            this.groupBox3.Controls.Add(this.btnRandom);
            this.groupBox3.Location = new System.Drawing.Point(12, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 88);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Con số may mắn";
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(14, 19);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(93, 20);
            this.txtRandom.TabIndex = 6;
            this.txtRandom.TextChanged += new System.EventHandler(this.txtRandom_TextChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(14, 45);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Quay";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabKetQua);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabKetQua.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.RadioButton rdMienNam;
        private System.Windows.Forms.RadioButton rdMienTrung;
        private System.Windows.Forms.RadioButton rdMienBac;
        private System.Windows.Forms.TabControl tabKetQua;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMien;
        private System.Windows.Forms.DateTimePicker dtpDoVeSo;
        private System.Windows.Forms.TextBox txtVeSo;
        private System.Windows.Forms.ComboBox cbDai;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Button btnRandom;
    }
}

