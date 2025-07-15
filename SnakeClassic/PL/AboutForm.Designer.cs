namespace SnakeClassic.PL
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.aboutLabel.ForeColor = System.Drawing.Color.Green;
            this.aboutLabel.Location = new System.Drawing.Point(29, 28);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(240, 32);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "GAME: Snake Classik";
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.aboutTextBox.Location = new System.Drawing.Point(35, 91);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(508, 146);
            this.aboutTextBox.TabIndex = 1;
            this.aboutTextBox.TabStop = false;
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aboutLinkLabel.Location = new System.Drawing.Point(30, 276);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(278, 28);
            this.aboutLinkLabel.TabIndex = 2;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "https://github.com/snstanislav";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // aboutOkButton
            // 
            this.aboutOkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.aboutOkButton.Location = new System.Drawing.Point(443, 276);
            this.aboutOkButton.Name = "aboutOkButton";
            this.aboutOkButton.Size = new System.Drawing.Size(100, 37);
            this.aboutOkButton.TabIndex = 3;
            this.aboutOkButton.Text = "OK";
            this.aboutOkButton.UseVisualStyleBackColor = true;
            this.aboutOkButton.Click += new System.EventHandler(this.aboutOkButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.aboutOkButton);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.aboutLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "AboutForm";
            this.Text = "About application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;
        private System.Windows.Forms.Button aboutOkButton;
    }
}