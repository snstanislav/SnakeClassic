namespace SnakeClassic.PL
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.mainGamePanel = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.gameStatusGoupBox = new System.Windows.Forms.GroupBox();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.levelValueLabel = new System.Windows.Forms.Label();
            this.gameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordLabel = new System.Windows.Forms.Label();
            this.recordValueLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.rightLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.gameStatusGoupBox.SuspendLayout();
            this.gameMenuStrip.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.scoreLabel.Location = new System.Drawing.Point(18, 105);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(73, 30);
            this.scoreLabel.TabIndex = 20;
            this.scoreLabel.Text = "Score:";
            // 
            // mainGamePanel
            // 
            this.mainGamePanel.BackColor = System.Drawing.Color.DarkGray;
            this.mainGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainGamePanel.Location = new System.Drawing.Point(30, 60);
            this.mainGamePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainGamePanel.Name = "mainGamePanel";
            this.mainGamePanel.Size = new System.Drawing.Size(600, 600);
            this.mainGamePanel.TabIndex = 18;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.levelLabel.Location = new System.Drawing.Point(18, 57);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(86, 30);
            this.levelLabel.TabIndex = 22;
            this.levelLabel.Text = "Speed: ";
            // 
            // gameStatusGoupBox
            // 
            this.gameStatusGoupBox.Controls.Add(this.scoreValueLabel);
            this.gameStatusGoupBox.Controls.Add(this.levelLabel);
            this.gameStatusGoupBox.Controls.Add(this.levelValueLabel);
            this.gameStatusGoupBox.Controls.Add(this.scoreLabel);
            this.gameStatusGoupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusGoupBox.Location = new System.Drawing.Point(660, 134);
            this.gameStatusGoupBox.Name = "gameStatusGoupBox";
            this.gameStatusGoupBox.Size = new System.Drawing.Size(192, 167);
            this.gameStatusGoupBox.TabIndex = 24;
            this.gameStatusGoupBox.TabStop = false;
            this.gameStatusGoupBox.Text = "Current game";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.BackColor = System.Drawing.Color.White;
            this.scoreValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.scoreValueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.scoreValueLabel.Location = new System.Drawing.Point(114, 103);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Padding = new System.Windows.Forms.Padding(2);
            this.scoreValueLabel.Size = new System.Drawing.Size(29, 34);
            this.scoreValueLabel.TabIndex = 27;
            this.scoreValueLabel.Text = "0";
            // 
            // levelValueLabel
            // 
            this.levelValueLabel.AutoSize = true;
            this.levelValueLabel.BackColor = System.Drawing.Color.White;
            this.levelValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.levelValueLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.levelValueLabel.Location = new System.Drawing.Point(114, 55);
            this.levelValueLabel.Name = "levelValueLabel";
            this.levelValueLabel.Padding = new System.Windows.Forms.Padding(2);
            this.levelValueLabel.Size = new System.Drawing.Size(29, 34);
            this.levelValueLabel.TabIndex = 26;
            this.levelValueLabel.Text = "  ";
            // 
            // gameMenuStrip
            // 
            this.gameMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gameMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.gameMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.gameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.gameMenuStrip.Name = "gameMenuStrip";
            this.gameMenuStrip.Size = new System.Drawing.Size(898, 41);
            this.gameMenuStrip.TabIndex = 25;
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.clearRecordToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 20, 5);
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(110, 37);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.startToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.startToolStripMenuItem.Size = new System.Drawing.Size(270, 37);
            this.startToolStripMenuItem.Text = "Start new game";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // clearRecordToolStripMenuItem
            // 
            this.clearRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clearRecordToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.clearRecordToolStripMenuItem.Name = "clearRecordToolStripMenuItem";
            this.clearRecordToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.clearRecordToolStripMenuItem.Size = new System.Drawing.Size(270, 37);
            this.clearRecordToolStripMenuItem.Text = "Clear record";
            this.clearRecordToolStripMenuItem.Click += new System.EventHandler(this.clearRecordToolStripMenuItem_Click);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.recordLabel.Location = new System.Drawing.Point(658, 60);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(149, 28);
            this.recordLabel.TabIndex = 26;
            this.recordLabel.Text = "Current record:";
            // 
            // recordValueLabel
            // 
            this.recordValueLabel.AutoSize = true;
            this.recordValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.recordValueLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.recordValueLabel.Location = new System.Drawing.Point(811, 60);
            this.recordValueLabel.Name = "recordValueLabel";
            this.recordValueLabel.Size = new System.Drawing.Size(28, 28);
            this.recordValueLabel.TabIndex = 27;
            this.recordValueLabel.Text = "--";
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pauseLabel.Location = new System.Drawing.Point(30, 675);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Padding = new System.Windows.Forms.Padding(3);
            this.pauseLabel.Size = new System.Drawing.Size(6, 34);
            this.pauseLabel.TabIndex = 28;
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.rightLabel);
            this.controlsGroupBox.Controls.Add(this.downLabel);
            this.controlsGroupBox.Controls.Add(this.upLabel);
            this.controlsGroupBox.Controls.Add(this.leftLabel);
            this.controlsGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.controlsGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.controlsGroupBox.Location = new System.Drawing.Point(660, 466);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(192, 194);
            this.controlsGroupBox.TabIndex = 28;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.rightLabel.Location = new System.Drawing.Point(106, 97);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(74, 28);
            this.rightLabel.TabIndex = 24;
            this.rightLabel.Text = "→ or D";
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.downLabel.Location = new System.Drawing.Point(71, 144);
            this.downLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(63, 28);
            this.downLabel.TabIndex = 23;
            this.downLabel.Text = "↓ or S";
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.upLabel.Location = new System.Drawing.Point(70, 47);
            this.upLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(71, 28);
            this.upLabel.TabIndex = 22;
            this.upLabel.Text = "↑ or W";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.leftLabel.Location = new System.Drawing.Point(20, 97);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(73, 28);
            this.leftLabel.TabIndex = 20;
            this.leftLabel.Text = "← or A";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 744);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.recordValueLabel);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.gameMenuStrip);
            this.Controls.Add(this.gameStatusGoupBox);
            this.Controls.Add(this.mainGamePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 800);
            this.Name = "GameForm";
            this.Text = "Game: Snake Classic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.gameStatusGoupBox.ResumeLayout(false);
            this.gameStatusGoupBox.PerformLayout();
            this.gameMenuStrip.ResumeLayout(false);
            this.gameMenuStrip.PerformLayout();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel mainGamePanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.GroupBox gameStatusGoupBox;
        private System.Windows.Forms.MenuStrip gameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Label levelValueLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label recordValueLabel;
        private System.Windows.Forms.ToolStripMenuItem clearRecordToolStripMenuItem;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.Label leftLabel;
    }
}