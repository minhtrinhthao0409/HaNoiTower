using System;

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
            int? disk = from.RemoveDisk();
            if (disk.HasValue)
            {
                to.AddDisk(disk.Value);
                
            }
        }
    }

}
