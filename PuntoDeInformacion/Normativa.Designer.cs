namespace PuntoDeInformacion
{
    partial class Normativa
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
            this.webBrowserNormativa = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserNormativa
            // 
            this.webBrowserNormativa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserNormativa.Location = new System.Drawing.Point(30, 30);
            this.webBrowserNormativa.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNormativa.Name = "webBrowserNormativa";
            this.webBrowserNormativa.Size = new System.Drawing.Size(776, 425);
            this.webBrowserNormativa.TabIndex = 0;
            // 
            // Normativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.webBrowserNormativa);
            this.Name = "Normativa";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.ShowIcon = false;
            this.Text = "Normativa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserNormativa;
    }
}