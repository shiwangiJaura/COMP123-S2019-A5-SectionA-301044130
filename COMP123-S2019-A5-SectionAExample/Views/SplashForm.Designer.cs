namespace COMP123_S2019_A5_SectionAExample.Views
{
    partial class SplashForm
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
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Welcomelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcomelabel.Location = new System.Drawing.Point(43, 22);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(273, 25);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome to Dollar computers!";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_S2019_A5_SectionAExample.Properties.Resources.DollarCompyter;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.ControlBox = false;
            this.Controls.Add(this.Welcomelabel);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Timer SplashTimer;
    }
}