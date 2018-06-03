namespace PaletaAlataRevit
{
    partial class Parametri
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
            this.clbParametri = new System.Windows.Forms.CheckedListBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbParametri
            // 
            this.clbParametri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbParametri.FormattingEnabled = true;
            this.clbParametri.Location = new System.Drawing.Point(12, 34);
            this.clbParametri.Name = "clbParametri";
            this.clbParametri.Size = new System.Drawing.Size(407, 259);
            this.clbParametri.TabIndex = 0;
            this.clbParametri.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbParametri_ItemCheck_1);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(12, 9);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(95, 13);
            this.lblBroj.TabIndex = 1;
            this.lblBroj.Text = "Broj parametara je:";
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Location = new System.Drawing.Point(423, 59);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(167, 20);
            this.tb.TabIndex = 2;
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(423, 34);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(167, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "Vrijednost cekiranog parametra je:";
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPromijeni.Location = new System.Drawing.Point(428, 110);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 4;
            this.btnPromijeni.Text = "OK";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // Parametri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 318);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.clbParametri);
            this.Name = "Parametri";
            this.Text = "Parametri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbParametri;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnPromijeni;
    }
}