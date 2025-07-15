namespace SnakeClassic.PL
{
    partial class LevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelForm));
            this.levelGroupBox = new System.Windows.Forms.GroupBox();
            this.levelRadioButton5 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton4 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton3 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton2 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton6 = new System.Windows.Forms.RadioButton();
            this.levelRadioButton1 = new System.Windows.Forms.RadioButton();
            this.levelConfirmButton = new System.Windows.Forms.Button();
            this.levelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // levelGroupBox
            // 
            this.levelGroupBox.Controls.Add(this.levelRadioButton5);
            this.levelGroupBox.Controls.Add(this.levelRadioButton4);
            this.levelGroupBox.Controls.Add(this.levelRadioButton3);
            this.levelGroupBox.Controls.Add(this.levelRadioButton2);
            this.levelGroupBox.Controls.Add(this.levelRadioButton6);
            this.levelGroupBox.Controls.Add(this.levelRadioButton1);
            this.levelGroupBox.Location = new System.Drawing.Point(35, 30);
            this.levelGroupBox.Name = "levelGroupBox";
            this.levelGroupBox.Size = new System.Drawing.Size(180, 280);
            this.levelGroupBox.TabIndex = 0;
            this.levelGroupBox.TabStop = false;
            this.levelGroupBox.Text = "Snake speed";
            // 
            // levelRadioButton5
            // 
            this.levelRadioButton5.AutoSize = true;
            this.levelRadioButton5.Location = new System.Drawing.Point(28, 200);
            this.levelRadioButton5.Name = "levelRadioButton5";
            this.levelRadioButton5.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton5.TabIndex = 5;
            this.levelRadioButton5.TabStop = true;
            this.levelRadioButton5.Text = "Level 5";
            this.levelRadioButton5.UseVisualStyleBackColor = true;
            // 
            // levelRadioButton4
            // 
            this.levelRadioButton4.AutoSize = true;
            this.levelRadioButton4.Location = new System.Drawing.Point(28, 160);
            this.levelRadioButton4.Name = "levelRadioButton4";
            this.levelRadioButton4.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton4.TabIndex = 4;
            this.levelRadioButton4.TabStop = true;
            this.levelRadioButton4.Text = "Level 4";
            this.levelRadioButton4.UseVisualStyleBackColor = true;
            // 
            // levelRadioButton3
            // 
            this.levelRadioButton3.AutoSize = true;
            this.levelRadioButton3.Location = new System.Drawing.Point(28, 120);
            this.levelRadioButton3.Name = "levelRadioButton3";
            this.levelRadioButton3.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton3.TabIndex = 3;
            this.levelRadioButton3.TabStop = true;
            this.levelRadioButton3.Text = "Level 3";
            this.levelRadioButton3.UseVisualStyleBackColor = true;
            // 
            // levelRadioButton2
            // 
            this.levelRadioButton2.AutoSize = true;
            this.levelRadioButton2.Location = new System.Drawing.Point(28, 80);
            this.levelRadioButton2.Name = "levelRadioButton2";
            this.levelRadioButton2.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton2.TabIndex = 2;
            this.levelRadioButton2.TabStop = true;
            this.levelRadioButton2.Text = "Level 2";
            this.levelRadioButton2.UseVisualStyleBackColor = true;
            // 
            // levelRadioButton6
            // 
            this.levelRadioButton6.AutoSize = true;
            this.levelRadioButton6.Location = new System.Drawing.Point(28, 240);
            this.levelRadioButton6.Name = "levelRadioButton6";
            this.levelRadioButton6.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton6.TabIndex = 1;
            this.levelRadioButton6.TabStop = true;
            this.levelRadioButton6.Text = "Level 6";
            this.levelRadioButton6.UseVisualStyleBackColor = true;
            // 
            // levelRadioButton1
            // 
            this.levelRadioButton1.AutoSize = true;
            this.levelRadioButton1.Location = new System.Drawing.Point(28, 40);
            this.levelRadioButton1.Name = "levelRadioButton1";
            this.levelRadioButton1.Size = new System.Drawing.Size(84, 24);
            this.levelRadioButton1.TabIndex = 0;
            this.levelRadioButton1.TabStop = true;
            this.levelRadioButton1.Text = "Level 1";
            this.levelRadioButton1.UseVisualStyleBackColor = true;
            // 
            // levelConfirmButton
            // 
            this.levelConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelConfirmButton.Location = new System.Drawing.Point(35, 325);
            this.levelConfirmButton.Name = "levelConfirmButton";
            this.levelConfirmButton.Size = new System.Drawing.Size(179, 40);
            this.levelConfirmButton.TabIndex = 1;
            this.levelConfirmButton.Text = "Go!";
            this.levelConfirmButton.UseVisualStyleBackColor = true;
            this.levelConfirmButton.Click += new System.EventHandler(this.levelConformButton_Click);
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 394);
            this.Controls.Add(this.levelConfirmButton);
            this.Controls.Add(this.levelGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelForm";
            this.Text = "Choose the level";
            this.levelGroupBox.ResumeLayout(false);
            this.levelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox levelGroupBox;
        private System.Windows.Forms.RadioButton levelRadioButton1;
        private System.Windows.Forms.RadioButton levelRadioButton5;
        private System.Windows.Forms.RadioButton levelRadioButton4;
        private System.Windows.Forms.RadioButton levelRadioButton3;
        private System.Windows.Forms.RadioButton levelRadioButton2;
        private System.Windows.Forms.RadioButton levelRadioButton6;
        private System.Windows.Forms.Button levelConfirmButton;
    }
}