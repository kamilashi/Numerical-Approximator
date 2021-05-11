namespace I_Launcher
{
    partial class ModifiedSecant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifiedSecant));
            this.ModifiedSecant_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifiedSecant_text
            // 
            this.ModifiedSecant_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModifiedSecant_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedSecant_text.Location = new System.Drawing.Point(63, 34);
            this.ModifiedSecant_text.Margin = new System.Windows.Forms.Padding(0);
            this.ModifiedSecant_text.Multiline = true;
            this.ModifiedSecant_text.Name = "ModifiedSecant_text";
            this.ModifiedSecant_text.Size = new System.Drawing.Size(675, 2114);
            this.ModifiedSecant_text.TabIndex = 5;
            this.ModifiedSecant_text.Text = resources.GetString("ModifiedSecant_text.Text");
            // 
            // ModifiedSecant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifiedSecant_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModifiedSecant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11.the Modified Secant Method";
            this.Load += new System.EventHandler(this.ModifiedSecant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModifiedSecant_text;
    }
}