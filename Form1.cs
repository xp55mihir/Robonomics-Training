using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Xcoor.Clear();
            Ycoor.Clear();
            Xcoor.AppendText(e.X.ToString());
            Ycoor.AppendText(e.Y.ToString());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CBox.AppendText("(" + e.X.ToString() + "," + e.Y.ToString() + ")" + "\r\n");
        }
    }
}
