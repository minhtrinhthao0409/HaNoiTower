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
    public partial class Form1 : Form
    {
        TimeSpan time;
        int moveCount;
        PictureBox[] disks;
        //MyStack<PictureBox> diskA, diskB, diskC;

        
        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox[] {disk1, disk2, disk3, disk4, disk5, disk6, disk7, disk8};
        }

        private void showRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luật chơi:" +
                "\r\n\r\nChỉ được di chuyển một đĩa mỗi lần." +
                "\r\nChỉ được lấy đĩa ở trên cùng của cọc." +
                "\r\nKhông được đặt đĩa lớn lên trên đĩa nhỏ hơn.",
                "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);    
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
            button1.Enabled = false;
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
        }
    }
}
