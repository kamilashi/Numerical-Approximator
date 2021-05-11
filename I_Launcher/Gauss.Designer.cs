namespace I_Launcher
{
    partial class Gauss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gauss));
            this.Gauss_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Gauss_text
            // 
            this.Gauss_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gauss_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gauss_text.Location = new System.Drawing.Point(63, 34);
            this.Gauss_text.Margin = new System.Windows.Forms.Padding(0);
            this.Gauss_text.Multiline = true;
            this.Gauss_text.Name = "Gauss_text";
            this.Gauss_text.Size = new System.Drawing.Size(675, 3435);
            this.Gauss_text.TabIndex = 4;
            this.Gauss_text.Text = resources.GetString("Gauss_text.Text");
            // 
            // Gauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gauss_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Gauss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8.Gauss with Pivoting";
            this.Load += new System.EventHandler(this.Gauss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Gauss_text;
    }
}