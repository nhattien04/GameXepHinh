using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DemoGame
{
    class ThietlapChung
    {
        //Phương pháp:
        //Để hoán đổi vị trí các bức ảnh ta dùng cách hoán vị thuộc tính Image và Tag của hai PictureBox,
        //như vậy các PictureBox vẫn giữ nguyên vị trí index trên panel, chỉ có index trong Tag thay đổi.

        public static void DoiViTriAnh(List<PictureBox> anhGoc, int soLuongCell)
        {
            Bitmap bmp; // đối tượng bitmap tạm dùng cho việc hoán vị 2 khung ảnh
            Random rnd = new Random(); // giá trị random lớn nhất bằng tổng số khung ảnh
            int maxValue = soLuongCell * soLuongCell; // số lần xáo trộn khung ảnh = maxValue
            for (int i = 0; i < maxValue; i++)
            {
                // index của khung ảnh nguồn và đích sẽ hoán vị
                int indexNguon = rnd.Next(maxValue);
                int indexDich = rnd.Next(maxValue);
                // nếu bằng nhau thì bỏ qua
                if (indexNguon == indexDich)
                    continue;
                try
                {
                    // lưu lại ảnh của khung ảnh nguồn
                    bmp = (Bitmap)anhGoc[indexNguon].Image;
                    bmp.Tag = anhGoc[indexNguon].Tag.ToString(); // lưu tag của khung ảnh nguồn
                    anhGoc[indexNguon].Image = anhGoc[indexDich].Image; // bắt đầu hoán vị 2 khung ảnh
                    anhGoc[indexNguon].Tag = anhGoc[indexDich].Tag;
                    anhGoc[indexDich].Image = bmp;
                    anhGoc[indexDich].Tag = bmp.Tag;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Phương pháp:
        // cắt file ảnh gốc ra thành các phần nhỏ
        // mỗi phần cho vào một khung ảnh (pictureBox)
        // Xếp vị trí của khung ảnh trên form
        // sử dụng thuộc tính tag của PictureBox để lưu lại số thứ tự (index) của khung ảnh
        // Số thứ tự xác định vị trí thật sự của khung ảnh
        // và là cơ sở để kiểm tra xem người chơi có xếp đúng vị trí ko       
        public static void catAnh(List<PictureBox> anhGoc, Bitmap FileAnh, int soLuongCell, int cellSize, int toaDoX, int toaDoY, int khoangCach)
        {
            if (FileAnh != null)
            {
                int cellIndex = 0; // Số thự tự các khung ảnh
                for (int j = 0; j < soLuongCell; j++)
                {
                    for (int i = 0; i < soLuongCell; i++)
                    {
                        try
                        {

                            //Tạo khung hình chữ nhật để cắt ảnh từ file ảnh gốc, có vị trí cắt từ cột i dòng j
                            //và kích thước bằng với khung ảnh (cellSize)
                            Rectangle anhCon = new Rectangle(i * cellSize, j * cellSize, cellSize, cellSize);
                            anhGoc[cellIndex].Image = null; // Xóa ảnh cũ của khung ảnh
                            // ảnh dựa vào vị trí và kích thước khung chữ nhật ta truyền vào
                            anhGoc[cellIndex].Image = FileAnh.Clone(anhCon, FileAnh.PixelFormat);
                            // Xếp vị trí cho khung ảnh, bằng vị trí cột, dòng
                            anhGoc[cellIndex].Location = new Point(toaDoX + i * (cellSize + khoangCach), toaDoY + j * (cellSize + khoangCach));
                            // Tăng kích thước khung ảnh lên 1 để có đường biên giữa các khung ảnh
                            anhGoc[cellIndex].Size = new Size(cellSize, cellSize);
                            // Lưu số thứ tự của khung ảnh lại (vị trí ảnh để check win)
                            anhGoc[cellIndex].Tag = cellIndex.ToString();
                            cellIndex++; // Tăng số thứ tự (vị trí) 

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
        }
    }
}
