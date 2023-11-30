namespace PuntoDeInformacion
{
    partial class Estudios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudios));
            this.panelEstudioBio = new System.Windows.Forms.Panel();
            this.labelTestimonio3 = new System.Windows.Forms.Label();
            this.labelTestimonio2 = new System.Windows.Forms.Label();
            this.labelTestimonio1 = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.comboBoxEstudios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEstudioBio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEstudioBio
            // 
            this.panelEstudioBio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEstudioBio.Controls.Add(this.labelTestimonio3);
            this.panelEstudioBio.Controls.Add(this.labelTestimonio2);
            this.panelEstudioBio.Controls.Add(this.labelTestimonio1);
            this.panelEstudioBio.Controls.Add(this.richTextBoxInfo);
            this.panelEstudioBio.Location = new System.Drawing.Point(12, 132);
            this.panelEstudioBio.Name = "panelEstudioBio";
            this.panelEstudioBio.Size = new System.Drawing.Size(812, 392);
            this.panelEstudioBio.TabIndex = 3;
            // 
            // labelTestimonio3
            // 
            this.labelTestimonio3.AutoSize = true;
            this.labelTestimonio3.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelTestimonio3.Location = new System.Drawing.Point(68, 177);
            this.labelTestimonio3.Name = "labelTestimonio3";
            this.labelTestimonio3.Size = new System.Drawing.Size(97, 22);
            this.labelTestimonio3.TabIndex = 9;
            this.labelTestimonio3.Text = "Testimonio3";
            // 
            // labelTestimonio2
            // 
            this.labelTestimonio2.AutoSize = true;
            this.labelTestimonio2.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelTestimonio2.Location = new System.Drawing.Point(68, 115);
            this.labelTestimonio2.Name = "labelTestimonio2";
            this.labelTestimonio2.Size = new System.Drawing.Size(97, 22);
            this.labelTestimonio2.TabIndex = 7;
            this.labelTestimonio2.Text = "Testimonio2";
            // 
            // labelTestimonio1
            // 
            this.labelTestimonio1.AutoSize = true;
            this.labelTestimonio1.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelTestimonio1.Location = new System.Drawing.Point(68, 53);
            this.labelTestimonio1.Name = "labelTestimonio1";
            this.labelTestimonio1.Size = new System.Drawing.Size(93, 22);
            this.labelTestimonio1.TabIndex = 6;
            this.labelTestimonio1.Text = "Testimonio1";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Dosis", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(812, 392);
            this.richTextBoxInfo.TabIndex = 3;
            this.richTextBoxInfo.Text = "";
            // 
            // comboBoxEstudios
            // 
            this.comboBoxEstudios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstudios.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxEstudios.FormattingEnabled = true;
            this.comboBoxEstudios.Location = new System.Drawing.Point(187, 66);
            this.comboBoxEstudios.Name = "comboBoxEstudios";
            this.comboBoxEstudios.Size = new System.Drawing.Size(458, 30);
            this.comboBoxEstudios.TabIndex = 2;
            this.comboBoxEstudios.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstudios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione de la lista alguno de los estudios disponibles para conocer más inform" +
    "ación:";
            // 
            // Estudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEstudios);
            this.Controls.Add(this.panelEstudioBio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estudios";
            this.Text = "Estudios";
            this.panelEstudioBio.ResumeLayout(false);
            this.panelEstudioBio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelEstudioBio;
        private System.Windows.Forms.ComboBox comboBoxEstudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label labelTestimonio1;
        private System.Windows.Forms.Label labelTestimonio3;
        private System.Windows.Forms.Label labelTestimonio2;
    }
}