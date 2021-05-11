namespace I_Launcher
{
    partial class FalseP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FalseP));
            this.FalseP_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FalseP_text
            // 
            this.FalseP_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FalseP_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FalseP_text.Location = new System.Drawing.Point(63, 34);
            this.FalseP_text.Margin = new System.Windows.Forms.Padding(0);
            this.FalseP_text.Multiline = true;
            this.FalseP_text.Name = "FalseP_text";
            this.FalseP_text.Size = new System.Drawing.Size(675, 2214);
            this.FalseP_text.TabIndex = 4;
            this.FalseP_text.Text = resources.GetString("FalseP_text.Text");
            // 
            // FalseP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FalseP_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FalseP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5.the False Position method";
            this.Load += new System.EventHandler(this.FalseP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FalseP_text;
    }
}