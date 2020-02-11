/// Ian Dill
/// February 10, 2020
/// You press play game and it counts down

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace PlayGame
{
    public partial class AG : Form
    {
        public AG()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            countDown.Text = "Game will start in: 3...";

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.countdownSound);
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            countDown.Text = "Game will start in: 2...";

            SoundPlayer count = new SoundPlayer(Properties.Resources.countdownSound);
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            countDown.Text = "Game will start in: 1...";

            SoundPlayer Down = new SoundPlayer(Properties.Resources.countdownSound);
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            countDown.Text = "GO!";

            BackColor = Color.White;


        }

        private void CountDown_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
