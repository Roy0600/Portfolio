namespace usercontrolldobbelsteen
{
    partial class ucDobbelsteen
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
            this.cbHold = new System.Windows.Forms.CheckBox();
            this.pbDobbelsteen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDobbelsteen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHold
            // 
            this.cbHold.AutoSize = true;
            this.cbHold.Location = new System.Drawing.Point(3, 164);
            this.cbHold.Name = "cbHold";
            this.cbHold.Size = new System.Drawing.Size(99, 21);
            this.cbHold.TabIndex = 4;
            this.cbHold.Text = "vast zetten";
            this.cbHold.UseVisualStyleBackColor = true;
            // 
            // pbDobbelsteen
            // 
            this.pbDobbelsteen.Image = global::usercontrolldobbelsteen.Properties.Resources.img1;
            this.pbDobbelsteen.InitialImage = global::usercontrolldobbelsteen.Properties.Resources.img1;
            this.pbDobbelsteen.Location = new System.Drawing.Point(3, 3);
            this.pbDobbelsteen.Name = "pbDobbelsteen";
            this.pbDobbelsteen.Size = new System.Drawing.Size(151, 155);
            this.pbDobbelsteen.TabIndex = 3;
            this.pbDobbelsteen.TabStop = false;
            // 
            // ucDobbelsteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbHold);
            this.Controls.Add(this.pbDobbelsteen);
            this.Name = "ucDobbelsteen";
            this.Size = new System.Drawing.Size(162, 197);
            this.Load += new System.EventHandler(this.ucDobbelsteen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDobbelsteen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHold;
        private System.Windows.Forms.PictureBox pbDobbelsteen;
    }
}
