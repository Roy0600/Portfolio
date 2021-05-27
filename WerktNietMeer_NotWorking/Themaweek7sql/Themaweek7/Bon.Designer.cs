namespace Themaweek7
{
    partial class Bon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bon));
            this.lblProductNaam = new System.Windows.Forms.Label();
            this.pbProductFoto = new System.Windows.Forms.PictureBox();
            this.lblEenheid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductNaam
            // 
            this.lblProductNaam.AutoSize = true;
            this.lblProductNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNaam.Location = new System.Drawing.Point(86, 28);
            this.lblProductNaam.Name = "lblProductNaam";
            this.lblProductNaam.Size = new System.Drawing.Size(102, 25);
            this.lblProductNaam.TabIndex = 0;
            this.lblProductNaam.Text = "kokosnoot";
            // 
            // pbProductFoto
            // 
            this.pbProductFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbProductFoto.Image")));
            this.pbProductFoto.Location = new System.Drawing.Point(0, 0);
            this.pbProductFoto.Name = "pbProductFoto";
            this.pbProductFoto.Size = new System.Drawing.Size(80, 80);
            this.pbProductFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductFoto.TabIndex = 1;
            this.pbProductFoto.TabStop = false;
            // 
            // lblEenheid
            // 
            this.lblEenheid.AutoSize = true;
            this.lblEenheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEenheid.Location = new System.Drawing.Point(185, 28);
            this.lblEenheid.Name = "lblEenheid";
            this.lblEenheid.Size = new System.Drawing.Size(71, 25);
            this.lblEenheid.TabIndex = 2;
            this.lblEenheid.Text = "aantal:";
            // 
            // Bon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEenheid);
            this.Controls.Add(this.pbProductFoto);
            this.Controls.Add(this.lblProductNaam);
            this.Name = "Bon";
            this.Size = new System.Drawing.Size(336, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductNaam;
        private System.Windows.Forms.PictureBox pbProductFoto;
        private System.Windows.Forms.Label lblEenheid;
    }
}
