namespace HaNoiTowerGame
{
    partial class HaNoiTowerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaNoiTowerGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disk8 = new System.Windows.Forms.PictureBox();
            this.disk7 = new System.Windows.Forms.PictureBox();
            this.disk6 = new System.Windows.Forms.PictureBox();
            this.disk5 = new System.Windows.Forms.PictureBox();
            this.disk4 = new System.Windows.Forms.PictureBox();
            this.disk3 = new System.Windows.Forms.PictureBox();
            this.disk2 = new System.Windows.Forms.PictureBox();
            this.disk1 = new System.Windows.Forms.PictureBox();
            this.RodC = new System.Windows.Forms.PictureBox();
            this.RodB = new System.Windows.Forms.PictureBox();
            this.RodA = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMove = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.showRule = new System.Windows.Forms.Button();
            this.btnSolved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.disk8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // disk8
            // 
            this.disk8.Image = ((System.Drawing.Image)(resources.GetObject("disk8.Image")));
            this.disk8.Location = new System.Drawing.Point(60, 188);
            this.disk8.Name = "disk8";
            this.disk8.Size = new System.Drawing.Size(163, 25);
            this.disk8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk8.TabIndex = 18;
            this.disk8.TabStop = false;
            this.disk8.Tag = "8";
            this.disk8.Click += new System.EventHandler(this.disk_click);
            // 
            // disk7
            // 
            this.disk7.Image = ((System.Drawing.Image)(resources.GetObject("disk7.Image")));
            this.disk7.Location = new System.Drawing.Point(60, 208);
            this.disk7.Name = "disk7";
            this.disk7.Size = new System.Drawing.Size(163, 25);
            this.disk7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk7.TabIndex = 17;
            this.disk7.TabStop = false;
            this.disk7.Tag = "7";
            this.disk7.Click += new System.EventHandler(this.disk_click);
            // 
            // disk6
            // 
            this.disk6.Image = ((System.Drawing.Image)(resources.GetObject("disk6.Image")));
            this.disk6.Location = new System.Drawing.Point(60, 229);
            this.disk6.Name = "disk6";
            this.disk6.Size = new System.Drawing.Size(163, 25);
            this.disk6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk6.TabIndex = 16;
            this.disk6.TabStop = false;
            this.disk6.Tag = "6";
            this.disk6.Click += new System.EventHandler(this.disk_click);
            // 
            // disk5
            // 
            this.disk5.Image = ((System.Drawing.Image)(resources.GetObject("disk5.Image")));
            this.disk5.Location = new System.Drawing.Point(60, 248);
            this.disk5.Name = "disk5";
            this.disk5.Size = new System.Drawing.Size(163, 25);
            this.disk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk5.TabIndex = 15;
            this.disk5.TabStop = false;
            this.disk5.Tag = "5";
            this.disk5.Click += new System.EventHandler(this.disk_click);
            // 
            // disk4
            // 
            this.disk4.Image = ((System.Drawing.Image)(resources.GetObject("disk4.Image")));
            this.disk4.Location = new System.Drawing.Point(60, 272);
            this.disk4.Name = "disk4";
            this.disk4.Size = new System.Drawing.Size(163, 25);
            this.disk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk4.TabIndex = 14;
            this.disk4.TabStop = false;
            this.disk4.Tag = "4";
            this.disk4.Click += new System.EventHandler(this.disk_click);
            // 
            // disk3
            // 
            this.disk3.Image = ((System.Drawing.Image)(resources.GetObject("disk3.Image")));
            this.disk3.Location = new System.Drawing.Point(60, 296);
            this.disk3.Name = "disk3";
            this.disk3.Size = new System.Drawing.Size(163, 25);
            this.disk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk3.TabIndex = 13;
            this.disk3.TabStop = false;
            this.disk3.Tag = "3";
            this.disk3.Click += new System.EventHandler(this.disk_click);
            // 
            // disk2
            // 
            this.disk2.Image = ((System.Drawing.Image)(resources.GetObject("disk2.Image")));
            this.disk2.Location = new System.Drawing.Point(60, 315);
            this.disk2.Name = "disk2";
            this.disk2.Size = new System.Drawing.Size(163, 25);
            this.disk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk2.TabIndex = 12;
            this.disk2.TabStop = false;
            this.disk2.Tag = "2";
            this.disk2.Click += new System.EventHandler(this.disk_click);
            // 
            // disk1
            // 
            this.disk1.Image = ((System.Drawing.Image)(resources.GetObject("disk1.Image")));
            this.disk1.Location = new System.Drawing.Point(60, 335);
            this.disk1.Name = "disk1";
            this.disk1.Size = new System.Drawing.Size(164, 25);
            this.disk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disk1.TabIndex = 11;
            this.disk1.TabStop = false;
            this.disk1.Tag = "1";
            this.disk1.Click += new System.EventHandler(this.disk_click);
            // 
            // RodC
            // 
            this.RodC.Image = ((System.Drawing.Image)(resources.GetObject("RodC.Image")));
            this.RodC.Location = new System.Drawing.Point(467, 156);
            this.RodC.Name = "RodC";
            this.RodC.Size = new System.Drawing.Size(165, 226);
            this.RodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodC.TabIndex = 10;
            this.RodC.TabStop = false;
            this.RodC.Click += new System.EventHandler(this.cot_Click);
            // 
            // RodB
            // 
            this.RodB.Image = ((System.Drawing.Image)(resources.GetObject("RodB.Image")));
            this.RodB.Location = new System.Drawing.Point(263, 156);
            this.RodB.Name = "RodB";
            this.RodB.Size = new System.Drawing.Size(165, 226);
            this.RodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodB.TabIndex = 8;
            this.RodB.TabStop = false;
            this.RodB.Click += new System.EventHandler(this.cot_Click);
            // 
            // RodA
            // 
            this.RodA.Image = ((System.Drawing.Image)(resources.GetObject("RodA.Image")));
            this.RodA.Location = new System.Drawing.Point(59, 156);
            this.RodA.Name = "RodA";
            this.RodA.Size = new System.Drawing.Size(165, 226);
            this.RodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodA.TabIndex = 6;
            this.RodA.TabStop = false;
            this.RodA.Click += new System.EventHandler(this.cot_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(70, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(172, 28);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "Time: 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(534, 447);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(98, 28);
            this.lblMove.TabIndex = 20;
            this.lblMove.Text = "Move: 0";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Enabled = false;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.Location = new System.Drawing.Point(592, 24);
            this.level.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.level.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(40, 26);
            this.level.TabIndex = 21;
            this.level.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Num of disks:";
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(60, 84);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(133, 30);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.Location = new System.Drawing.Point(216, 84);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(133, 30);
            this.btnGiveUp.TabIndex = 2;
            this.btnGiveUp.Text = "Give up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // showRule
            // 
            this.showRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRule.Location = new System.Drawing.Point(499, 84);
            this.showRule.Name = "showRule";
            this.showRule.Size = new System.Drawing.Size(133, 30);
            this.showRule.TabIndex = 4;
            this.showRule.Text = "How To Play";
            this.showRule.UseVisualStyleBackColor = true;
            this.showRule.Click += new System.EventHandler(this.showRule_Click);
            // 
            // btnSolved
            // 
            this.btnSolved.Enabled = false;
            this.btnSolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolved.Location = new System.Drawing.Point(360, 84);
            this.btnSolved.Name = "btnSolved";
            this.btnSolved.Size = new System.Drawing.Size(133, 30);
            this.btnSolved.TabIndex = 3;
            this.btnSolved.Text = "Solved!";
            this.btnSolved.UseVisualStyleBackColor = true;
            this.btnSolved.Click += new System.EventHandler(this.btnSolved_Click);
            // 
            // HaNoiTowerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(680, 512);
            this.Controls.Add(this.btnSolved);
            this.Controls.Add(this.showRule);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.level);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.disk8);
            this.Controls.Add(this.disk7);
            this.Controls.Add(this.disk6);
            this.Controls.Add(this.disk5);
            this.Controls.Add(this.disk4);
            this.Controls.Add(this.disk3);
            this.Controls.Add(this.disk2);
            this.Controls.Add(this.disk1);
            this.Controls.Add(this.RodC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RodB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RodA);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HaNoiTowerGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tháp Hà Nội";
            ((System.ComponentModel.ISupportInitialize)(this.disk8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RodA;
        private System.Windows.Forms.PictureBox RodB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox RodC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox disk1;
        private System.Windows.Forms.PictureBox disk2;
        private System.Windows.Forms.PictureBox disk3;
        private System.Windows.Forms.PictureBox disk4;
        private System.Windows.Forms.PictureBox disk5;
        private System.Windows.Forms.PictureBox disk6;
        private System.Windows.Forms.PictureBox disk7;
        private System.Windows.Forms.PictureBox disk8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button showRule;
        private System.Windows.Forms.Button btnSolved;
    }
}

