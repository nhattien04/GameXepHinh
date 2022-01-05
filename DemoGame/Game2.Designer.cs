namespace DemoGame
{
    partial class Game2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.btTamDung = new System.Windows.Forms.Button();
            this.pbAnhGoc = new System.Windows.Forms.PictureBox();
            this.btThayDoi = new System.Windows.Forms.Button();
            this.lbHinhMau = new System.Windows.Forms.Label();
            this.lbDoKho = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbTenDoKho = new System.Windows.Forms.Label();
            this.lbTinhThoiGian = new System.Windows.Forms.Label();
            this.lbSoDiem = new System.Windows.Forms.Label();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btBatDau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBuoc = new System.Windows.Forms.Label();
            this.lbSoBuoc = new System.Windows.Forms.Label();
            this.flowLPPic = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.độKhóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChoiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.độKhóToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhGoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTamDung
            // 
            this.btTamDung.Location = new System.Drawing.Point(67, 333);
            this.btTamDung.Name = "btTamDung";
            this.btTamDung.Size = new System.Drawing.Size(100, 30);
            this.btTamDung.TabIndex = 9;
            this.btTamDung.Text = "Tạm dừng";
            this.btTamDung.UseVisualStyleBackColor = true;
            this.btTamDung.Click += new System.EventHandler(this.btTamDung_Click);
            // 
            // pbAnhGoc
            // 
            this.pbAnhGoc.Location = new System.Drawing.Point(32, 76);
            this.pbAnhGoc.Name = "pbAnhGoc";
            this.pbAnhGoc.Size = new System.Drawing.Size(180, 180);
            this.pbAnhGoc.TabIndex = 12;
            this.pbAnhGoc.TabStop = false;
            // 
            // btThayDoi
            // 
            this.btThayDoi.Location = new System.Drawing.Point(67, 369);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(100, 30);
            this.btThayDoi.TabIndex = 18;
            this.btThayDoi.Text = "Thay đổi";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.btThayDoi_Click);
            // 
            // lbHinhMau
            // 
            this.lbHinhMau.AutoSize = true;
            this.lbHinhMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinhMau.Location = new System.Drawing.Point(88, 258);
            this.lbHinhMau.Name = "lbHinhMau";
            this.lbHinhMau.Size = new System.Drawing.Size(61, 15);
            this.lbHinhMau.TabIndex = 19;
            this.lbHinhMau.Text = "Hình mẫu";
            // 
            // lbDoKho
            // 
            this.lbDoKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDoKho.AutoSize = true;
            this.lbDoKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoKho.Location = new System.Drawing.Point(33, 14);
            this.lbDoKho.Name = "lbDoKho";
            this.lbDoKho.Size = new System.Drawing.Size(57, 17);
            this.lbDoKho.TabIndex = 20;
            this.lbDoKho.Text = "Độ khó:";
            this.lbDoKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            this.lbDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(33, 46);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(44, 17);
            this.lbDiem.TabIndex = 21;
            this.lbDiem.Text = "Điểm:";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(33, 120);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(71, 17);
            this.lbThoiGian.TabIndex = 22;
            this.lbThoiGian.Text = "Thời gian:";
            this.lbThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenDoKho
            // 
            this.lbTenDoKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenDoKho.AutoSize = true;
            this.lbTenDoKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoKho.ForeColor = System.Drawing.Color.Red;
            this.lbTenDoKho.Location = new System.Drawing.Point(134, 10);
            this.lbTenDoKho.Name = "lbTenDoKho";
            this.lbTenDoKho.Size = new System.Drawing.Size(129, 26);
            this.lbTenDoKho.TabIndex = 23;
            this.lbTenDoKho.Text = "Tên độ khó";
            this.lbTenDoKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTinhThoiGian
            // 
            this.lbTinhThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTinhThoiGian.AutoSize = true;
            this.lbTinhThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lbTinhThoiGian.Location = new System.Drawing.Point(119, 116);
            this.lbTinhThoiGian.Name = "lbTinhThoiGian";
            this.lbTinhThoiGian.Size = new System.Drawing.Size(132, 26);
            this.lbTinhThoiGian.TabIndex = 24;
            this.lbTinhThoiGian.Text = "THỜI GIAN";
            this.lbTinhThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoDiem
            // 
            this.lbSoDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoDiem.AutoSize = true;
            this.lbSoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDiem.ForeColor = System.Drawing.Color.Red;
            this.lbSoDiem.Location = new System.Drawing.Point(136, 41);
            this.lbSoDiem.Name = "lbSoDiem";
            this.lbSoDiem.Size = new System.Drawing.Size(100, 26);
            this.lbSoDiem.TabIndex = 25;
            this.lbSoDiem.Text = "Số điểm";
            this.lbSoDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUp
            // 
            this.btUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUp.Location = new System.Drawing.Point(96, 19);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(50, 50);
            this.btUp.TabIndex = 30;
            this.btUp.Text = "Top";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDown.Location = new System.Drawing.Point(96, 114);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(50, 50);
            this.btDown.TabIndex = 29;
            this.btDown.Text = "Bottom";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btRight
            // 
            this.btRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight.Location = new System.Drawing.Point(143, 66);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 50);
            this.btRight.TabIndex = 28;
            this.btRight.Text = "Right";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btLeft
            // 
            this.btLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.Location = new System.Drawing.Point(48, 66);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 50);
            this.btLeft.TabIndex = 27;
            this.btLeft.Text = "Left";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btBatDau
            // 
            this.btBatDau.BackColor = System.Drawing.SystemColors.Control;
            this.btBatDau.Location = new System.Drawing.Point(67, 297);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(100, 30);
            this.btBatDau.TabIndex = 32;
            this.btBatDau.Text = "Bắt đầu";
            this.btBatDau.UseVisualStyleBackColor = false;
            this.btBatDau.Click += new System.EventHandler(this.btBatDau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbBuoc);
            this.panel1.Controls.Add(this.lbSoBuoc);
            this.panel1.Controls.Add(this.lbTinhThoiGian);
            this.panel1.Controls.Add(this.lbDoKho);
            this.panel1.Controls.Add(this.lbDiem);
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.lbTenDoKho);
            this.panel1.Controls.Add(this.lbSoDiem);
            this.panel1.Location = new System.Drawing.Point(613, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 153);
            this.panel1.TabIndex = 33;
            // 
            // lbBuoc
            // 
            this.lbBuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBuoc.AutoSize = true;
            this.lbBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuoc.Location = new System.Drawing.Point(33, 78);
            this.lbBuoc.Name = "lbBuoc";
            this.lbBuoc.Size = new System.Drawing.Size(64, 17);
            this.lbBuoc.TabIndex = 26;
            this.lbBuoc.Text = "Số bước:";
            this.lbBuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoBuoc
            // 
            this.lbSoBuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoBuoc.AutoSize = true;
            this.lbSoBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoBuoc.ForeColor = System.Drawing.Color.Red;
            this.lbSoBuoc.Location = new System.Drawing.Point(136, 73);
            this.lbSoBuoc.Name = "lbSoBuoc";
            this.lbSoBuoc.Size = new System.Drawing.Size(99, 26);
            this.lbSoBuoc.TabIndex = 27;
            this.lbSoBuoc.Text = "Số bước";
            this.lbSoBuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLPPic
            // 
            this.flowLPPic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLPPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLPPic.Location = new System.Drawing.Point(237, 73);
            this.flowLPPic.Name = "flowLPPic";
            this.flowLPPic.Size = new System.Drawing.Size(350, 350);
            this.flowLPPic.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độKhóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // độKhóToolStripMenuItem
            // 
            this.độKhóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChoiLai,
            this.độKhóToolStripMenuItem1,
            this.mnThoat});
            this.độKhóToolStripMenuItem.Name = "độKhóToolStripMenuItem";
            this.độKhóToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.độKhóToolStripMenuItem.Text = "Tùy Chọn";
            // 
            // mnChoiLai
            // 
            this.mnChoiLai.Name = "mnChoiLai";
            this.mnChoiLai.Size = new System.Drawing.Size(117, 22);
            this.mnChoiLai.Text = "Chơi Lại";
            this.mnChoiLai.Click += new System.EventHandler(this.mnChoiLai_Click);
            // 
            // độKhóToolStripMenuItem1
            // 
            this.độKhóToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x5ToolStripMenuItem});
            this.độKhóToolStripMenuItem1.Name = "độKhóToolStripMenuItem1";
            this.độKhóToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.độKhóToolStripMenuItem1.Text = "Độ Khó";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x3ToolStripMenuItem.Text = "3 x 3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x4ToolStripMenuItem.Text = "4 x 4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            // 
            // x5ToolStripMenuItem
            // 
            this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
            this.x5ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.x5ToolStripMenuItem.Text = "5 x 5";
            this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(117, 22);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btUp);
            this.panel2.Controls.Add(this.btDown);
            this.panel2.Controls.Add(this.btRight);
            this.panel2.Controls.Add(this.btLeft);
            this.panel2.Location = new System.Drawing.Point(624, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 177);
            this.panel2.TabIndex = 36;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(67, 405);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 30);
            this.btLuu.TabIndex = 37;
            this.btLuu.Text = "Lưu kết quả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLPPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBatDau);
            this.Controls.Add(this.lbHinhMau);
            this.Controls.Add(this.btThayDoi);
            this.Controls.Add(this.pbAnhGoc);
            this.Controls.Add(this.btTamDung);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.GameXepHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhGoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btTamDung;
        private System.Windows.Forms.PictureBox pbAnhGoc;
        private System.Windows.Forms.Button btThayDoi;
        private System.Windows.Forms.Label lbHinhMau;
        private System.Windows.Forms.Label lbDoKho;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label lbTenDoKho;
        private System.Windows.Forms.Label lbTinhThoiGian;
        private System.Windows.Forms.Label lbSoDiem;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btBatDau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLPPic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem độKhóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnChoiLai;
        private System.Windows.Forms.ToolStripMenuItem độKhóToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbBuoc;
        private System.Windows.Forms.Label lbSoBuoc;
        private System.Windows.Forms.Button btLuu;
	}
}