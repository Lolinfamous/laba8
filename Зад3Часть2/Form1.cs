using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зад3Часть2
{
    public partial class Form1 : Form
    {   
        public static System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
            progressBar1.Maximum = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   

          //  progressBar2.Value += 1;
          //  if (progressBar2.Value >= 100) timer.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value >= 10) t.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
