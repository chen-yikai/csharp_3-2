using System;
using System.Drawing;
using System.Windows.Forms;

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
                    if (box.Location.Y < 0 - box.Height)
                    {
                        box.Location = new Point(box.Location.X, this.Height);
                    }
                    else
                    {
                        box.Top -= space;
                    }
                    break;
                case "down":
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
    }
}
