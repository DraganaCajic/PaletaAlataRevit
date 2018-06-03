namespace PaletaAlataRevit
{
    partial class PocetnaForma
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
            this.btnBrojSobe = new System.Windows.Forms.Button();
            this.btnNamjestaj = new System.Windows.Forms.Button();
            this.btnParametri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrojSobe
            // 
            this.btnBrojSobe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrojSobe.Location = new System.Drawing.Point(35, 47);
            this.btnBrojSobe.Name = "btnBrojSobe";
            this.btnBrojSobe.Size = new System.Drawing.Size(249, 23);
            this.btnBrojSobe.TabIndex = 1;
            this.btnBrojSobe.Text = "Dodjela broja sobe";
            this.btnBrojSobe.UseVisualStyleBackColor = true;
            this.btnBrojSobe.Click += new System.EventHandler(this.btnBrojSobe_Click);
            // 
            // btnNamjestaj
            // 
            this.btnNamjestaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNamjestaj.Location = new System.Drawing.Point(35, 103);
            this.btnNamjestaj.Name = "btnNamjestaj";
            this.btnNamjestaj.Size = new System.Drawing.Size(250, 23);
            this.btnNamjestaj.TabIndex = 3;
            this.btnNamjestaj.Text = "Pregled namjestaja";
            this.btnNamjestaj.UseVisualStyleBackColor = true;
            this.btnNamjestaj.Click += new System.EventHandler(this.btnNamjestaj_Click);
            // 
            // btnParametri
            // 
            this.btnParametri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParametri.Location = new System.Drawing.Point(35, 159);
            this.btnParametri.Name = "btnParametri";
            this.btnParametri.Size = new System.Drawing.Size(249, 25);
            this.btnParametri.TabIndex = 5;
            this.btnParametri.Text = "Prikaz parametara elementa";
            this.btnParametri.UseVisualStyleBackColor = true;
            this.btnParametri.Click += new System.EventHandler(this.btnParametri_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 234);
            this.Controls.Add(this.btnParametri);
            this.Controls.Add(this.btnNamjestaj);
            this.Controls.Add(this.btnBrojSobe);
            this.Name = "PocetnaForma";
            this.Text = "PocetnaForma";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBrojSobe;
        private System.Windows.Forms.Button btnNamjestaj;
        private System.Windows.Forms.Button btnParametri;
    }
}