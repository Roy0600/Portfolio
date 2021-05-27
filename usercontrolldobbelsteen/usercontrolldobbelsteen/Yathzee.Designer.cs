namespace usercontrolldobbelsteen
{
    partial class Yathzee
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
            this.btnGooi = new System.Windows.Forms.Button();
            this.ucDobbelsteen1 = new usercontrolldobbelsteen.ucDobbelsteen();
            this.ucDobbelsteen2 = new usercontrolldobbelsteen.ucDobbelsteen();
            this.ucDobbelsteen3 = new usercontrolldobbelsteen.ucDobbelsteen();
            this.ucDobbelsteen4 = new usercontrolldobbelsteen.ucDobbelsteen();
            this.ucDobbelsteen5 = new usercontrolldobbelsteen.ucDobbelsteen();
            this.SuspendLayout();
            // 
            // btnGooi
            // 
            this.btnGooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGooi.Location = new System.Drawing.Point(35, 285);
            this.btnGooi.Name = "btnGooi";
            this.btnGooi.Size = new System.Drawing.Size(898, 107);
            this.btnGooi.TabIndex = 0;
            this.btnGooi.Text = "Gooien";
            this.btnGooi.UseVisualStyleBackColor = true;
            this.btnGooi.Click += new System.EventHandler(this.btnGooi_Click);
            // 
            // ucDobbelsteen1
            // 
            this.ucDobbelsteen1.Location = new System.Drawing.Point(35, 13);
            this.ucDobbelsteen1.Name = "ucDobbelsteen1";
            this.ucDobbelsteen1.Size = new System.Drawing.Size(118, 197);
            this.ucDobbelsteen1.TabIndex = 1;
            // 
            // ucDobbelsteen2
            // 
            this.ucDobbelsteen2.Location = new System.Drawing.Point(203, 13);
            this.ucDobbelsteen2.Name = "ucDobbelsteen2";
            this.ucDobbelsteen2.Size = new System.Drawing.Size(162, 197);
            this.ucDobbelsteen2.TabIndex = 2;
            // 
            // ucDobbelsteen3
            // 
            this.ucDobbelsteen3.Location = new System.Drawing.Point(381, 13);
            this.ucDobbelsteen3.Name = "ucDobbelsteen3";
            this.ucDobbelsteen3.Size = new System.Drawing.Size(162, 197);
            this.ucDobbelsteen3.TabIndex = 3;
            // 
            // ucDobbelsteen4
            // 
            this.ucDobbelsteen4.Location = new System.Drawing.Point(573, 13);
            this.ucDobbelsteen4.Name = "ucDobbelsteen4";
            this.ucDobbelsteen4.Size = new System.Drawing.Size(153, 197);
            this.ucDobbelsteen4.TabIndex = 4;
            // 
            // ucDobbelsteen5
            // 
            this.ucDobbelsteen5.Location = new System.Drawing.Point(790, 13);
            this.ucDobbelsteen5.Name = "ucDobbelsteen5";
            this.ucDobbelsteen5.Size = new System.Drawing.Size(143, 197);
            this.ucDobbelsteen5.TabIndex = 5;
            // 
            // Yathzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 408);
            this.Controls.Add(this.ucDobbelsteen5);
            this.Controls.Add(this.ucDobbelsteen4);
            this.Controls.Add(this.ucDobbelsteen3);
            this.Controls.Add(this.ucDobbelsteen2);
            this.Controls.Add(this.ucDobbelsteen1);
            this.Controls.Add(this.btnGooi);
            this.Name = "Yathzee";
            this.Text = "Yathzee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGooi;
        private ucDobbelsteen ucDobbelsteen1;
        private ucDobbelsteen ucDobbelsteen2;
        private ucDobbelsteen ucDobbelsteen3;
        private ucDobbelsteen ucDobbelsteen4;
        private ucDobbelsteen ucDobbelsteen5;
    }
}

