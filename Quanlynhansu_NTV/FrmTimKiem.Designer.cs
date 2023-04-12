namespace Quanlynhansu
{
    partial class FrmTimKiem
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.rdoCV = new System.Windows.Forms.RadioButton();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoHV = new System.Windows.Forms.RadioButton();
            this.rdoTenNS = new System.Windows.Forms.RadioButton();
            this.rdoMaNS = new System.Windows.Forms.RadioButton();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.lbinput = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(4, 205);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(1180, 495);
            this.Dgv.TabIndex = 0;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.rdoCV);
            this.grb1.Controls.Add(this.rdoKhoa);
            this.grb1.Controls.Add(this.rdoHV);
            this.grb1.Controls.Add(this.rdoTenNS);
            this.grb1.Controls.Add(this.rdoMaNS);
            this.grb1.Location = new System.Drawing.Point(4, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(213, 167);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            // 
            // rdoCV
            // 
            this.rdoCV.AutoSize = true;
            this.rdoCV.Location = new System.Drawing.Point(9, 126);
            this.rdoCV.Name = "rdoCV";
            this.rdoCV.Size = new System.Drawing.Size(100, 20);
            this.rdoCV.TabIndex = 5;
            this.rdoCV.TabStop = true;
            this.rdoCV.Text = "Tên chức vụ";
            this.rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(9, 100);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(86, 20);
            this.rdoKhoa.TabIndex = 4;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "Tên Khoa";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoHV
            // 
            this.rdoHV.AutoSize = true;
            this.rdoHV.Location = new System.Drawing.Point(9, 74);
            this.rdoHV.Name = "rdoHV";
            this.rdoHV.Size = new System.Drawing.Size(127, 20);
            this.rdoHV.TabIndex = 2;
            this.rdoHV.TabStop = true;
            this.rdoHV.Text = "Trình độ học vấn";
            this.rdoHV.UseVisualStyleBackColor = true;
            // 
            // rdoTenNS
            // 
            this.rdoTenNS.AutoSize = true;
            this.rdoTenNS.Location = new System.Drawing.Point(9, 48);
            this.rdoTenNS.Name = "rdoTenNS";
            this.rdoTenNS.Size = new System.Drawing.Size(101, 20);
            this.rdoTenNS.TabIndex = 1;
            this.rdoTenNS.TabStop = true;
            this.rdoTenNS.Text = "Tên nhân sự";
            this.rdoTenNS.UseVisualStyleBackColor = true;
            // 
            // rdoMaNS
            // 
            this.rdoMaNS.AutoSize = true;
            this.rdoMaNS.Location = new System.Drawing.Point(9, 22);
            this.rdoMaNS.Name = "rdoMaNS";
            this.rdoMaNS.Size = new System.Drawing.Size(96, 20);
            this.rdoMaNS.TabIndex = 0;
            this.rdoMaNS.TabStop = true;
            this.rdoMaNS.Text = "Mã nhân sự";
            this.rdoMaNS.UseVisualStyleBackColor = true;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(315, 67);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(145, 22);
            this.txtinput.TabIndex = 2;
            // 
            // lbinput
            // 
            this.lbinput.AutoSize = true;
            this.lbinput.Location = new System.Drawing.Point(223, 70);
            this.lbinput.Name = "lbinput";
            this.lbinput.Size = new System.Drawing.Size(86, 16);
            this.lbinput.TabIndex = 3;
            this.lbinput.Text = "Nhập từ khoá";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(315, 128);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(131, 40);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "bắt đầu tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(481, 128);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(72, 40);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 712);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbinput);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.Dgv);
            this.MaximizeBox = false;
            this.Name = "FrmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton rdoCV;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoHV;
        private System.Windows.Forms.RadioButton rdoTenNS;
        private System.Windows.Forms.RadioButton rdoMaNS;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Label lbinput;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthoat;
    }
}