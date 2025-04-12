using System;
using System.Windows.Forms;

namespace HaNoiTowerGame
{
    public class HanoiSolver
    {
        public void Solve(int n, HanoiTower from, HanoiTower to, HanoiTower aux)
        {
            if (n == 1)
            {
                MoveDisk(from, to);
                return;
            }

            Solve(n - 1, from, aux, to);
            MoveDisk(from, to);
            Solve(n - 1, aux, to, from);
        }

        private void MoveDisk(HanoiTower from, HanoiTower to)
        {
            PictureBox disk = from.RemoveDisk();
            if (disk != null)
            {
                bool success = to.AddDisk(disk);
                if (!success)
                {
                    // Nếu đặt không hợp lệ, trả lại về tower cũ
                    from.AddDisk(disk);
                    Console.WriteLine("⚠️ Di chuyển không hợp lệ, trả đĩa về cọc cũ.");
                }
                else
                {
                    Console.WriteLine($"👉 Di chuyển đĩa (Width: {disk.Width}) từ {from.Name} → {to.Name}");

                    // Nếu bạn dùng giao diện WinForms, thêm xử lý di chuyển vị trí đĩa trên form ở đây
                    // Ví dụ: cập nhật tọa độ .Location của disk
                }
            }
        }
    }

}
