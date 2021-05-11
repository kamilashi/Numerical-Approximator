namespace I_Launcher
{
    partial class Bisection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bisection));
            this.Bisection_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bisection_text
            // 
            this.Bisection_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bisection_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bisection_text.Location = new System.Drawing.Point(63, 34);
            this.Bisection_text.Margin = new System.Windows.Forms.Padding(0);
            this.Bisection_text.Multiline = true;
            this.Bisection_text.Name = "Bisection_text";
            this.Bisection_text.Size = new System.Drawing.Size(675, 2249);
            this.Bisection_text.TabIndex = 6;
            this.Bisection_text.Text = resources.GetString("Bisection_text.Text");
            // 
            // Bisection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bisection_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bisection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4. the Bisection method";
            this.Load += new System.EventHandler(this.Bisection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bisection_text;
    }
}