namespace PuntoDeInformacion
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            this.labelHorarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHorarios
            // 
            this.labelHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHorarios.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarios.Location = new System.Drawing.Point(10, 30);
            this.labelHorarios.Name = "labelHorarios";
            this.labelHorarios.Size = new System.Drawing.Size(802, 2106);
            this.labelHorarios.TabIndex = 0;
            this.labelHorarios.Text = resources.GetString("labelHorarios.Text");
            this.labelHorarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 2225);
            this.Controls.Add(this.labelHorarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Horarios";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Horario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHorarios;
    }
}