namespace CO453Forms
{
    partial class Task2Form
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.computerButton = new System.Windows.Forms.Button();
            this.softwareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.ForeColor = System.Drawing.Color.Black;
            this.QuitButton.Location = new System.Drawing.Point(464, 301);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(56, 27);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.BackColor = System.Drawing.Color.Yellow;
            this.greetingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greetingLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(167, 7);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(213, 30);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Welcome to Supersoft";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pricesLabel
            // 
            this.pricesLabel.AutoSize = true;
            this.pricesLabel.BackColor = System.Drawing.Color.Yellow;
            this.pricesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesLabel.Location = new System.Drawing.Point(167, 37);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(146, 20);
            this.pricesLabel.TabIndex = 2;
            this.pricesLabel.Text = "The BEST Prices!!!";
            this.pricesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // computerButton
            // 
            this.computerButton.ForeColor = System.Drawing.Color.Black;
            this.computerButton.Location = new System.Drawing.Point(243, 289);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(137, 39);
            this.computerButton.TabIndex = 3;
            this.computerButton.Text = "Best Computer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // softwareButton
            // 
            this.softwareButton.ForeColor = System.Drawing.Color.Black;
            this.softwareButton.Location = new System.Drawing.Point(81, 289);
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.Size = new System.Drawing.Size(137, 39);
            this.softwareButton.TabIndex = 4;
            this.softwareButton.Text = "Software";
            this.softwareButton.UseVisualStyleBackColor = true;
            this.softwareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(543, 340);
            this.Controls.Add(this.softwareButton);
            this.Controls.Add(this.computerButton);
            this.Controls.Add(this.pricesLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.QuitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label pricesLabel;
        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button softwareButton;
    }
}

