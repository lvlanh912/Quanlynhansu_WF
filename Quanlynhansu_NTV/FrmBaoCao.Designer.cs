namespace Quanlynhansu
{
    partial class FrmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao));
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGV = new System.Windows.Forms.RadioButton();
            this.rdoGVage = new System.Windows.Forms.RadioButton();
            this.rdocb = new System.Windows.Forms.RadioButton();
            this.btnXuat = new System.Windows.Forms.Button();
            this.rp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnthoat.Location = new System.Drawing.Point(525, 50);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 32);
            this.btnthoat.TabIndex = 109;
            this.btnthoat.Text = "  Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGV);
            this.groupBox1.Controls.Add(this.rdoGVage);
            this.groupBox1.Controls.Add(this.rdocb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 104);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // rdoGV
            // 
            this.rdoGV.AutoSize = true;
            this.rdoGV.Location = new System.Drawing.Point(7, 50);
            this.rdoGV.Name = "rdoGV";
            this.rdoGV.Size = new System.Drawing.Size(157, 20);
            this.rdoGV.TabIndex = 2;
            this.rdoGV.TabStop = true;
            this.rdoGV.Text = "Danh sách giảng viên";
            this.rdoGV.UseVisualStyleBackColor = true;
            // 
            // rdoGVage
            // 
            this.rdoGVage.AutoSize = true;
            this.rdoGVage.Location = new System.Drawing.Point(6, 78);
            this.rdoGVage.Name = "rdoGVage";
            this.rdoGVage.Size = new System.Drawing.Size(229, 20);
            this.rdoGVage.TabIndex = 1;
            this.rdoGVage.TabStop = true;
            this.rdoGVage.Text = "Danh sách giảng viên theo độ tuổi";
            this.rdoGVage.UseVisualStyleBackColor = true;
            // 
            // rdocb
            // 
            this.rdocb.AutoSize = true;
            this.rdocb.Location = new System.Drawing.Point(7, 22);
            this.rdocb.Name = "rdocb";
            this.rdocb.Size = new System.Drawing.Size(136, 20);
            this.rdocb.TabIndex = 0;
            this.rdocb.TabStop = true;
            this.rdocb.Text = "Danh sách cán bộ";
            this.rdocb.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(318, 50);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 111;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // rp
            // 
            this.rp.Location = new System.Drawing.Point(33, 244);
            this.rp.Name = "rp";
            this.rp.ServerReport.BearerToken = null;
            this.rp.Size = new System.Drawing.Size(777, 263);
            this.rp.TabIndex = 112;
            this.rp.Load += new System.EventHandler(this.rp_Load);
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 567);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.MaximizeBox = false;
            this.Name = "FrmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGV;
        private System.Windows.Forms.RadioButton rdoGVage;
        private System.Windows.Forms.RadioButton rdocb;
        private System.Windows.Forms.Button btnXuat;
        private Microsoft.Reporting.WinForms.ReportViewer rp;
    }
}