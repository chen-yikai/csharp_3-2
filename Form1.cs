using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharp_3_2
{
    public partial class Form1 : Form
    {
        private string direction = ""; // 設定並初始化方向值
        public Form1()
        {
            InitializeComponent();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int space = 10; // 設定每次移動的距離
            switch (direction)
            {
                case "up": // 當方向為上時
                    box.Image = imgList.Images[0]; // 更換圖片
                    if (box.Location.Y <  - box.Height) // 當圖片超出上邊界時
                    {
                        box.Location = new Point(box.Location.X, this.Height); // 將圖片移至下邊界
                    }
                    else
                    {
                        box.Top -= space; // 否則向上移動
                    }
                    break;
                case "down":
                    box.Image = imgList.Images[1]; // 更換圖片
                    if (box.Location.Y > this.Height) // 當圖片超出下邊界時
                    {
                        box.Location = new Point(box.Location.X, 0 - box.Height); // 將圖片移至上邊界
                    }
                    else
                    {
                        box.Top += space; // 否則向下移動
                    }
                    break;
                case "left":
                    box.Image = imgList.Images[2]; // 更換圖片
                    if (box.Location.X + box.Width < 0) // 當圖片超出左邊界時
                    {
                        box.Location = new Point(this.Width, box.Location.Y); // 將圖片移至右邊界
                    }
                    else
                    {
                        box.Left -= space; // 否則向左移動
                    }
                    break;
                case "right":
                    box.Image = imgList.Images[3]; // 更換圖片
                    if (box.Location.X > this.Width)  // 當圖片超出右邊界時
                    {
                        box.Location = new Point(0 - box.Width, box.Location.Y); // 將圖片移至左邊界
                    }
                    else
                    {
                        box.Left += space; // 否則向右移動
                    }
                    break;
            }

        }

        private void up_Click(object sender, EventArgs e) // 當按下上按鈕時
        {
            direction = "up"; // 設定方向為上
            timer.Start(); // 啟動計時器
        }

        private void left_Click(object sender, EventArgs e) // 當按下左按鈕時
        {
            direction = "left"; // 設定方向為左
            timer.Start(); // 啟動計時器
        }

        private void down_Click(object sender, EventArgs e) // 當按下下按鈕時
        {
            direction = "down"; // 設定方向為下
            timer.Start(); // 啟動計時器
        }

        private void right_Click(object sender, EventArgs e) // 當按下右按鈕時
        {
            direction = "right"; // 設定方向為右
            timer.Start(); // 啟動計時器
        }

        private void pause_Click(object sender, EventArgs e) // 當按下暫停按鈕時
        {
            timer.Stop(); // 暫停計時器
        }

        private void speedTracke_Scroll(object sender, EventArgs e) // 當滑動速度軌道時
        {
            timer.Interval = speedTracke.Value; // 設定計時器間隔為速度軌道的值
        }

        private void verticalS_Scroll(object sender, ScrollEventArgs e) // 當滑動垂直軌道時
        {
            box.Height = verticalS.Value; // 設定圖片高度為垂直軌道的值
        }

        private void horizontalS_Scroll(object sender, ScrollEventArgs e) // 當滑動水平軌道時
        {
            box.Width = horizontalS.Value; // 設定圖片寬度為水平軌道的值
        }
    }
}
