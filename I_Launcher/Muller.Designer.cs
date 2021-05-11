namespace I_Launcher
{
    partial class Muller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muller));
            this.Muller_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Muller_text
            // 
            this.Muller_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Muller_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Muller_text.Location = new System.Drawing.Point(63, 34);
            this.Muller_text.Margin = new System.Windows.Forms.Padding(0);
            this.Muller_text.Multiline = true;
            this.Muller_text.Name = "Muller_text";
            this.Muller_text.Size = new System.Drawing.Size(675, 2691);
            this.Muller_text.TabIndex = 5;
            this.Muller_text.Text = resources.GetString("Muller_text.Text");
            // 
            // Muller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Muller_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Muller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3.Muller";
            this.Load += new System.EventHandler(this.Muller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Muller_text;
    }
}