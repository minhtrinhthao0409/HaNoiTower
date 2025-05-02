using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaNoiTowerGame
{
    public class HanoiSolver
    {
        private HanoiTower source;
        private HanoiTower auxiliary;
        private HanoiTower destination;
        private Form form;

        public HanoiSolver(HanoiTower src, HanoiTower aux, HanoiTower dst, Form uiForm)
        {
            source = src;
            auxiliary = aux;
            destination = dst;
            form = uiForm;

        }
        public int countMove = 0;
        public async Task SolveAsync(int n)
        {
            await MoveDisks(n, source, destination, auxiliary);
            
        }

        private async Task MoveDisks(int n, HanoiTower src, HanoiTower dst, HanoiTower aux)
        {
            if (n <= 0) return;

            // Di chuyển n-1 đĩa sang cột trung gian
            await MoveDisks(n - 1, src, aux, dst);

            // Di chuyển đĩa còn lại sang đích
            await MoveOneDisk(src, dst);

            // Di chuyển n-1 đĩa từ trung gian sang đích
            await MoveDisks(n - 1, aux, dst, src);

            
        }

        private async Task MoveOneDisk(HanoiTower from, HanoiTower to)
        {
            if (!from.IsEmpty())
            {
                PictureBox disk = from.Pop();

                // Thêm vào tháp đích
                to.AddDisk(disk);

                // Cập nhật tọa độ UI
                int baseX = GetTowerBaseX(to);
                int diskIndex = to.Count() - 1; // 0-based
                int diskY = 335 - diskIndex * 25; // Tùy chỉnh chiều cao cột

                disk.Location = new System.Drawing.Point(baseX, diskY);
                disk.BringToFront(); // Đảm bảo đĩa hiện lên trên
                form.Refresh();

                await Task.Delay(500); // Thời gian chờ giữa các bước
            }
            countMove++;
        }

        private int GetTowerBaseX(HanoiTower tower)
        {
            switch (tower.Name)
            {
                case "A": return 62;
                case "B": return 265;
                case "C": return 468;
                default: return 0;
            }
        }
    }
}
