namespace videoteka
{
    partial class Form1
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
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.btnUrednik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(104, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIDEOTEKA";
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnik.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnKorisnik.Location = new System.Drawing.Point(75, 188);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(142, 41);
            this.btnKorisnik.TabIndex = 1;
            this.btnKorisnik.Text = "KORISNIK";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // btnUrednik
            // 
            this.btnUrednik.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrednik.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnUrednik.Location = new System.Drawing.Point(313, 188);
            this.btnUrednik.Name = "btnUrednik";
            this.btnUrednik.Size = new System.Drawing.Size(142, 41);
            this.btnUrednik.TabIndex = 2;
            this.btnUrednik.Text = "UREDNIK";
            this.btnUrednik.UseVisualStyleBackColor = true;
            this.btnUrednik.Click += new System.EventHandler(this.btnUrednik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 573);
            this.Controls.Add(this.btnUrednik);
            this.Controls.Add(this.btnKorisnik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Početna stranica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Button btnUrednik;
    }
}

