
namespace DemoGame
{
	partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.panelAnh = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbAnhGoc = new System.Windows.Forms.PictureBox();
            this.btNewgame = new System.Windows.Forms.Button();
            this.btReplay = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.panelNen = new System.Windows.Forms.Panel();
            this.lbBuoc = new System.Windows.Forms.Label();
            this.lbSoBuoc = new System.Windows.Forms.Label();
            this.lbDoKho = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbTenDoKho = new System.Windows.Forms.Label();
            this.lbSoDiem = new System.Windows.Forms.Label();
            this.btKetqua = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.chọnLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level4x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhGoc)).BeginInit();
            this.panelNen.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnh
            // 
            this.panelAnh.Location = new System.Drawing.Point(0, 0);
            this.panelAnh.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(318, 325);
            this.panelAnh.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(301, 375);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(228, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh gốc";
            // 
            // pbAnhGoc
            // 
            this.pbAnhGoc.Location = new System.Drawing.Point(508, 0);
            this.pbAnhGoc.Margin = new System.Windows.Forms.Padding(2);
            this.pbAnhGoc.Name = "pbAnhGoc";
            this.pbAnhGoc.Size = new System.Drawing.Size(330, 325);
            this.pbAnhGoc.TabIndex = 2;
            this.pbAnhGoc.TabStop = false;
            // 
            // btNewgame
            // 
            this.btNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewgame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNewgame.Location = new System.Drawing.Point(32, 389);
            this.btNewgame.Margin = new System.Windows.Forms.Padding(2);
            this.btNewgame.Name = "btNewgame";
            this.btNewgame.Size = new System.Drawing.Size(94, 72);
            this.btNewgame.TabIndex = 2;
            this.btNewgame.Text = "New Game";
            this.btNewgame.UseVisualStyleBackColor = true;
            this.btNewgame.Click += new System.EventHandler(this.btNewgame_Click);
            // 
            // btReplay
            // 
            this.btReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btReplay.Location = new System.Drawing.Point(150, 389);
            this.btReplay.Margin = new System.Windows.Forms.Padding(2);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(96, 72);
            this.btReplay.TabIndex = 2;
            this.btReplay.Text = "Chơi lại";
            this.btReplay.UseVisualStyleBackColor = true;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Location = new System.Drawing.Point(150, 488);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 65);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panelNen
            // 
            this.panelNen.BackColor = System.Drawing.SystemColors.Control;
            this.panelNen.Controls.Add(this.lbBuoc);
            this.panelNen.Controls.Add(this.lbSoBuoc);
            this.panelNen.Controls.Add(this.lbDoKho);
            this.panelNen.Controls.Add(this.lbDiem);
            this.panelNen.Controls.Add(this.lbTenDoKho);
            this.panelNen.Controls.Add(this.lbSoDiem);
            this.panelNen.Controls.Add(this.btKetqua);
            this.panelNen.Controls.Add(this.btPause);
            this.panelNen.Controls.Add(this.lbTime);
            this.panelNen.Controls.Add(this.label1);
            this.panelNen.Controls.Add(this.pbAnhGoc);
            this.panelNen.Controls.Add(this.panelAnh);
            this.panelNen.Controls.Add(this.btNewgame);
            this.panelNen.Controls.Add(this.btReplay);
            this.panelNen.Controls.Add(this.btThoat);
            this.panelNen.Controls.Add(this.groupBox2);
            this.panelNen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNen.Location = new System.Drawing.Point(9, 32);
            this.panelNen.Margin = new System.Windows.Forms.Padding(2);
            this.panelNen.Name = "panelNen";
            this.panelNen.Size = new System.Drawing.Size(841, 661);
            this.panelNen.TabIndex = 3;
            // 
            // lbBuoc
            // 
            this.lbBuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBuoc.AutoSize = true;
            this.lbBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBuoc.Location = new System.Drawing.Point(569, 509);
            this.lbBuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuoc.Name = "lbBuoc";
            this.lbBuoc.Size = new System.Drawing.Size(64, 17);
            this.lbBuoc.TabIndex = 32;
            this.lbBuoc.Text = "Số bước:";
            this.lbBuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoBuoc
            // 
            this.lbSoBuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoBuoc.AutoSize = true;
            this.lbSoBuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoBuoc.ForeColor = System.Drawing.Color.Red;
            this.lbSoBuoc.Location = new System.Drawing.Point(646, 505);
            this.lbSoBuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoBuoc.Name = "lbSoBuoc";
            this.lbSoBuoc.Size = new System.Drawing.Size(99, 26);
            this.lbSoBuoc.TabIndex = 33;
            this.lbSoBuoc.Text = "Số bước";
            this.lbSoBuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDoKho
            // 
            this.lbDoKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDoKho.AutoSize = true;
            this.lbDoKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoKho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDoKho.Location = new System.Drawing.Point(569, 457);
            this.lbDoKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoKho.Name = "lbDoKho";
            this.lbDoKho.Size = new System.Drawing.Size(57, 17);
            this.lbDoKho.TabIndex = 28;
            this.lbDoKho.Text = "Độ khó:";
            this.lbDoKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            this.lbDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDiem.Location = new System.Drawing.Point(569, 483);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(44, 17);
            this.lbDiem.TabIndex = 29;
            this.lbDiem.Text = "Điểm:";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenDoKho
            // 
            this.lbTenDoKho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenDoKho.AutoSize = true;
            this.lbTenDoKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDoKho.ForeColor = System.Drawing.Color.Red;
            this.lbTenDoKho.Location = new System.Drawing.Point(645, 454);
            this.lbTenDoKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenDoKho.Name = "lbTenDoKho";
            this.lbTenDoKho.Size = new System.Drawing.Size(129, 26);
            this.lbTenDoKho.TabIndex = 30;
            this.lbTenDoKho.Text = "Tên độ khó";
            this.lbTenDoKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoDiem
            // 
            this.lbSoDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoDiem.AutoSize = true;
            this.lbSoDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDiem.ForeColor = System.Drawing.Color.Red;
            this.lbSoDiem.Location = new System.Drawing.Point(646, 479);
            this.lbSoDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoDiem.Name = "lbSoDiem";
            this.lbSoDiem.Size = new System.Drawing.Size(100, 26);
            this.lbSoDiem.TabIndex = 31;
            this.lbSoDiem.Text = "Số điểm";
            this.lbSoDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btKetqua
            // 
            this.btKetqua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btKetqua.Location = new System.Drawing.Point(746, 600);
            this.btKetqua.Margin = new System.Windows.Forms.Padding(2);
            this.btKetqua.Name = "btKetqua";
            this.btKetqua.Size = new System.Drawing.Size(76, 41);
            this.btKetqua.TabIndex = 5;
            this.btKetqua.Text = "Lưu kết quả";
            this.btKetqua.UseVisualStyleBackColor = true;
            this.btKetqua.Click += new System.EventHandler(this.btKetqua_Click);
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPause.Location = new System.Drawing.Point(32, 488);
            this.btPause.Margin = new System.Windows.Forms.Padding(2);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(94, 65);
            this.btPause.TabIndex = 4;
            this.btPause.Text = "Tạm dừng";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Location = new System.Drawing.Point(644, 382);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(195, 72);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(549, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnLevelToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(859, 29);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // chọnLevelToolStripMenuItem
            // 
            this.chọnLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level3x3ToolStripMenuItem,
            this.level4x4ToolStripMenuItem,
            this.level5x5ToolStripMenuItem});
            this.chọnLevelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chọnLevelToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.chọnLevelToolStripMenuItem.Name = "chọnLevelToolStripMenuItem";
            this.chọnLevelToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.chọnLevelToolStripMenuItem.Text = "Chọn Level";
            // 
            // level3x3ToolStripMenuItem
            // 
            this.level3x3ToolStripMenuItem.Name = "level3x3ToolStripMenuItem";
            this.level3x3ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.level3x3ToolStripMenuItem.Text = "Level 3x3";
            this.level3x3ToolStripMenuItem.Click += new System.EventHandler(this.level3x3ToolStripMenuItem_Click);
            // 
            // level4x4ToolStripMenuItem
            // 
            this.level4x4ToolStripMenuItem.Name = "level4x4ToolStripMenuItem";
            this.level4x4ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.level4x4ToolStripMenuItem.Text = "Level 4x4";
            this.level4x4ToolStripMenuItem.Click += new System.EventHandler(this.level4x4ToolStripMenuItem_Click);
            // 
            // level5x5ToolStripMenuItem
            // 
            this.level5x5ToolStripMenuItem.Name = "level5x5ToolStripMenuItem";
            this.level5x5ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.level5x5ToolStripMenuItem.Text = "Level 5x5";
            this.level5x5ToolStripMenuItem.Click += new System.EventHandler(this.level5x5ToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 609);
            this.Controls.Add(this.panelNen);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game1";
            this.Text = "Game1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhGoc)).EndInit();
            this.panelNen.ResumeLayout(false);
            this.panelNen.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbAnhGoc;
		private System.Windows.Forms.Panel panelAnh;
		private System.Windows.Forms.Button btNewgame;
		private System.Windows.Forms.Button btReplay;
		private System.Windows.Forms.Button btThoat;
		private System.Windows.Forms.Panel panelNen;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem chọnLevelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem level4x4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem level5x5ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Button btPause;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button btKetqua;
		private System.Windows.Forms.Label lbBuoc;
		private System.Windows.Forms.Label lbSoBuoc;
		private System.Windows.Forms.Label lbDoKho;
		private System.Windows.Forms.Label lbDiem;
		private System.Windows.Forms.Label lbTenDoKho;
		private System.Windows.Forms.Label lbSoDiem;
		private System.Windows.Forms.ToolStripMenuItem level3x3ToolStripMenuItem;
	}
}

