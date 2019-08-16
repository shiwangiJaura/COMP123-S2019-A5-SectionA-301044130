namespace COMP123_S2019_A5_SectionAExample.Views

{
    partial class StartForm
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
            this.orderLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.orderLabel.Location = new System.Drawing.Point(60, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(266, 25);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Order Your Computer Today!";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newOrderButton.Location = new System.Drawing.Point(104, 141);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(167, 23);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "Start A New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitButton.Location = new System.Drawing.Point(104, 199);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SavedOrderButton.Location = new System.Drawing.Point(104, 170);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(167, 23);
            this.SavedOrderButton.TabIndex = 4;
            this.SavedOrderButton.Text = "Open A Saved Order";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 3000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.SavedOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.orderLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to dollars computers!";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Timer StartTimer;
    }
}

