
namespace DemoGame
{
	partial class StartGame
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
			this.btGame1 = new System.Windows.Forms.Button();
			this.btGame2 = new System.Windows.Forms.Button();
			this.btThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btGame1
			// 
			this.btGame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btGame1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btGame1.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
			this.btGame1.ForeColor = System.Drawing.Color.Blue;
			this.btGame1.Location = new System.Drawing.Point(185, 419);
			this.btGame1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btGame1.Name = "btGame1";
			this.btGame1.Size = new System.Drawing.Size(143, 48);
			this.btGame1.TabIndex = 1;
			this.btGame1.Text = "Game1";
			this.btGame1.UseVisualStyleBackColor = false;
			this.btGame1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btGame2
			// 
			this.btGame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btGame2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btGame2.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
			this.btGame2.ForeColor = System.Drawing.Color.Blue;
			this.btGame2.Location = new System.Drawing.Point(185, 488);
			this.btGame2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btGame2.Name = "btGame2";
			this.btGame2.Size = new System.Drawing.Size(143, 47);
			this.btGame2.TabIndex = 1;
			this.btGame2.Text = "Game2";
			this.btGame2.UseVisualStyleBackColor = false;
			this.btGame2.Click += new System.EventHandler(this.btGame2_Click);
			// 
			// btThoat
			// 
			this.btThoat.BackColor = System.Drawing.Color.Gray;
			this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btThoat.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Bold);
			this.btThoat.ForeColor = System.Drawing.Color.AliceBlue;
			this.btThoat.Location = new System.Drawing.Point(185, 552);
			this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(143, 49);
			this.btThoat.TabIndex = 1;
			this.btThoat.Text = "Exit";
			this.btThoat.UseVisualStyleBackColor = false;
			this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
			// 
			// StartGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DemoGame.Properties.Resources.Backround_Game;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(517, 647);
			this.Controls.Add(this.btThoat);
			this.Controls.Add(this.btGame2);
			this.Controls.Add(this.btGame1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "StartGame";
			this.Text = "GameGhepHinh";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btGame1;
		private System.Windows.Forms.Button btGame2;
		private System.Windows.Forms.Button btThoat;
	}
}

