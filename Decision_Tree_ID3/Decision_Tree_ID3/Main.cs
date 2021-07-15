using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Decision_Tree_ID3
{
    public partial class Main : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Main()
        {
            InitializeComponent();
         
            player.URL = "C:\\Users\\Administrator\\Desktop\\Decision_Tree_ID3\\Decision_Tree_ID3\\music\\piano.mp3";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            {
                player.controls.play();
            }
            {
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 1000;
                progressBar1.Maximum = 7;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value != 7)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                frmHome add = new frmHome();
                add.Show();
                Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
