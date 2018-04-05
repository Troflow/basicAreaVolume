using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14ClassWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r1 = new Rectangle(3.4, 4.5);
            //r1.Length = 3.4;
            //r1.Width = 4.5;
            MessageBox.Show(r1.Area().ToString());

            Box b1 = new Box(5.6, 6.7,8.5);
            //b1.Length = 5.6;
            //b1.Width = 6.7;
            //b1.Height = 8.9;
            int y = 5;
            MessageBox.Show("AREA = " + b1.Area().ToString());
            MessageBox.Show("Volume = " + b1.volume().ToString());
        }
    }
}
