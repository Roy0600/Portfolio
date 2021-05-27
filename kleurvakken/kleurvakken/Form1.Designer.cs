namespace kleurvakken
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
            this.btnKleurAanpassen = new System.Windows.Forms.Button();
            this.klvOne = new kleurvakken.Kleurvlak();
            this.SuspendLayout();
            // 
            // btnKleurAanpassen
            // 
            this.btnKleurAanpassen.Location = new System.Drawing.Point(12, 332);
            this.btnKleurAanpassen.Name = "btnKleurAanpassen";
            this.btnKleurAanpassen.Size = new System.Drawing.Size(182, 23);
            this.btnKleurAanpassen.TabIndex = 1;
            this.btnKleurAanpassen.Text = "Verander Kleur";
            this.btnKleurAanpassen.UseVisualStyleBackColor = true;
            this.btnKleurAanpassen.Click += new System.EventHandler(this.btnKleurAanpassen_Click);
            // 
            // klvOne
            // 
            this.klvOne.BackColor = System.Drawing.Color.Green;
            this.klvOne.Kleur = 0;
            this.klvOne.Location = new System.Drawing.Point(12, 182);
            this.klvOne.Name = "klvOne";
            this.klvOne.Size = new System.Drawing.Size(182, 144);
            this.klvOne.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 372);
            this.Controls.Add(this.btnKleurAanpassen);
            this.Controls.Add(this.klvOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Kleurvlak klvOne;
        private System.Windows.Forms.Button btnKleurAanpassen;
    }
}

