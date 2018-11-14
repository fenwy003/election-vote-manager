namespace VotingManager
{
    partial class HomeForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ManualButton = new System.Windows.Forms.Button();
            this.CSVButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WelcomeLabel.Location = new System.Drawing.Point(26, 41);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(390, 24);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome to the Preferential Voting Manager !";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label1.Location = new System.Drawing.Point(75, 219);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(290, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Please choose one of the below options to continue:";
            // 
            // ManualButton
            // 
            this.ManualButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualButton.Location = new System.Drawing.Point(290, 273);
            this.ManualButton.Name = "ManualButton";
            this.ManualButton.Size = new System.Drawing.Size(75, 23);
            this.ManualButton.TabIndex = 5;
            this.ManualButton.Text = "Manual";
            this.ManualButton.UseVisualStyleBackColor = false;
            this.ManualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // CSVButton
            // 
            this.CSVButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSVButton.Location = new System.Drawing.Point(78, 273);
            this.CSVButton.Name = "CSVButton";
            this.CSVButton.Size = new System.Drawing.Size(75, 23);
            this.CSVButton.TabIndex = 4;
            this.CSVButton.Text = "CSV";
            this.CSVButton.UseVisualStyleBackColor = false;
            this.CSVButton.Click += new System.EventHandler(this.CSVButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 365);
            this.Controls.Add(this.ManualButton);
            this.Controls.Add(this.CSVButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferential Voting Manager - Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label WelcomeLabel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ManualButton;
        internal System.Windows.Forms.Button CSVButton;
    }
}

