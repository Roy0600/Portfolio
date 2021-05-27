namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.picBoxShowPicture = new System.Windows.Forms.PictureBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.ofdShowDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPreviousPicture = new System.Windows.Forms.Button();
            this.btnNextPicture = new System.Windows.Forms.Button();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxShowPicture
            // 
            this.picBoxShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxShowPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxShowPicture.Location = new System.Drawing.Point(0, 62);
            this.picBoxShowPicture.Name = "picBoxShowPicture";
            this.picBoxShowPicture.Size = new System.Drawing.Size(706, 688);
            this.picBoxShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxShowPicture.TabIndex = 0;
            this.picBoxShowPicture.TabStop = false;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectPicture.Location = new System.Drawing.Point(100, 0);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(136, 55);
            this.btnSelectPicture.TabIndex = 1;
            this.btnSelectPicture.Text = "Selecteer foto";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.BtnSelectPicture_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemovePicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemovePicture.Location = new System.Drawing.Point(526, 0);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(136, 55);
            this.btnRemovePicture.TabIndex = 2;
            this.btnRemovePicture.Text = "Verwijder foto";
            this.btnRemovePicture.UseVisualStyleBackColor = false;
            this.btnRemovePicture.Click += new System.EventHandler(this.BtnRemovePicture_Click);
            // 
            // ofdShowDialog
            // 
            this.ofdShowDialog.FileName = "openFileDialog1";
            // 
            // btnPreviousPicture
            // 
            this.btnPreviousPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPreviousPicture.Location = new System.Drawing.Point(242, 0);
            this.btnPreviousPicture.Name = "btnPreviousPicture";
            this.btnPreviousPicture.Size = new System.Drawing.Size(136, 55);
            this.btnPreviousPicture.TabIndex = 3;
            this.btnPreviousPicture.Text = "Vorige foto";
            this.btnPreviousPicture.UseVisualStyleBackColor = true;
            this.btnPreviousPicture.Click += new System.EventHandler(this.BtnPreviousPicture_Click);
            // 
            // btnNextPicture
            // 
            this.btnNextPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNextPicture.Location = new System.Drawing.Point(384, 0);
            this.btnNextPicture.Name = "btnNextPicture";
            this.btnNextPicture.Size = new System.Drawing.Size(136, 55);
            this.btnNextPicture.TabIndex = 4;
            this.btnNextPicture.Text = "Volgende foto ";
            this.btnNextPicture.UseVisualStyleBackColor = true;
            this.btnNextPicture.Click += new System.EventHandler(this.BtnNextPicture_Click);
            // 
            // cbZoom
            // 
            this.cbZoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point(4, 18);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(90, 21);
            this.cbZoom.TabIndex = 5;
            this.cbZoom.Text = "Uitrekken";
            this.cbZoom.UseVisualStyleBackColor = true;
            this.cbZoom.CheckedChanged += new System.EventHandler(this.CbZoom_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.cbZoom);
            this.panel1.Controls.Add(this.btnRemovePicture);
            this.panel1.Controls.Add(this.btnNextPicture);
            this.panel1.Controls.Add(this.btnSelectPicture);
            this.panel1.Controls.Add(this.btnPreviousPicture);
            this.panel1.Location = new System.Drawing.Point(17, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 55);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBoxShowPicture);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(723, 789);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fotoviewer"; 
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxShowPicture;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.OpenFileDialog ofdShowDialog;
        private System.Windows.Forms.Button btnPreviousPicture;
        private System.Windows.Forms.Button btnNextPicture;
        private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

