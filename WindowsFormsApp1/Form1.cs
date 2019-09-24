using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
            this.cpuTrack1.Increment(1); //Incriment is in ints of 1-100
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restart");
            
        }
    }
}
