using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlappyBird
{
    public partial class Form1 : Form
    {
        // 1. المتغيرات الأساسية
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        bool isGameOver = false; // هذا هو المتغير الذي كان ينقصك!

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreLabel.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            isGameOver = true;
            scoreLabel.Text = "Score: " + score + " - Game Over!!! Press R to Restart";
            scoreLabel.BringToFront();
        }

        private void restartGame()
        {
            isGameOver = false;
            flappyBird.Top = 100;
            pipeBottom.Left = 800;
            pipeTop.Left = 950;
            score = 0;
            gravity = 10;
            scoreLabel.Text = "Score: 0";
            gameTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // القفز بالمسافة
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

            // 2. إضافة شرط زر الـ R للإعادة
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                restartGame();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void flappyBird_Click(object sender, EventArgs e) { }
        private void ground_Click(object sender, EventArgs e) { }
    }
}