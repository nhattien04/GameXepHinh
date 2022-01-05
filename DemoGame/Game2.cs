using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGame
{
    public partial class Game2 : Form
    {
        public Game2()
        {
            InitializeComponent();
        }

        int cellCount = 3;
        int x, y;
        int soDiem = 0;
        int soBuoc = 0;
        string trangThai = "Chưa hoàn thành game!"; // Để đưa vào file lưu xuống máy
        List<PictureBox> listAnh = new List<PictureBox>();
        Stopwatch stopWatch = new Stopwatch();
        bool flag = false; // Biến này dùng để báo hiệu trạng thái, từ đó cho phép xử lý nút bấm điều hướng


        private void CatAnh(List<PictureBox> anhSapXep, Bitmap ImageFile, int cellSize, int cellCount)
        {
            int cellIndex = 0; // ô vuông thứ mấy, bắt đầu từ 0
            for (int j = 0; j < cellCount; j++)
            {
                for (int i = 0; i < cellCount; i++)
                {
                    Rectangle anhCon = new Rectangle(i * cellSize, j * cellSize, cellSize, cellSize); // Một ô ảnh nhỏ
                    anhSapXep.Add((new PictureBox()));
                    anhSapXep[cellIndex].Image = ImageFile.Clone(anhCon, ImageFile.PixelFormat);
                    anhSapXep[cellIndex].Tag = cellIndex.ToString(); // Lưu trữ 1 thông tin tạm thời liên quan đến PictureBox
                    cellIndex++; // Tăng giá trị của ô vuông, và tạo ô tiếp theo cắt ra từ ảnh ban đầu

                }
            }
        }
        private void GameXepHinh_Load(object sender, EventArgs e)
        {
            //load anh góc và ảnh panel
            LoadAnh();
            //vitri o trong hien tai
            x = cellCount - 1;
            y = cellCount - 1;

            // Mức mặc định trong sự kiện form_load mặc định là 3 x 3
            lbTenDoKho.Text = "3 x 3";

            btTamDung.Enabled = false;
            btLuu.Enabled = false;
            lbSoDiem.Text = "0";
            lbSoBuoc.Text = "0";

            // Ngăn cản bấm phím điều hướng khi game chưa bắt đầu
            btUp.Enabled = false;
            btDown.Enabled = false;
            btLeft.Enabled = false;
            btRight.Enabled = false;

            flag = false; // Không cho phép bấm phím điều hướng     
        }
        private void btBatDau_Click(object sender, EventArgs e)
        {
            TronAnh();
            x = cellCount - 1;
            y = cellCount - 1;

            stopWatch.Reset(); // Reset đồng hồ ở vòng chơi trước
            soBuoc = 0;
            lbSoBuoc.Text = soBuoc.ToString();

            // Cho phép sử dụng các button
            btBatDau.Enabled = false;
            btTamDung.Enabled = true;
            btThayDoi.Enabled = false;
            btLuu.Enabled = true;

            // Cho phép bấm các phím điều hướng
            btUp.Enabled = true;
            btDown.Enabled = true;
            btLeft.Enabled = true;
            btRight.Enabled = true;

            stopWatch.Start(); // Đồng hồ bắt đầu chạy khi người chơi bấm bắt đầu

            flag = true; // Cho phép bấm phím điều hướng
        }
        private void btTamDung_Click(object sender, EventArgs e)
        {
            // Xử lý khi người chơi bấm tạm dừng để suy nghĩ
            if (btTamDung.Text == "Tạm dừng")
            {
                stopWatch.Stop();
                btTamDung.Text = "Tiếp tục"; // Đổi text
                btTamDung.BackColor = Color.Lime;
                btBatDau.Enabled = false;
                btTamDung.Enabled = true;
                btThayDoi.Enabled = true;

                // Không cho phép bấm phím điều hướng khi game đang tạm dừng
                btUp.Enabled = false;
                btDown.Enabled = false;
                btLeft.Enabled = false;
                btRight.Enabled = false;

                // Không cho phép bấm phím điều hướng
                flag = false;
            }
            else // Trường hợp hiện tại của button là Tiếp tục
            {
                stopWatch.Start();
                btTamDung.Text = "Tạm dừng";
                btTamDung.UseVisualStyleBackColor = true;
                btThayDoi.Enabled = false;

                // Cho phép bấm phím điều hướng khi game đang tạm dừng
                btUp.Enabled = true;
                btDown.Enabled = true;
                btLeft.Enabled = true;
                btRight.Enabled = true;

                // Cho phép bấm phím điều hướng
                flag = true;

            }
        }
        private void ChoiLai() // Hàm này chỉ reset thời gian và số bước chơi, không reset điểm
        {
            btBatDau.Enabled = true;
            btTamDung.Enabled = false;
            btThayDoi.Enabled = true;
            LoadAnh();

            // Điểm vẫn giữ nguyên
            stopWatch.Reset(); // Reset đồng hồ 
            soBuoc = 0;
            lbSoBuoc.Text = soBuoc.ToString();
        }
        private void mnChoiLai_Click(object sender, EventArgs e) // Sẽ reset điểm, số bước và thời gian
        {
            ChoiLai();
            soDiem = 0;
            lbSoDiem.Text = soDiem.ToString();
            btTamDung.Text = "Tạm dừng";
            btTamDung.UseVisualStyleBackColor = true;
        }
        private void TronAnh()
        {
            Random ran = new Random();
            for (int i = 1; i < cellCount * cellCount; i++)
            {
                //đổi con ở vị trí đầu tiên đến 1 ô ngẫu  nhiên nào đó
                flowLPPic.Controls.SetChildIndex(flowLPPic.GetChildAtPoint(new Point(5, 5)), ran.Next(1, cellCount * cellCount));
            }
            // thiết lập ô trống về vị trí cuối cùng
            flowLPPic.Controls.SetChildIndex(listAnh[cellCount * cellCount - 1], cellCount * cellCount - 1);
        }

        //xóa ảnh củ và load ảnh gốc và ảnh trên panel mới(đã cắt) 
        private void LoadAnh()
        {
            //xóa ảnh củ
            flowLPPic.Controls.Clear();
            pbAnhGoc.Image = null;

            //lấy anhe
            string path = Application.StartupPath + @"\Image2\";
            PictureBox picAnh = new PictureBox();
            picAnh.Image = Image.FromFile(path + new Random().Next(1, 11) + ".jpg");
            Bitmap bitmap = new Bitmap(picAnh.Image);

            //đưa anhe góc lên
            pbAnhGoc.Image = bitmap;
            pbAnhGoc.SizeMode = PictureBoxSizeMode.StretchImage;

            //lấy size
            int flSize = flowLPPic.Width;
            int size;
            if (bitmap.Width > bitmap.Height)
                size = bitmap.Height;
            else
                size = bitmap.Width;

            //tạo pictureBox và định dạng
            for (int i = 0; i < cellCount * cellCount; i++)
            {
                listAnh.Add(new PictureBox());
                listAnh[i].SizeMode = PictureBoxSizeMode.StretchImage;
                listAnh[i].Size = new Size(flSize / cellCount - 10 + cellCount / 2, flSize / cellCount - 10 + cellCount / 2);
            }

            // Cắt Ảnh
            CatAnh(listAnh, bitmap, (size / cellCount) - 5, cellCount);
    
            //đặt ảnh cuối về null
            listAnh[cellCount * cellCount - 1].Image = null;

            //add ảnh vào flowlayoutpanel
            for (int i = 0; i < cellCount * cellCount; i++)
            {
                flowLPPic.Controls.Add(listAnh[i]);
            }
        }
        private void btThayDoi_Click(object sender, EventArgs e)
        {
            if (btBatDau.Enabled)
            {
                LoadAnh();

                // Đưa số bước thực hiện trở về 0, số điểm vẫn giữ
                soBuoc = 0;
                lbSoBuoc.Text = soBuoc.ToString();
            }

            stopWatch.Stop(); // Làm mới
            DialogResult YesorNo = new DialogResult(); // Box câu hỏi, cảnh báo
            if (lbTinhThoiGian.Text != "00:00:00") // Đang chạy thời gian của game đang chơi
            {
                YesorNo = MessageBox.Show("Bạn muốn thay đổi?", "Thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesorNo == DialogResult.Yes || lbTinhThoiGian.Text == "00:00:00")
            {
                // Cho reset lại thời gian và load ảnh mới lên
                stopWatch.Reset();
                LoadAnh(); // Vừa cho dừng thời gian vừa load ảnh mới để thay đổi
                btBatDau.Enabled = true;
                btLuu.Enabled = false;

                // Đổi màu và text của nút Tạm dừng trong trường hợp người chơi cho dừng trò chơi và thay đổi
                btTamDung.Enabled = false;
                btTamDung.Text = "Tạm dừng";
                btTamDung.UseVisualStyleBackColor = true;

                // Đưa số bước thực hiện trở về 0, số điểm vẫn giữ
                soBuoc = 0;
                lbSoBuoc.Text = soBuoc.ToString();
            }
            else
            {
                // Không làm gì cả
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (flag == true) // Đã bấm nút Bắt đầu hoặc Tiếp tục
            {
                switch (keyData)
                {
                    case Keys.Up:
                        btUp_Click(null, null);
                        return true;
                    case Keys.Down:
                        btDown_Click(null, null);
                        return true;
                    case Keys.Left:
                        btLeft_Click(null, null);
                        return true;
                    case Keys.Right:
                        btRight_Click(null, null);
                        return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        private void btMove_Click(int x1, int y1)
        {
            //hoạt động khi đã bắt đầu
            if (!btBatDau.Enabled)
            {
                //lấy control hiện tại và control chuẩn bị đổi
                Control ctr1 = flowLPPic.Controls[x + y * cellCount];
                Control ctr2 = flowLPPic.Controls[x1 + y1 * cellCount];

                //hoán đổi vị trí 2 control với nhau
                flowLPPic.Controls.SetChildIndex(ctr2, x + y * cellCount);
                flowLPPic.Controls.SetChildIndex(ctr1, x1 + y1 * cellCount);

                //nếu ảnh null về cuối thì check win
                if (x1 == cellCount - 1 && y1 == cellCount - 1)
                {
                    if (checkWin())
                    {
                        stopWatch.Stop(); // Dừng đồng hồ khi game hoàn thành
                        soDiem += 10; // Công 10 điểm sau mỗi lần win
                        lbSoDiem.Text = soDiem.ToString();
                        MessageBox.Show("Bạn đã hoàn thành trong thời gian: " + lbTinhThoiGian.Text + "\n" +
                            "Số điểm hiện tại của bạn là: " + lbSoDiem.Text + "\n" +
                            "Tổng số bước thực hiện là: " + lbSoBuoc.Text, "Hoàn thành",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        trangThai = "Đã hoàn thành game!"; // Để lưu thông tin vào file trên máy

                        btBatDau.Enabled = true;
                        btTamDung.Enabled = false;
                        btThayDoi.Enabled = true;
                        LoadAnh();

                        // Điểm số vẫn giữ nguyên, OK và tiếp tục chơi
                        //stopWatch.Reset(); // Reset đồng hồ 
                        //soBuoc = 0;
                        //lbSoBuoc.Text = soBuoc.ToString();

                        flag = false; // Ngăn chặn bấm số bước vẫn chạy khi vừa nhấn OK sau khi win
                    }
                }
            }
        }
        private void btDown_Click(object sender, EventArgs e)
        {
            if (y + 1 < cellCount)
            {
                btMove_Click(x, y + 1);
                y++;
                if (btBatDau.Enabled == false)
                {
                    soBuoc++;
                    lbSoBuoc.Text = soBuoc.ToString();
                }
            }

        }
        private void btUp_Click(object sender, EventArgs e)
        {
            if (y - 1 >= 0)
            {
                btMove_Click(x, y - 1);
                y--;
                if (btBatDau.Enabled == false)
                {
                    soBuoc++;
                    lbSoBuoc.Text = soBuoc.ToString();
                }
            }

        }
        private void btLeft_Click(object sender, EventArgs e)
        {
            if (x - 1 >= 0)
            {
                btMove_Click(x - 1, y);
                x--;
                if (btBatDau.Enabled == false)
                {
                    soBuoc++;
                    lbSoBuoc.Text = soBuoc.ToString();
                }
            }

        }
        private void btRight_Click(object sender, EventArgs e)
        {
            if (x + 1 < cellCount)
            {
                btMove_Click(x + 1, y);
                x++;
                if (btBatDau.Enabled == false)
                {
                    soBuoc++;
                    lbSoBuoc.Text = soBuoc.ToString();
                }
            }

        }
        private bool checkWin()
        {
            int check = 0;
            //lấy từ đâu đến cuối
            foreach (Control item in flowLPPic.Controls)
            {
                if (item.Tag.ToString() != check.ToString())
                {
                    return false;
                }
                check++;
            }
            return true;
        }
        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cellCount = 3;
            //mnChoiLai_Click(null, null);
            ChoiLai();
            lbTenDoKho.Text = "3 x 3";
            btTamDung.Text = "Tạm dừng";
            btTamDung.UseVisualStyleBackColor = true;
        }
        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cellCount = 4;
            //mnChoiLai_Click(null, null);
            ChoiLai();
            lbTenDoKho.Text = "4 x 4";
            btTamDung.Text = "Tạm dừng";
            btTamDung.UseVisualStyleBackColor = true;
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cellCount = 5;
            //mnChoiLai_Click(null, null);
            ChoiLai();
            lbTenDoKho.Text = "5 x 5";
            btTamDung.Text = "Tạm dừng";
            btTamDung.UseVisualStyleBackColor = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTinhThoiGian.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
        } // Dùng cho bấm giờ
        private void mnThoat_Click(object sender, EventArgs e)
        {          
            this.Close();        
        }
        
        private void btLuu_Click(object sender, EventArgs e)
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
                        "Tổng thời gian: " + lbTinhThoiGian.Text + "\n", DateTime.Now);
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
                        "Tổng thời gian: " + lbTinhThoiGian.Text + "\n\n", DateTime.Now);
                    streamWriter.WriteLine(ketQua);
                    streamWriter.Close();
                }
                MessageBox.Show("Lưu kết quả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // Lưu file

		
    }
}
