using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingSportGame_ReBGaN
{
    public partial class Form1 : Form
    {

        private Point pos;
        private bool dragging,lose = false;
        private int countCoins = 0;
        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            labellosse.Visible = false;
            restart.Visible = false;
            KeyPreview = true;
            GG.Visible = false;
            credits.Visible = false;
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currpoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currpoint.X - pos.X, currpoint.Y - pos.Y + bg1.Top);
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            bg1.Top += speed;
            bg2.Top += speed;

            int carSpeed = 6;
            enemy1.Top += carSpeed;
            enemy2.Top += carSpeed;

            coin.Top += speed;

            if (bg1.Top >= 619)
            {
                bg1.Top = 0;
                bg2.Top = -619;
            }

            if (coin.Top >= 850)
            {
                coin.Top = -80;
                Random rand = new Random();
                coin.Left = rand.Next(169, 600);
            }

                if (enemy1.Top >= 800)
            {
                enemy1.Top = -320;
                Random rand = new Random();
                enemy1.Left = rand.Next(169, 400);
            }
            if (enemy2.Top >= 800)
            {
                enemy2.Top = -800;
                Random rand = new Random();
                enemy2.Left = rand.Next(400, 600);
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labellosse.Visible = true;
                restart.Visible = true;
                lose = true;
                coin.Visible = false;
                GG.Visible = true;
                credits.Visible = true;

            }
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                lablecoins.Text = "Монет: " + countCoins.ToString();
                coin.Top = -80;
                Random rand = new Random();
                coin.Left = rand.Next(169, 600);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 12;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 169)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 630)
                player.Left += speed;  
            if (lose) return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -320;
            enemy2.Top = -800;
            labellosse.Visible = false;
            restart.Visible = false;
            timer.Enabled = true;
            countCoins = 0;
            GG.Visible = false;
            coin.Visible = true;
            credits.Visible = false;
            lablecoins.Text = "Монеты: 0";
            coin.Top = -550;
        }
    }
}
