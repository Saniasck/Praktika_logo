using System;
using System.Media;
using System.Windows.Forms;

namespace П_ПРактика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
            SoundPlayer player = new SoundPlayer("Экси - Мешаю_02.wav");
            player.Play();
            timer1.Interval = 170; 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            this.timer1.Start();
        }
        public static int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 8)
            {
                Hide();
                Form1 newfrm = new Form1();
                newfrm.ShowDialog();
                Close();
                this.timer1.Stop();
            }
        }
    }
}
