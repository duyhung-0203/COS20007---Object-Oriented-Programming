namespace DCustomProgram
{
    partial class flappybirdgamehehef
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
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            flappyBird = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown2;
            pipeTop.Location = new Point(910, 0);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(106, 210);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe1;
            pipeBottom.Location = new Point(705, 362);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(106, 273);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground2;
            ground.Location = new Point(-44, 641);
            ground.Name = "ground";
            ground.Size = new Size(1145, 96);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Lucida Fax", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            scoreText.Location = new Point(12, 20);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(279, 71);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird2;
            flappyBird.Location = new Point(190, 219);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(85, 64);
            flappyBird.TabIndex = 5;
            flappyBird.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimeEvent;
            // 
            // flappybirdgamehehef
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(1075, 729);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "flappybirdgamehehef";
            Text = "Flappy Brid Game for C#";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private PictureBox flappyBird;
        private System.Windows.Forms.Timer gameTimer;
    }
}