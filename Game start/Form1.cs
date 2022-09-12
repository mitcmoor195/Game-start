using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Game_start
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(Properties.Resources.beep);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.scifi_warning_beep);
        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            Refresh(); 
            
            player.Play();
            timerSeconds.Text = "3..." ;
            Refresh();
            Thread.Sleep(1000);

            player.Play();
            timerSeconds.Text = "2...";
            Refresh();
            Thread.Sleep(1000);

            player.Play();
            timerSeconds.Text = "1...";
            Refresh();
            Thread.Sleep(1000);

            player2.Play();
            timerSeconds.Text = "Begin!";
            this.BackColor = Color.Purple;
        }
    }
}
