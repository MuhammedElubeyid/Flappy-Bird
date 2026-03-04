using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird_V2
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 15;
        int gravity = 5;
        int score = 0;
        bool isGameOver = false;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 

            bird.BackColor = Color.Transparent;
            pipeTop.BackColor = Color.Transparent;
            pipeBottom.BackColor = Color.Transparent;
            scoreText.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -75)
            {
                score++;
                GeneratePipes();
            }

            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top < -25)
            {
                EndGame();
            }
        }

        private void GeneratePipes()
        {
            int randomY = rnd.Next(-150, 50);
            pipeTop.Left = 950;
            pipeTop.Top = randomY;

            pipeBottom.Left = 950;
            pipeBottom.Top = randomY + 380;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isGameOver) gravity = -14; 
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isGameOver) gravity = 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && isGameOver)
            {
                RestartGame();
            }
        }

        private void EndGame()
        {
            isGameOver = true;
            timer1.Stop();
            scoreText.Text = "Score: " + score + " | اضغط R للإعادة";
        }

        private void RestartGame()
        {
            isGameOver = false;
            score = 0;
            gravity = 5;
            bird.Top = 150;

            pipeTop.Top = -100;
            pipeBottom.Top = 280;
            pipeTop.Left = 850;
            pipeBottom.Left = 850;

            scoreText.Text = "Score: 0";
            timer1.Start();
        }

        private void pipeTop_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_Load_1(object sender, EventArgs e) { }
    }
}
