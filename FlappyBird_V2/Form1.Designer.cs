namespace FlappyBird_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            bird = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.Transparent;
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(697, -9);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(49, 219);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            pipeTop.Click += pipeTop_Click;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(470, 206);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(52, 249);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-30, 452);
            ground.Name = "ground";
            ground.Size = new Size(1443, 408);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Location = new Point(738, 3);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(50, 20);
            scoreText.TabIndex = 4;
            scoreText.Text = "label1";
            // 
            // bird
            // 
            bird.BackColor = Color.Transparent;
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(54, 135);
            bird.Name = "bird";
            bird.Size = new Size(55, 41);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 8;
            bird.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1403, 835);
            Controls.Add(bird);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private Label scoreText;
        private PictureBox bird;
    }
}
