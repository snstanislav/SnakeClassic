namespace SnakeClassic.PL
{
    partial class TutorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorialForm));
            this.tutorialWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tutorialStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // tutorialWebBrowser
            // 
            this.tutorialWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tutorialWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.tutorialWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.tutorialWebBrowser.Name = "tutorialWebBrowser";
            this.tutorialWebBrowser.Size = new System.Drawing.Size(1178, 744);
            this.tutorialWebBrowser.TabIndex = 0;
            // 
            // tutorialStatusStrip
            // 
            this.tutorialStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tutorialStatusStrip.Location = new System.Drawing.Point(0, 722);
            this.tutorialStatusStrip.Name = "tutorialStatusStrip";
            this.tutorialStatusStrip.Size = new System.Drawing.Size(1178, 22);
            this.tutorialStatusStrip.TabIndex = 1;
            this.tutorialStatusStrip.Text = "statusStrip1";
            // 
            // TutorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tutorialStatusStrip);
            this.Controls.Add(this.tutorialWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorialForm";
            this.Text = "Developer Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser tutorialWebBrowser;
        private System.Windows.Forms.StatusStrip tutorialStatusStrip;
    }
}