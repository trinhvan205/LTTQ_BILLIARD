﻿namespace MainForm
{
    partial class FHoadon
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDV_FHoadon = new System.Windows.Forms.Button();
            this.nud_Fhoadon = new System.Windows.Forms.NumericUpDown();
            this.flpDichVu = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDchi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSodt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenKh = new System.Windows.Forms.TextBox();
            this.tbIdkh = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdhd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThanhtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEndhd = new System.Windows.Forms.Button();
            this.gbDV = new System.Windows.Forms.GroupBox();
            this.dgvHDDV = new System.Windows.Forms.DataGridView();
            this.gbBan = new System.Windows.Forms.GroupBox();
            this.dgvHDBan = new System.Windows.Forms.DataGridView();
            this.btnChangeBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDV)).BeginInit();
            this.gbBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.flpDichVu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1279, 672);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddDV_FHoadon);
            this.panel1.Controls.Add(this.nud_Fhoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 92);
            this.panel1.TabIndex = 1;
            // 
            // btnAddDV_FHoadon
            // 
            this.btnAddDV_FHoadon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddDV_FHoadon.Location = new System.Drawing.Point(281, 0);
            this.btnAddDV_FHoadon.Name = "btnAddDV_FHoadon";
            this.btnAddDV_FHoadon.Size = new System.Drawing.Size(143, 92);
            this.btnAddDV_FHoadon.TabIndex = 4;
            this.btnAddDV_FHoadon.Text = "Thêm";
            this.btnAddDV_FHoadon.UseVisualStyleBackColor = true;
            this.btnAddDV_FHoadon.Click += new System.EventHandler(this.btnAddDV_FHoadon_Click);
            // 
            // nud_Fhoadon
            // 
            this.nud_Fhoadon.Location = new System.Drawing.Point(72, 32);
            this.nud_Fhoadon.Name = "nud_Fhoadon";
            this.nud_Fhoadon.Size = new System.Drawing.Size(97, 27);
            this.nud_Fhoadon.TabIndex = 3;
            // 
            // flpDichVu
            // 
            this.flpDichVu.AutoScroll = true;
            this.flpDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDichVu.Location = new System.Drawing.Point(0, 0);
            this.flpDichVu.Name = "flpDichVu";
            this.flpDichVu.Size = new System.Drawing.Size(424, 580);
            this.flpDichVu.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnChangeBan);
            this.splitContainer2.Panel2.Controls.Add(this.tbThanhtien);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.btnEndhd);
            this.splitContainer2.Panel2.Controls.Add(this.gbDV);
            this.splitContainer2.Panel2.Controls.Add(this.gbBan);
            this.splitContainer2.Size = new System.Drawing.Size(851, 672);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDchi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSodt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTenKh);
            this.groupBox1.Controls.Add(this.tbIdkh);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIdhd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // tbDchi
            // 
            this.tbDchi.Location = new System.Drawing.Point(116, 140);
            this.tbDchi.Name = "tbDchi";
            this.tbDchi.Size = new System.Drawing.Size(250, 25);
            this.tbDchi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // tbSodt
            // 
            this.tbSodt.Location = new System.Drawing.Point(540, 140);
            this.tbSodt.Name = "tbSodt";
            this.tbSodt.Size = new System.Drawing.Size(250, 25);
            this.tbSodt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(394, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã khách hàng";
            // 
            // tbTenKh
            // 
            this.tbTenKh.Location = new System.Drawing.Point(540, 94);
            this.tbTenKh.Name = "tbTenKh";
            this.tbTenKh.Size = new System.Drawing.Size(250, 25);
            this.tbTenKh.TabIndex = 8;
            // 
            // tbIdkh
            // 
            this.tbIdkh.Location = new System.Drawing.Point(540, 44);
            this.tbIdkh.Name = "tbIdkh";
            this.tbIdkh.Size = new System.Drawing.Size(250, 25);
            this.tbIdkh.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 20, 14, 1, 24, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(394, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // tbIdhd
            // 
            this.tbIdhd.Location = new System.Drawing.Point(116, 44);
            this.tbIdhd.Name = "tbIdhd";
            this.tbIdhd.Size = new System.Drawing.Size(250, 25);
            this.tbIdhd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(394, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // tbThanhtien
            // 
            this.tbThanhtien.Location = new System.Drawing.Point(540, 335);
            this.tbThanhtien.Name = "tbThanhtien";
            this.tbThanhtien.Size = new System.Drawing.Size(250, 27);
            this.tbThanhtien.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(417, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành tiền";
            // 
            // btnEndhd
            // 
            this.btnEndhd.Location = new System.Drawing.Point(603, 419);
            this.btnEndhd.Name = "btnEndhd";
            this.btnEndhd.Size = new System.Drawing.Size(138, 51);
            this.btnEndhd.TabIndex = 2;
            this.btnEndhd.Text = "Kết thúc hóa đơn";
            this.btnEndhd.UseVisualStyleBackColor = true;
            this.btnEndhd.Click += new System.EventHandler(this.BtnEndhd_Click);
            // 
            // gbDV
            // 
            this.gbDV.Controls.Add(this.dgvHDDV);
            this.gbDV.Location = new System.Drawing.Point(9, 134);
            this.gbDV.Name = "gbDV";
            this.gbDV.Size = new System.Drawing.Size(841, 125);
            this.gbDV.TabIndex = 1;
            this.gbDV.TabStop = false;
            this.gbDV.Text = "Thông tin dịch vụ";
            // 
            // dgvHDDV
            // 
            this.dgvHDDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDDV.Location = new System.Drawing.Point(3, 23);
            this.dgvHDDV.Name = "dgvHDDV";
            this.dgvHDDV.RowHeadersWidth = 51;
            this.dgvHDDV.RowTemplate.Height = 29;
            this.dgvHDDV.Size = new System.Drawing.Size(835, 99);
            this.dgvHDDV.TabIndex = 2;
            // 
            // gbBan
            // 
            this.gbBan.Controls.Add(this.dgvHDBan);
            this.gbBan.Location = new System.Drawing.Point(6, 3);
            this.gbBan.Name = "gbBan";
            this.gbBan.Size = new System.Drawing.Size(841, 125);
            this.gbBan.TabIndex = 0;
            this.gbBan.TabStop = false;
            this.gbBan.Text = "Thông tin bàn";
            // 
            // dgvHDBan
            // 
            this.dgvHDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBan.Location = new System.Drawing.Point(3, 23);
            this.dgvHDBan.Name = "dgvHDBan";
            this.dgvHDBan.RowHeadersWidth = 51;
            this.dgvHDBan.RowTemplate.Height = 29;
            this.dgvHDBan.Size = new System.Drawing.Size(835, 99);
            this.dgvHDBan.TabIndex = 0;
            // 
            // btnChangeBan
            // 
            this.btnChangeBan.Location = new System.Drawing.Point(26, 419);
            this.btnChangeBan.Name = "btnChangeBan";
            this.btnChangeBan.Size = new System.Drawing.Size(138, 51);
            this.btnChangeBan.TabIndex = 14;
            this.btnChangeBan.Text = "Đổi bàn";
            this.btnChangeBan.UseVisualStyleBackColor = true;
            this.btnChangeBan.Click += new System.EventHandler(this.btnChangeBan_Click);
            // 
            // FHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 672);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FHoadon";
            this.Load += new System.EventHandler(this.FHoadon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fhoadon)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDV)).EndInit();
            this.gbBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox tbIdhd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbTenKh;
        private TextBox tbIdkh;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flpDichVu;
        private Label label5;
        private TextBox tbDchi;
        private Label label6;
        private TextBox tbSodt;
        private GroupBox gbDV;
        private DataGridView dgvHDDV;
        private GroupBox gbBan;
        private DataGridView dgvHDBan;
        private Button btnEndhd;
        private TextBox tbThanhtien;
        private Label label7;
        private Panel panel1;
        private NumericUpDown nud_Fhoadon;
        private Button btnAddDV_FHoadon;
        private Button btnChangeBan;
    }
}