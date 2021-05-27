namespace Themaweek7
{
    partial class UCProducten
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprijs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(0, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(198, 164);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(3, 167);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(85, 25);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Product:";
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(94, 167);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(27, 20);
            this.lblProductNaam.TabIndex = 3;
            this.lblProductNaam.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prijs:";
            // 
            // lblprijs
            // 
            this.lblprijs.AutoSize = true;
            this.lblprijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprijs.Location = new System.Drawing.Point(94, 196);
            this.lblprijs.Name = "lblprijs";
            this.lblprijs.Size = new System.Drawing.Size(27, 20);
            this.lblprijs.TabIndex = 5;
            this.lblprijs.Text = "__";
            // 
            // Producten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblprijs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.pb1);
            this.Name = "Producten";
            this.Size = new System.Drawing.Size(200, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprijs;
    }
}
