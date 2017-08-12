namespace COMP123_S2017_Assignment5
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashScreenLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.DetailLabel = new System.Windows.Forms.Label();
            this.SplashScreenLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 3000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreenLayoutPanel
            // 
            this.SplashScreenLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreenLayoutPanel.ColumnCount = 1;
            this.SplashScreenLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SplashScreenLayoutPanel.Controls.Add(this.NameLabel, 0, 2);
            this.SplashScreenLayoutPanel.Controls.Add(this.WelcomeLabel, 0, 0);
            this.SplashScreenLayoutPanel.Controls.Add(this.DetailLabel, 0, 1);
            this.SplashScreenLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.SplashScreenLayoutPanel.Name = "SplashScreenLayoutPanel";
            this.SplashScreenLayoutPanel.RowCount = 3;
            this.SplashScreenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.SplashScreenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SplashScreenLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SplashScreenLayoutPanel.Size = new System.Drawing.Size(280, 418);
            this.SplashScreenLayoutPanel.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(21, 384);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(237, 24);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Bradley Sutton - 300280496";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(28, 139);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(224, 55);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // DetailLabel
            // 
            this.DetailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetailLabel.AutoSize = true;
            this.DetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabel.ForeColor = System.Drawing.Color.Black;
            this.DetailLabel.Location = new System.Drawing.Point(44, 342);
            this.DetailLabel.Name = "DetailLabel";
            this.DetailLabel.Size = new System.Drawing.Size(192, 24);
            this.DetailLabel.TabIndex = 1;
            this.DetailLabel.Text = "Assignment 5 - S2017";
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMISplashScreen";
            this.SplashScreenLayoutPanel.ResumeLayout(false);
            this.SplashScreenLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashScreenTimer;
        private System.Windows.Forms.TableLayoutPanel SplashScreenLayoutPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label DetailLabel;
    }
}