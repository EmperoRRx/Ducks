
namespace Zadanie_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Stop = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.LevelOfDifficulty = new System.Windows.Forms.TrackBar();
            this.Start = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerNicknameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevelOfDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.Desktop;
            this.Stop.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(558, 509);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(122, 80);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Visible = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(724, 557);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(68, 22);
            this.ScoreBox.TabIndex = 2;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreBox.Visible = false;
            this.ScoreBox.TextChanged += new System.EventHandler(this.ScoreBox_TextChanged);
            // 
            // LevelOfDifficulty
            // 
            this.LevelOfDifficulty.BackColor = System.Drawing.SystemColors.Desktop;
            this.LevelOfDifficulty.Location = new System.Drawing.Point(31, 533);
            this.LevelOfDifficulty.Maximum = 3;
            this.LevelOfDifficulty.Name = "LevelOfDifficulty";
            this.LevelOfDifficulty.Size = new System.Drawing.Size(222, 56);
            this.LevelOfDifficulty.TabIndex = 4;
            this.LevelOfDifficulty.Visible = false;
            this.LevelOfDifficulty.Scroll += new System.EventHandler(this.LevelOfDifficulty_Scroll);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Desktop;
            this.Start.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(314, 194);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(1);
            this.Start.Size = new System.Drawing.Size(166, 80);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 3000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PlayerNicknameBox
            // 
            this.PlayerNicknameBox.Location = new System.Drawing.Point(314, 347);
            this.PlayerNicknameBox.Name = "PlayerNicknameBox";
            this.PlayerNicknameBox.Size = new System.Drawing.Size(166, 22);
            this.PlayerNicknameBox.TabIndex = 6;
            this.PlayerNicknameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Easy";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Normal";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Very Hard";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hard";
            this.label3.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.ScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(731, 533);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(52, 17);
            this.ScoreLabel.TabIndex = 13;
            this.ScoreLabel.Text = "Score";
            this.ScoreLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(294, 293);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(205, 36);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Enter your nickname:";
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.SystemColors.Desktop;
            this.GameName.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.Location = new System.Drawing.Point(212, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(366, 73);
            this.GameName.TabIndex = 15;
            this.GameName.Text = "DuckShooter2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Zadanie_2.Properties.Resources.Webp_net_compress_image__6_;
            this.ClientSize = new System.Drawing.Size(836, 601);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNicknameBox);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LevelOfDifficulty);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.Stop);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "DuckShooter2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelOfDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.TrackBar LevelOfDifficulty;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.TextBox PlayerNicknameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GameName;
    }
}

