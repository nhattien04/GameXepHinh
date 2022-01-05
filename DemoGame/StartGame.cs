using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGame
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();          
            Game1 f = new Game1();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            this.Show();
        }

		private void btThoat_Click(object sender, EventArgs e)
		{
            //this.Close();
            DialogResult YesorNo = new DialogResult();
            YesorNo = MessageBox.Show("Bạn muốn thoát game?", "Thoát game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesorNo == DialogResult.Yes)
            {
                Close();// Đóng form game
            }
            else
            {
                // Không làm gì cả
            }
        }

        private void btGame2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game2 f = new Game2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            this.Show();
        }
    }
}
