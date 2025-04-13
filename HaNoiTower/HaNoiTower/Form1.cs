using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaNoiTowerGame
{
    public partial class HaNoiTowerGame : Form
    {
        TimeSpan time;
        int moveCount;
        PictureBox[] disks;
        PictureBox currentFirstRod;
        HanoiTower disksA, disksB, disksC, firstTower, secondTower ;
        MyStack<PictureBox> firstClickedDisks, secondClickedDisks;
        const int FIRSTY = 335, DISKHEIGHT = 25; 

        public HaNoiTowerGame()
        {
            InitializeComponent();
            level.Enabled = true;
            disks = new PictureBox[] {disk1, disk2, disk3, disk4, disk5, disk6, disk7, disk8};
            RodA.Tag = disksA = new HanoiTower("A");
            RodB.Tag = disksB = new HanoiTower("B");
            RodC.Tag = disksC = new HanoiTower("C");

            RodA.Click += cot_Click;
            RodB.Click += cot_Click;
            RodC.Click += cot_Click;
        }

        private void showRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luật chơi:" +
                "\r\n\r\nChỉ được di chuyển một đĩa mỗi lần." +
                "\r\nChỉ được lấy đĩa ở trên cùng của cọc." +
                "\r\nKhông được đặt đĩa lớn lên trên đĩa nhỏ hơn.",
                "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }

        private void cot_Click(object sender, EventArgs e)
        {
            if (level.Enabled) return;

            PictureBox clickedRod = (PictureBox)sender;
            HanoiTower clickedTower = (HanoiTower)clickedRod.Tag;

            if (firstTower == null)
            {
                if (clickedTower.IsEmpty()) return;

                firstTower = clickedTower;
                currentFirstRod = clickedRod;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondTower == null)
            {
                if (clickedTower == firstTower)
                {
                    ResetClick();
                    return;
                }

                secondTower = clickedTower;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;

                ProcessMovingDisk(clickedRod);
            }


        }


        private void ProcessMovingDisk(PictureBox clickedRod)
        {
            if (firstTower == null || secondTower == null) return;

            if (secondTower.IsEmpty())
            {
                MoveDisk(new Point(clickedRod.Location.X, FIRSTY));
            }
            else
            {
                PictureBox firstTopDisk = firstTower.Peek();
                PictureBox secondTopDisk = secondTower.Peek();

                int size1 = int.Parse(firstTopDisk.Tag.ToString());
                int size2 = int.Parse(secondTopDisk.Tag.ToString());

                if (size1 < size2)
                {
                    MoveDisk(new Point(secondTopDisk.Location.X, secondTopDisk.Location.Y - DISKHEIGHT));
                }
                else
                {
                    MessageBox.Show("❌ Không được đặt đĩa lớn lên đĩa nhỏ hơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetClick();
                }
            }
        }

        private void disk_click(object sender, EventArgs e)
        {
            PictureBox clickedDisk = (PictureBox)sender;

            if (disksA.Contains(clickedDisk))
            {
                cot_Click(RodA, EventArgs.Empty);
            }
            else if (disksB.Contains(clickedDisk))
            {
                cot_Click(RodB, EventArgs.Empty);
            }
            else if (disksC.Contains(clickedDisk))
            {
                cot_Click(RodC, EventArgs.Empty);
            }
        }

        private void MoveDisk(Point point)
        {
            PictureBox disk = firstTower.Pop();

            bool success = secondTower.AddDisk(disk);
            if (!success)
            {
                firstTower.Push(disk);
                MessageBox.Show("❌ Không được đặt đĩa lớn lên đĩa nhỏ hơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetClick();
                return;
            }

            disk.Location = point;
            moveCount++;
            lblMove.Text = $"Move: {moveCount}";

            if (disksC.Count() == level.Value)
            {
                btnGiveUp.PerformClick();
                MessageBox.Show("🎉 Chúc mừng bạn đã thắng!");
            }

            ResetClick();
        }


        private void ResetClick()
        {
            firstTower = null;
            secondTower = null;

            if (currentFirstRod != null)
            {
                currentFirstRod.BorderStyle = BorderStyle.None;
                currentFirstRod = null;
            }

            RodA.BorderStyle = RodB.BorderStyle = RodC.BorderStyle = BorderStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = string.Format("Thời gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            level.Enabled = true;
            btnGiveUp.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // reset
            timer1.Stop();
            foreach (PictureBox disk in disks)
            {
                disk.Visible = false;
            }

            time = new TimeSpan(0);
            moveCount = 0;
            lblTime.Text = "Thời gian: 00:00:00";
            lblMove.Text = "Move: 0";
            disksA.Clear();
            disksB.Clear();
            disksC.Clear();

            RodA.BorderStyle = RodB.BorderStyle = RodC.BorderStyle = BorderStyle.None;
            firstClickedDisks = secondClickedDisks = null;
            // Khởi tạo gamne mới
            level.Enabled = false;
            btnGiveUp.Enabled = true;
            btnPlay.Text = "Play Again";
            int x = RodA.Location.X, y = FIRSTY;
            for (int i = 0; i <= (int)level.Value - 1; i++, y -= DISKHEIGHT)
            {
                disks[i].Location = new Point(x, y);
                disks[i].Visible = true;
                disksA.Push(disks[i]);
            }
            timer1.Start();

        }
    }
}
