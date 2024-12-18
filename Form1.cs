using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharp_3_2
{
    public partial class Form1 : Form
    {
        private string direction = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int space = 10;
            switch (direction)
            {
                case "up":
                    box.Image = imgList.Images[0];
                    if (box.Location.Y <  - box.Height)
                    {
                        box.Location = new Point(box.Location.X, this.Height);
                    }
                    else
                    {
                        box.Top -= space;
                    }
                    break;
                case "down":
                    box.Image = imgList.Images[1];
                    if (box.Location.Y > this.Height)
                    {
                        box.Location = new Point(box.Location.X, 0 - box.Height);
                    }
                    else
                    {
                        box.Top += space;
                    }
                    break;
                case "left":
                    box.Image = imgList.Images[2];
                    if (box.Location.X + box.Width < 0)
                    {
                        box.Location = new Point(this.Width, box.Location.Y);
                    }
                    else
                    {
                        box.Left -= space;
                    }
                    break;
                case "right":
                    box.Image = imgList.Images[3];
                    if (box.Location.X > this.Width)
                    {
                        box.Location = new Point(0 - box.Width, box.Location.Y);
                    }
                    else
                    {
                        box.Left += space;
                    }
                    break;
            }

        }

        private void up_Click(object sender, EventArgs e)
        {
            direction = "up";
            timer.Start();
        }

        private void left_Click(object sender, EventArgs e)
        {
            direction = "left";
            timer.Start();
        }

        private void down_Click(object sender, EventArgs e)
        {
            direction = "down";
            timer.Start();
        }

        private void right_Click(object sender, EventArgs e)
        {
            direction = "right";
            timer.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void speedTracke_Scroll(object sender, EventArgs e)
        {
            timer.Interval = speedTracke.Value;
            //speedTracke.Value;
        }

        private void verticalS_Scroll(object sender, ScrollEventArgs e)
        {
            box.Height = verticalS.Value;
        }

        private void horizontalS_Scroll(object sender, ScrollEventArgs e)
        {
            box.Width = horizontalS.Value;
        }
    }
}
