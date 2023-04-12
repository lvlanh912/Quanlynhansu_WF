namespace Quanlynhansu
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.grb = new System.Windows.Forms.GroupBox();
            this.rdoQTCT = new System.Windows.Forms.RadioButton();
            this.rdotuoi = new System.Windows.Forms.RadioButton();
            this.rdoHV = new System.Windows.Forms.RadioButton();
            this.cbbHV = new System.Windows.Forms.ComboBox();
            this.lbHV = new System.Windows.Forms.Label();
            this.lbdotuoi = new System.Windows.Forms.Label();
            this.txttuois = new System.Windows.Forms.TextBox();
            this.txttuoie = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.btnthongke = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbNS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // grb
            // 
            this.grb.Controls.Add(this.rdoQTCT);
            this.grb.Controls.Add(this.rdotuoi);
            this.grb.Controls.Add(this.rdoHV);
            this.grb.Location = new System.Drawing.Point(12, 12);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(186, 150);
            this.grb.TabIndex = 0;
            this.grb.TabStop = false;
            this.grb.Text = "Thống kê theo";
            // 
            // rdoQTCT
            // 
            this.rdoQTCT.AutoSize = true;
            this.rdoQTCT.Location = new System.Drawing.Point(6, 107);
            this.rdoQTCT.Name = "rdoQTCT";
            this.rdoQTCT.Size = new System.Drawing.Size(134, 20);
            this.rdoQTCT.TabIndex = 2;
            this.rdoQTCT.TabStop = true;
            this.rdoQTCT.Text = "Quá trình công tác";
            this.rdoQTCT.UseVisualStyleBackColor = true;
            this.rdoQTCT.CheckedChanged += new System.EventHandler(this.rdoHV_CheckedChanged);
            // 
            // rdotuoi
            // 
            this.rdotuoi.AutoSize = true;
            this.rdotuoi.Location = new System.Drawing.Point(7, 68);
            this.rdotuoi.Name = "rdotuoi";
            this.rdotuoi.Size = new System.Drawing.Size(69, 20);
            this.rdotuoi.TabIndex = 1;
            this.rdotuoi.TabStop = true;
            this.rdotuoi.Text = "Độ tuổi";
            this.rdotuoi.UseVisualStyleBackColor = true;
            this.rdotuoi.CheckedChanged += new System.EventHandler(this.rdoHV_CheckedChanged);
            // 
            // rdoHV
            // 
            this.rdoHV.AutoSize = true;
            this.rdoHV.Location = new System.Drawing.Point(6, 31);
            this.rdoHV.Name = "rdoHV";
            this.rdoHV.Size = new System.Drawing.Size(127, 20);
            this.rdoHV.TabIndex = 0;
            this.rdoHV.TabStop = true;
            this.rdoHV.Text = "Trình độ học vấn";
            this.rdoHV.UseVisualStyleBackColor = true;
            this.rdoHV.CheckedChanged += new System.EventHandler(this.rdoHV_CheckedChanged);
            // 
            // cbbHV
            // 
            this.cbbHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHV.FormattingEnabled = true;
            this.cbbHV.Location = new System.Drawing.Point(330, 43);
            this.cbbHV.Name = "cbbHV";
            this.cbbHV.Size = new System.Drawing.Size(121, 24);
            this.cbbHV.TabIndex = 1;
            // 
            // lbHV
            // 
            this.lbHV.AutoSize = true;
            this.lbHV.Location = new System.Drawing.Point(222, 47);
            this.lbHV.Name = "lbHV";
            this.lbHV.Size = new System.Drawing.Size(84, 16);
            this.lbHV.TabIndex = 2;
            this.lbHV.Text = "Chọn trình độ";
            // 
            // lbdotuoi
            // 
            this.lbdotuoi.AutoSize = true;
            this.lbdotuoi.Location = new System.Drawing.Point(222, 83);
            this.lbdotuoi.Name = "lbdotuoi";
            this.lbdotuoi.Size = new System.Drawing.Size(83, 16);
            this.lbdotuoi.TabIndex = 4;
            this.lbdotuoi.Text = "Nhập độ tuổi";
            // 
            // txttuois
            // 
            this.txttuois.Location = new System.Drawing.Point(330, 80);
            this.txttuois.Name = "txttuois";
            this.txttuois.Size = new System.Drawing.Size(44, 22);
            this.txttuois.TabIndex = 7;
            // 
            // txttuoie
            // 
            this.txttuoie.Location = new System.Drawing.Point(407, 79);
            this.txttuoie.Name = "txttuoie";
            this.txttuoie.Size = new System.Drawing.Size(44, 22);
            this.txttuoie.TabIndex = 8;
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(1, 168);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(787, 270);
            this.Dgv.TabIndex = 9;
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(517, 60);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(79, 39);
            this.btnthongke.TabIndex = 10;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // cbbNS
            // 
            this.cbbNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNS.FormattingEnabled = true;
            this.cbbNS.Location = new System.Drawing.Point(330, 119);
            this.cbbNS.Name = "cbbNS";
            this.cbbNS.Size = new System.Drawing.Size(121, 24);
            this.cbbNS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn nhân sự";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(658, 63);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 32);
            this.btnthoat.TabIndex = 109;
            this.btnthoat.Text = "  Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNS);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.txttuoie);
            this.Controls.Add(this.txttuois);
            this.Controls.Add(this.lbdotuoi);
            this.Controls.Add(this.lbHV);
            this.Controls.Add(this.cbbHV);
            this.Controls.Add(this.grb);
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.RadioButton rdoQTCT;
        private System.Windows.Forms.RadioButton rdotuoi;
        private System.Windows.Forms.RadioButton rdoHV;
        private System.Windows.Forms.ComboBox cbbHV;
        private System.Windows.Forms.Label lbHV;
        private System.Windows.Forms.Label lbdotuoi;
        private System.Windows.Forms.TextBox txttuois;
        private System.Windows.Forms.TextBox txttuoie;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.ComboBox cbbNS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
    }
}