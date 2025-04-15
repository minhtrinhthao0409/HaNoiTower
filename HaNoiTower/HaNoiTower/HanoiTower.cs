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
            int size1 = int.Parse(disk.Tag.ToString());

            if (!this.IsEmpty())
            {
                PictureBox top = this.Peek();
                int size2 = int.Parse(top.Tag.ToString());
                if (size1 < size2)
                    return false;
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

    }
}
