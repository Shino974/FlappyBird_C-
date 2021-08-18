
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeBot = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(16, 11);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(125, 27);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score ; 0";
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-33, 692);
            this.Ground.Margin = new System.Windows.Forms.Padding(4);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(869, 150);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // PipeBot
            // 
            this.PipeBot.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeBot.Location = new System.Drawing.Point(297, 534);
            this.PipeBot.Margin = new System.Windows.Forms.Padding(4);
            this.PipeBot.Name = "PipeBot";
            this.PipeBot.Size = new System.Drawing.Size(109, 192);
            this.PipeBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot.TabIndex = 2;
            this.PipeBot.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(21, 85);
            this.Bird.Margin = new System.Windows.Forms.Padding(4);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(104, 75);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(568, -16);
            this.PipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(109, 176);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimeEvent);
            // 
            // restartText
            // 
            this.restartText.AutoSize = true;
            this.restartText.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartText.ForeColor = System.Drawing.Color.Red;
            this.restartText.Location = new System.Drawing.Point(260, 336);
            this.restartText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restartText.Name = "restartText";
            this.restartText.Size = new System.Drawing.Size(0, 38);
            this.restartText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(765, 810);
            this.Controls.Add(this.restartText);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBot);
            this.Controls.Add(this.PipeTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Shino\'s FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PipeBot;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label restartText;
    }
}

