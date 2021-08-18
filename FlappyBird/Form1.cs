using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 15;
        int score = 0;
        int speed = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimeEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeBot.Left -= pipespeed;
            PipeTop.Left -= pipespeed;
            Score.Text = "Score: " + score.ToString();

            if (PipeBot.Left < -60)
            {
                PipeBot.Left = 624;
                score++;
            }
            if (PipeTop.Left < -60)
            {
                PipeTop.Left = 626;
                score++;
            }
            if (Bird.Bounds.IntersectsWith(PipeBot.Bounds) || Bird.Bounds.IntersectsWith(PipeTop.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -25) 
            { 
                endGame();
            }
            if (score > speed * 2) 
            {
                pipespeed = pipespeed * 3 / 2;
                speed *= 2;       
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void restartGame()
        {
            GameTimer.Start();
            pipespeed = 8;
            gravity = 15;
            score = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            GameTimer.Stop();
            Score.Text += "  Game over !!!";
        }
    }
}
