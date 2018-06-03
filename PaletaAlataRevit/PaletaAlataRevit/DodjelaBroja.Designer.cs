namespace PaletaAlataRevit
{
    partial class DodjelaBroja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPocetniBoj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAutomatski = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite pocetni broj sobe";
            // 
            // txtPocetniBoj
            // 
            this.txtPocetniBoj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPocetniBoj.Location = new System.Drawing.Point(60, 49);
            this.txtPocetniBoj.Name = "txtPocetniBoj";
            this.txtPocetniBoj.Size = new System.Drawing.Size(145, 20);
            this.txtPocetniBoj.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(213, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutomatski
            // 
            this.btnAutomatski.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutomatski.Location = new System.Drawing.Point(60, 100);
            this.btnAutomatski.Name = "btnAutomatski";
            this.btnAutomatski.Size = new System.Drawing.Size(228, 23);
            this.btnAutomatski.TabIndex = 3;
            this.btnAutomatski.Text = "Automatska dodjela brojeva";
            this.btnAutomatski.UseVisualStyleBackColor = true;
            this.btnAutomatski.Click += new System.EventHandler(this.btnAutomatski_Click);
            // 
            // DodjelaBroja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 179);
            this.Controls.Add(this.btnAutomatski);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPocetniBoj);
            this.Controls.Add(this.label1);
            this.Name = "DodjelaBroja";
            this.Text = "DodjelaBroja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodjelaBroja_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPocetniBoj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAutomatski;
    }
}