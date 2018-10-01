namespace DifficultySettings
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
            this.easyButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(205, 197);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 65);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "EASY";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Visible = false;
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(367, 197);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 65);
            this.hardButton.TabIndex = 1;
            this.hardButton.Text = "HARD";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Visible = false;
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(286, 197);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 65);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "MEDIUM";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(205, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(237, 71);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Welcome!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(207, 152);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(237, 23);
            this.chooseLabel.TabIndex = 4;
            this.chooseLabel.Text = "Please, select your difficulty level";
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(207, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(237, 23);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Please, insert your name below";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(286, 155);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(85, 20);
            this.nameTextbox.TabIndex = 6;
            this.nameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextbox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Set Difficulty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}

