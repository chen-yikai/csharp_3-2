using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(box.Location.X == this.Width)
            {
                box.Location = new Point(0,box.Location.Y);
            }
            else
            {
                box.Left += 10;
            }
        }
    }
}
