namespace I_Launcher
{
    partial class Determinant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Determinant));
            this.Determinant_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Determinant_text
            // 
            this.Determinant_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Determinant_text.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Determinant_text.Location = new System.Drawing.Point(50, 27);
            this.Determinant_text.Margin = new System.Windows.Forms.Padding(0);
            this.Determinant_text.Multiline = true;
            this.Determinant_text.Name = "Determinant_text";
            this.Determinant_text.Size = new System.Drawing.Size(540, 2398);
            this.Determinant_text.TabIndex = 3;
            this.Determinant_text.Text = resources.GetString("Determinant_text.Text");
            this.Determinant_text.TextChanged += new System.EventHandler(this.Determinant_text_TextChanged);
            // 
            // Determinant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(640, 356);
            this.Controls.Add(this.Determinant_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Determinant";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1. Determinant";
            this.Load += new System.EventHandler(this.Determinant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Determinant_text;
    }
}