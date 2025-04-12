using System.Windows.Forms;
using System;

namespace HaNoiTowerGame
{
    public class HanoiTower : MyStack<PictureBox>
    {
        public string Name { get; set; }

        public HanoiTower(string name)
        {
            this.Name = name;
        }

        public bool AddDisk(PictureBox disk)
        {
            if (!this.IsEmpty())
            {
                PictureBox topDisk = this.Peek();

                // So sánh chiều rộng để xác định kích thước đĩa
                if (topDisk.Width <= disk.Width)
                {
                    return false;
                }
            }

            this.Push(disk);
            return true;
        }

        public PictureBox RemoveDisk()
        {
            if (this.IsEmpty())
                return null;

            return this.Pop();
        }

        public PictureBox PeekDisk()
        {
            return this.Peek();
        }

        //public void PrintTower()
        //{
        //    Console.WriteLine($"\n📦 Tower {Name}:");

        //    PictureBox[] disks = this.ToArray();
        //    for (int i = disks.Length - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine($" - Disk width: {disks[i].Width}");
        //    }

        //}
    }
}
