namespace Themaweek7
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
            this.btnverwijder = new System.Windows.Forms.Button();
            this.btnToonGroente = new System.Windows.Forms.Button();
            this.btnToonFruit = new System.Windows.Forms.Button();
            this.btnToonOverige = new System.Windows.Forms.Button();
            this.btnBon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.flpProducten = new System.Windows.Forms.FlowLayoutPanel();
            this.lstbon = new System.Windows.Forms.ListBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnverwijder
            // 
            this.btnverwijder.Location = new System.Drawing.Point(13, 24);
            this.btnverwijder.Name = "btnverwijder";
            this.btnverwijder.Size = new System.Drawing.Size(194, 108);
            this.btnverwijder.TabIndex = 2;
            this.btnverwijder.Text = "Volgende klant";
            this.btnverwijder.UseVisualStyleBackColor = true;
            this.btnverwijder.Click += new System.EventHandler(this.btnverwijder_Click);
            // 
            // btnToonGroente
            // 
            this.btnToonGroente.Location = new System.Drawing.Point(13, 138);
            this.btnToonGroente.Name = "btnToonGroente";
            this.btnToonGroente.Size = new System.Drawing.Size(195, 105);
            this.btnToonGroente.TabIndex = 3;
            this.btnToonGroente.Text = "Groenten";
            this.btnToonGroente.UseVisualStyleBackColor = true;
            this.btnToonGroente.Click += new System.EventHandler(this.btnToonGroente_Click);
            // 
            // btnToonFruit
            // 
            this.btnToonFruit.Location = new System.Drawing.Point(12, 249);
            this.btnToonFruit.Name = "btnToonFruit";
            this.btnToonFruit.Size = new System.Drawing.Size(195, 122);
            this.btnToonFruit.TabIndex = 4;
            this.btnToonFruit.Text = "Fruit";
            this.btnToonFruit.UseVisualStyleBackColor = true;
            this.btnToonFruit.Click += new System.EventHandler(this.btnToonFruit_Click);
            // 
            // btnToonOverige
            // 
            this.btnToonOverige.Location = new System.Drawing.Point(13, 377);
            this.btnToonOverige.Name = "btnToonOverige";
            this.btnToonOverige.Size = new System.Drawing.Size(194, 125);
            this.btnToonOverige.TabIndex = 5;
            this.btnToonOverige.Text = "Overigen";
            this.btnToonOverige.UseVisualStyleBackColor = true;
            this.btnToonOverige.Click += new System.EventHandler(this.btnToonOverige_Click);
            // 
            // btnBon
            // 
            this.btnBon.Location = new System.Drawing.Point(13, 508);
            this.btnBon.Name = "btnBon";
            this.btnBon.Size = new System.Drawing.Size(194, 117);
            this.btnBon.TabIndex = 6;
            this.btnBon.Text = "Bon";
            this.btnBon.UseVisualStyleBackColor = true;
            this.btnBon.Click += new System.EventHandler(this.btnBon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Totaal prijs";
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaalPrijs.Location = new System.Drawing.Point(427, 37);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(0, 24);
            this.lblTotaalPrijs.TabIndex = 9;
            // 
            // flpProducten
            // 
            this.flpProducten.AutoScroll = true;
            this.flpProducten.Location = new System.Drawing.Point(227, 66);
            this.flpProducten.Name = "flpProducten";
            this.flpProducten.Size = new System.Drawing.Size(422, 559);
            this.flpProducten.TabIndex = 10;
            // 
            // lstbon
            // 
            this.lstbon.FormattingEnabled = true;
            this.lstbon.ItemHeight = 16;
            this.lstbon.Location = new System.Drawing.Point(729, 82);
            this.lstbon.Name = "lstbon";
            this.lstbon.Size = new System.Drawing.Size(168, 356);
            this.lstbon.TabIndex = 11;
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(729, 444);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(168, 52);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete product";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(946, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 534);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lstbon);
            this.Controls.Add(this.flpProducten);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBon);
            this.Controls.Add(this.btnToonOverige);
            this.Controls.Add(this.btnToonFruit);
            this.Controls.Add(this.btnToonGroente);
            this.Controls.Add(this.btnverwijder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UCProducten producten1;
        private System.Windows.Forms.Button btnverwijder;
        private System.Windows.Forms.Button btnToonGroente;
        private System.Windows.Forms.Button btnToonFruit;
        private System.Windows.Forms.Button btnToonOverige;
        private System.Windows.Forms.Button btnBon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.FlowLayoutPanel flpProducten;
        private System.Windows.Forms.ListBox lstbon;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
    }
}

