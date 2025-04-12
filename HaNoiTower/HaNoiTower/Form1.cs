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
        HanoiTower disksA, disksB, disksC;
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
            if (level.Enabled)
            {
                return;
            }
            PictureBox clickedRod = (PictureBox)sender;
            HanoiTower disksOfClickedRod = (HanoiTower)clickedRod.Tag;

            if (disksOfClickedRod == null)
            {
                if (disksOfClickedRod.Count() == 0) return;
                firstClickedDisks = disksOfClickedRod;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;
            }

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
