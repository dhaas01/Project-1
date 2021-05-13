namespace Project_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.CPUPaperPictureBox = new System.Windows.Forms.PictureBox();
            this.YourChoice = new System.Windows.Forms.Label();
            this.yourPaperPictureBox = new System.Windows.Forms.PictureBox();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.CPUsChoice = new System.Windows.Forms.Label();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.CPUScoreLabel = new System.Windows.Forms.Label();
            this.drawCountLabel = new System.Windows.Forms.Label();
            this.yourScissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.yourRockPictureBox = new System.Windows.Forms.PictureBox();
            this.CPUScissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.CPURockPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CPUPaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourPaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourScissorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourRockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUScissorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPURockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CPUPaperPictureBox
            // 
            this.CPUPaperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CPUPaperPictureBox.Image")));
            this.CPUPaperPictureBox.Location = new System.Drawing.Point(284, 81);
            this.CPUPaperPictureBox.Name = "CPUPaperPictureBox";
            this.CPUPaperPictureBox.Size = new System.Drawing.Size(106, 105);
            this.CPUPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUPaperPictureBox.TabIndex = 1;
            this.CPUPaperPictureBox.TabStop = false;
            this.CPUPaperPictureBox.Visible = false;
            // 
            // YourChoice
            // 
            this.YourChoice.AutoSize = true;
            this.YourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourChoice.Location = new System.Drawing.Point(150, 38);
            this.YourChoice.Name = "YourChoice";
            this.YourChoice.Size = new System.Drawing.Size(35, 16);
            this.YourChoice.TabIndex = 2;
            this.YourChoice.Text = "You";
            // 
            // yourPaperPictureBox
            // 
            this.yourPaperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("yourPaperPictureBox.Image")));
            this.yourPaperPictureBox.Location = new System.Drawing.Point(123, 81);
            this.yourPaperPictureBox.Name = "yourPaperPictureBox";
            this.yourPaperPictureBox.Size = new System.Drawing.Size(109, 105);
            this.yourPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yourPaperPictureBox.TabIndex = 3;
            this.yourPaperPictureBox.TabStop = false;
            this.yourPaperPictureBox.Visible = false;
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(34, 105);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(58, 23);
            this.rockButton.TabIndex = 4;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(34, 134);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(58, 23);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(34, 163);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(58, 23);
            this.scissorsButton.TabIndex = 6;
            this.scissorsButton.Text = "Scissors ";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // CPUsChoice
            // 
            this.CPUsChoice.AutoSize = true;
            this.CPUsChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUsChoice.Location = new System.Drawing.Point(318, 38);
            this.CPUsChoice.Name = "CPUsChoice";
            this.CPUsChoice.Size = new System.Drawing.Size(39, 16);
            this.CPUsChoice.TabIndex = 7;
            this.CPUsChoice.Text = "CPU";
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yourScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.yourScoreLabel.Location = new System.Drawing.Point(12, 20);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(132, 41);
            this.yourScoreLabel.TabIndex = 11;
            this.yourScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUScoreLabel
            // 
            this.CPUScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.CPUScoreLabel.Location = new System.Drawing.Point(363, 20);
            this.CPUScoreLabel.Name = "CPUScoreLabel";
            this.CPUScoreLabel.Size = new System.Drawing.Size(125, 41);
            this.CPUScoreLabel.TabIndex = 12;
            this.CPUScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawCountLabel
            // 
            this.drawCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.drawCountLabel.Location = new System.Drawing.Point(321, 205);
            this.drawCountLabel.Name = "drawCountLabel";
            this.drawCountLabel.Size = new System.Drawing.Size(178, 67);
            this.drawCountLabel.TabIndex = 13;
            this.drawCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourScissorsPictureBox
            // 
            this.yourScissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("yourScissorsPictureBox.Image")));
            this.yourScissorsPictureBox.Location = new System.Drawing.Point(123, 81);
            this.yourScissorsPictureBox.Name = "yourScissorsPictureBox";
            this.yourScissorsPictureBox.Size = new System.Drawing.Size(109, 105);
            this.yourScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yourScissorsPictureBox.TabIndex = 14;
            this.yourScissorsPictureBox.TabStop = false;
            this.yourScissorsPictureBox.Visible = false;
            // 
            // yourRockPictureBox
            // 
            this.yourRockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("yourRockPictureBox.Image")));
            this.yourRockPictureBox.Location = new System.Drawing.Point(123, 81);
            this.yourRockPictureBox.Name = "yourRockPictureBox";
            this.yourRockPictureBox.Size = new System.Drawing.Size(109, 105);
            this.yourRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yourRockPictureBox.TabIndex = 15;
            this.yourRockPictureBox.TabStop = false;
            this.yourRockPictureBox.Visible = false;
            // 
            // CPUScissorsPictureBox
            // 
            this.CPUScissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CPUScissorsPictureBox.Image")));
            this.CPUScissorsPictureBox.Location = new System.Drawing.Point(284, 81);
            this.CPUScissorsPictureBox.Name = "CPUScissorsPictureBox";
            this.CPUScissorsPictureBox.Size = new System.Drawing.Size(106, 105);
            this.CPUScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPUScissorsPictureBox.TabIndex = 16;
            this.CPUScissorsPictureBox.TabStop = false;
            this.CPUScissorsPictureBox.Visible = false;
            // 
            // CPURockPictureBox
            // 
            this.CPURockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CPURockPictureBox.Image")));
            this.CPURockPictureBox.Location = new System.Drawing.Point(284, 81);
            this.CPURockPictureBox.Name = "CPURockPictureBox";
            this.CPURockPictureBox.Size = new System.Drawing.Size(109, 105);
            this.CPURockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPURockPictureBox.TabIndex = 17;
            this.CPURockPictureBox.TabStop = false;
            this.CPURockPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 299);
            this.Controls.Add(this.CPURockPictureBox);
            this.Controls.Add(this.CPUScissorsPictureBox);
            this.Controls.Add(this.yourRockPictureBox);
            this.Controls.Add(this.yourScissorsPictureBox);
            this.Controls.Add(this.drawCountLabel);
            this.Controls.Add(this.CPUScoreLabel);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.CPUsChoice);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.yourPaperPictureBox);
            this.Controls.Add(this.YourChoice);
            this.Controls.Add(this.CPUPaperPictureBox);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPUPaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourPaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourScissorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourRockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUScissorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPURockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox CPUPaperPictureBox;
        private System.Windows.Forms.Label YourChoice;
        private System.Windows.Forms.PictureBox yourPaperPictureBox;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label CPUsChoice;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label CPUScoreLabel;
        private System.Windows.Forms.Label drawCountLabel;
        private System.Windows.Forms.PictureBox yourScissorsPictureBox;
        private System.Windows.Forms.PictureBox yourRockPictureBox;
        private System.Windows.Forms.PictureBox CPUScissorsPictureBox;
        private System.Windows.Forms.PictureBox CPURockPictureBox;
    }
}

