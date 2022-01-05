using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DemoGame
{
    public partial class Game1 : Form
    {
        #region
        private Bitmap FileAnh;
        private int cellSize; // Kích thước từng ô
        private int soLuongCell = 0; // Số lượng mỗi ô
        private int ktraKhungRed = 0;
        string trangThai = "Chưa hoàn thành game!";
        int soDiem = 0;
        int soBuoc = 0;
        private string fileName = Application.StartupPath + @"/Image1/1.png";
        private List<PictureBox> anhGoc = new List<PictureBox>();
        // tọa độ để xác định vị trí các khung ảnh sẽ tạo ra
        private int toaDoX;
        private int toaDoY;
        Stopwatch stopWatch;
        /// Vị trí chuột trên khung ảnh khi bắt đầu khi bắt đầu drag
        /// Dùng để điều chỉnh vị trí chuột luôn tương đối với khung ảnh       
        private Point diemBDkeo;
        /// Vị trí khung ảnh gốc khi bắt đầu drag
        /// dùng để hoán đổi vị trí ảnh nếu 2 ảnh mới đè lên ảnh cũ         
        private Point viTriAnh;

        public Game1()
        {
            InitializeComponent();
            level(3);
            lbTenDoKho.Text = "3 x 3";
            lbSoDiem.Text = "0";
            lbSoBuoc.Text = "0";
        }
        void level(int x)
        {
            PictureBox A = null;
            for (int i = 0; i < soLuongCell * soLuongCell; i++)
                panelNen.Controls.Remove(anhGoc[i]);
            anhGoc.RemoveRange(0, soLuongCell * soLuongCell);
            panelAnh.Controls.Clear();
            panelAnh.Invalidate();
            soLuongCell = x;
            for (int i = 0; i < soLuongCell * soLuongCell; i++)
                anhGoc.Add(A);
            for (int i = 0; i < anhGoc.Count; i++)
            {
                anhGoc[i] = new PictureBox();
                anhGoc[i].MouseUp += new MouseEventHandler(picCell_MouseUp);
                anhGoc[i].MouseMove += new MouseEventHandler(picCell_MouseMove);
                anhGoc[i].MouseDown += new MouseEventHandler(picCell_MouseDown);
                panelNen.Controls.Add(anhGoc[i]);
            }
            // Thêm sự kiện vẽ lưới vào sự kiện Paint của panel Image
            panelAnh.Paint += new PaintEventHandler(VeKhung);
            LoadPicture();
            btNewgame.Enabled = true;
            //stopWatch.Stop();
        }
        #endregion

        private void picCell_MouseDown(object sender, MouseEventArgs e)
        {

            PictureBox pic = (PictureBox)sender;
            diemBDkeo = e.Location;
            viTriAnh = pic.Location;
            // Đưa khung ảnh lên trên cùng để ko bị che mất
            pic.BringToFront();
            ktraKhungRed = 1;
        }

        private void picCell_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            // Di chuyển khung ảnh theo chuột khi kéo
            if (e.Button == MouseButtons.Left)
            {
                pic.Location = new Point(pic.Left + e.X - diemBDkeo.X,
                    pic.Top + e.Y - diemBDkeo.Y);
            }
            // Tính vị trí dòng và cột với đơn vị là 1 CELL_SIZE
            int col = pic.Location.X / cellSize;
            int row = pic.Location.Y / cellSize;
            // Nếu nằm ngoài panel Image thì thoát hàm
            if (col >= soLuongCell || row >= soLuongCell)
                return;
            // Vẽ đường biên màu đỏ xác định vị trí mới của ảnh trên panel
            if (ktraKhungRed == 1)
            {
                Graphics g = panelAnh.CreateGraphics();
                g.DrawRectangle(Pens.Red, new Rectangle(col * cellSize, row * cellSize, cellSize, cellSize));
            }
        }

        private void picCell_MouseUp(object sender, MouseEventArgs e)
        {
            soBuoc++;
            lbSoBuoc.Text = soBuoc.ToString();
            PictureBox pic = (PictureBox)sender;
            // Tính vị trí mới của ảnh khít với dòng, cột trên panel
            int col = pic.Location.X / cellSize;
            int row = pic.Location.Y / cellSize;
            if (col >= soLuongCell || row >= soLuongCell)
                return;
            // Lấy control tại ví trí mới
            Control ctrl = panelNen.GetChildAtPoint(new Point(col * cellSize + 1, row * cellSize + 1));
            // Nếu đã có một khung ảnh tại ô này
            // thì chuyển vị trí của khung ảnh này về vị trí của khung ảnh vừa drop
            if (ctrl != null && ctrl is PictureBox)
            {
                ctrl.Location = viTriAnh;
            }
            // Gán vị trí mới cho khung ảnh
            pic.Location = new Point(col * cellSize + 1, row * cellSize + 1);
            

            if (CheckWin())
            {
                soDiem += 10; // Cộng 10 điểm sau mỗi lần win
                lbSoDiem.Text = soDiem.ToString();
                stopWatch.Stop();
                MessageBox.Show("Bạn đã hoàn thành !!! Thời gian là: " + lbTime.Text + "\n"+ "Số điểm hiện tại của bạn là: " + lbSoDiem.Text + "\n" +
                            "Tổng số bước thực hiện là: " + lbSoBuoc.Text, "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Rand_Anh();
                trangThai = "Đã hoàn thành game!";
            }
            ktraKhungRed = 0;
        }

        /// Ve luoi (khung) cho panel Anh
        /// 
        void VeKhung(object obj, PaintEventArgs pe)
        {
            Graphics g = panelAnh.CreateGraphics();
            Pen p = Pens.White;
            int length = cellSize * soLuongCell;
            for (int i = 0; i <= soLuongCell; i++) // Sử dụng vòng lặp để vẽ lưới ngang dọc cho panel
            {
                int pos = cellSize * i;
                // Vẽ lưới ngang
                Point p1 = new Point(0, pos);
                Point p2 = new Point(length, pos);
                g.DrawLine(p, p1, p2);//DrawLine gồm 3 tham số (Pen,Point,Point)
                // với Pen quy định nét vẽ màu sắc, size,...và Point là 2 điểm đầu cuối của đường thẳng
                // Vẽ lưới dọc
                p1 = new Point(pos, 0);
                p2 = new Point(pos, length);
                g.DrawLine(p, p1, p2);
            }
        }

        // Load anh
        private void LoadPicture()
        {
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Không tìm thấy file \n" + fileName);
                return;
            }
            try
            {
                // Căn chỉnh chiều cao và kích thước ảnh đã cắt cho phù hợp
                Bitmap bmp = new Bitmap(fileName); // Tạo ảnh bitmap từ file
                float minSize; // Kích thước nhỏ nhất của ảnh với chiều cao và chiều rộng bên dưới
                float width, height;
                if (bmp.Size.Width < bmp.Size.Height) // Nếu kích thước ảnh 
                    minSize = bmp.Size.Width;
                else
                    minSize = bmp.Size.Height;
                width = bmp.Size.Width; // Tiến hành lấy kích thước ảnh
                height = bmp.Size.Height;
                float heso = 350 / minSize; //Hệ số để tăng giảm kích thước ảnh
                if (heso > 0)
                {
                    // Thay đổi kích thước ảnh
                    width *= heso;
                    height *= heso;
                }
                // Nạp ảnh với kích thước mới
                int imageSize;
                FileAnh = new Bitmap(bmp, new Size((int)width, (int)height));
                // Lấy kích thước ảnh dựa vào chiều cao và chiều rộng
                if (FileAnh.Width < FileAnh.Height)
                    imageSize = FileAnh.Width;
                else
                    imageSize = FileAnh.Height;
                // Cắt ảnh cho vừa với số lượng khung hình
                imageSize -= imageSize % soLuongCell;
                // Tính độ rộng của một khung ảnh
                cellSize = imageSize / soLuongCell;
                // Tạo và sắp xếp các khung ảnh
                int kichThuoc = 150; // Kich thuoc anh goc
                int size = cellSize * soLuongCell + 3; // Kích thước của panelAnh chứa các khung
                toaDoX = size + 150; // Thay đổi kích thước form theo kích thước ảnh
                toaDoY = 0;

                ThietlapChung.catAnh(anhGoc, FileAnh, soLuongCell, cellSize, toaDoX, toaDoY, 0);

                // Trộn & hiển thị các khung ảnh
                //btTronAnh_Click(null, null);
                ThietlapChung.DoiViTriAnh(anhGoc, soLuongCell);
                Rectangle anhCon = new Rectangle(0, 0, imageSize, imageSize);
                Bitmap anhMau= FileAnh.Clone(anhCon, FileAnh.PixelFormat);
                pbAnhGoc.Image = new Bitmap(anhMau, new Size(kichThuoc, kichThuoc));

                // Tính toán vị trí mới
                panelAnh.Size = new Size(size, size);
                this.Size = new Size(size * 2 + 220, size + kichThuoc + 100 + 140); // kích thước mới cho panel chiều dài và chiều rộng
                pbAnhGoc.Location = new Point((size * 2 + 140) / 2 - (kichThuoc / 2), size + 60);
                stopWatch = new Stopwatch();
                stopWatch.Start();
                soBuoc = 0;
                lbSoBuoc.Text = soBuoc.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckWin()
        {
            // Phương pháp:
            // Lặp qua tất cả các cột và dòng trong panel Image
            // Lấy khung ảnh tại vị trí dòng, cột đó
            // Nếu khung ảnh ko tồn tại trả về false
            // Nếu khung ảnh có vị trí sai thứ tự trả về false
            for (int i = 0; i < soLuongCell; i++)
                {
                    for (int j = 0; j < soLuongCell; j++)
                    {
                        // Tính thứ tự đúng của khung ảnh ở vị trí hiện tại
                        int index = i * soLuongCell + j;
                        // Lấy control tại vị trí hiện tại
                        Control ctrl = panelNen.GetChildAtPoint(new Point(j * cellSize + 1, i * cellSize + 1));
                        // Nếu khung ảnh ko tồn tại trả về false
                        if (ctrl == null || !(ctrl is PictureBox))
                            return false;
                        // Nếu khung ảnh có vị trí sai trả về false
                        if (ctrl.Tag.ToString() != index.ToString())
                            return false;
                    }
                }
            return true; 
        }
        private void Rand_Anh()
        {
            //Tạo các ảnh mới khi new game
            Random rand = new Random();
            int so;
            so = rand.Next(1, 10);
            fileName = Application.StartupPath + "//image1/" + so + ".png";
            LoadPicture();
        }
        private void btNewgame_Click(object sender, EventArgs e)
        {
            Rand_Anh();
            LoadPicture();
            btPause.Text = "Tạm dừng";
            btPause.UseVisualStyleBackColor = true;
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            DialogResult YesorNo = new DialogResult();
            if (lbTime.Text != "00:00:00")
            {
                YesorNo = MessageBox.Show("Bạn có chắc muốn chơi lại?", "Game Puzzel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesorNo == DialogResult.Yes || lbTime.Text == "00:00:00")
            {
                stopWatch.Reset();
                level(soLuongCell);
                soBuoc = 0;
                lbSoBuoc.Text = soBuoc.ToString();
                soDiem = 0;
                lbSoDiem.Text = soDiem.ToString();
                btPause.Text = "Tạm dừng";
                btPause.UseVisualStyleBackColor = true;
            }
			else
			{
                stopWatch.Start();
            }

        }

        private void btPause_Click(object sender, EventArgs e)
        {           
			if (btPause.Text == "Tạm dừng")
			{
                stopWatch.Stop();
                btPause.Text = "Tiếp tục";
                btPause.BackColor = Color.Lime;
            }
			else
			{
                stopWatch.Start();
                btPause.Text = "Tạm dừng";
                btPause.UseVisualStyleBackColor = true;
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = string.Format("{0:hh\\:mm\\:ss}",stopWatch.Elapsed);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void level3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level(3);
            lbTenDoKho.Text = "3 x 3";
            btPause.Text = "Tạm dừng";
            btPause.UseVisualStyleBackColor = true;
        }
        private void level4x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level(4);
            lbTenDoKho.Text = "4 x 4";
            btPause.Text = "Tạm dừng";
            btPause.UseVisualStyleBackColor = true;

        }
        private void level5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level(5);
            lbTenDoKho.Text = "5 x 5";
            btPause.Text = "Tạm dừng";
            btPause.UseVisualStyleBackColor = true;
        }

        private void btKetqua_Click(object sender, EventArgs e)
		{
            StreamWriter streamWriter;
            string path = @"D:\KetQuaGameXepHinh.txt";
            string ketQua = "";
            try
            {
                if (!File.Exists(path))
                {
                    streamWriter = new StreamWriter(path); // Tạo đường dẫn
                    string[] chuoiLuu;

                    ketQua = string.Format("{0 : dd/MM/yyyy HH:mm:ss}\n" + "Mức: " + lbTenDoKho.Text + "\n" +
                        "Trạng thái: " + trangThai + "\n" +
                        "Số điểm: " + lbSoDiem.Text + "\n" +
                        "Số bước " + lbSoBuoc.Text + "\n" +
                        "Tổng thời gian: " + lbTime.Text + "\n", DateTime.Now);
                    chuoiLuu = new string[] { ketQua };
                    foreach (string item in chuoiLuu)
                    {
                        streamWriter.WriteLine(ketQua);
                    }
                    streamWriter.Close();
                }
                else
                {
                    streamWriter = File.AppendText(path);
                    ketQua = string.Format("{0 : dd/MM/yyyy HH:mm:ss}\n" + "Mức: " + lbTenDoKho.Text + "\n" +
                        "Trạng thái: " + trangThai + "\n" +
                        "Số điểm: " + lbSoDiem.Text + "\n" +
                        "Số bước " + lbSoBuoc.Text + "\n" +
                        "Tổng thời gian: " + lbTime.Text + "\n\n", DateTime.Now);
                    streamWriter.WriteLine(ketQua);
                    streamWriter.Close();
                }
                MessageBox.Show("Lưu kết quả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
	}
}