using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            gameover();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            golds(gamespeed);
            goldscollection();
        }

        int collectedgold = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }



        void golds(int speed)
        {
            if (gold1.Top >= 300)
            {
                x = r.Next(50, 200);
                gold1.Location = new Point(x, 0);
            }
            else
            {
                gold1.Top += speed;
            }

            if (gold2.Top >= 500)
            {
                x = r.Next(0, 400);
                gold2.Location = new Point(x, 0);
            }
            else
            {
                gold2.Top += speed;
            }

        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
                {
                timer1.Enabled = false;
                over.Visible = true;
                }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if(pictureBox1.Top>=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }


            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;

        }
        int gamespeed = 0;

        void goldscollection()
        {
            if (car.Bounds.IntersectsWith(gold1.Bounds))
            {
                collectedgold++;
                label1.Text = "Golds=" + collectedgold.ToString();
                x = r.Next(0, 200);
                gold1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(gold2.Bounds))
            {
                collectedgold++;
                label1.Text = "Golds=" + collectedgold.ToString();
                x = r.Next(0, 200);
                gold2.Location = new Point(x, 0);
            }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if (car.Right<380)
                car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
                if (e.KeyCode==Keys.Down)
                    if (gamespeed > 0)
                    {
                        gamespeed--;
                    }
        }

       
        private void car_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
