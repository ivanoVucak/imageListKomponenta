namespace imageListKomponenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slika1Pb = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.promijeniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika1Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // slika1Pb
            // 
            this.slika1Pb.Location = new System.Drawing.Point(12, 12);
            this.slika1Pb.Name = "slika1Pb";
            this.slika1Pb.Size = new System.Drawing.Size(363, 260);
            this.slika1Pb.TabIndex = 0;
            this.slika1Pb.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "preuzmi (1).jpg");
            this.imageList1.Images.SetKeyName(1, "images.jpg");
            // 
            // promijeniBtn
            // 
            this.promijeniBtn.Location = new System.Drawing.Point(29, 306);
            this.promijeniBtn.Name = "promijeniBtn";
            this.promijeniBtn.Size = new System.Drawing.Size(120, 23);
            this.promijeniBtn.TabIndex = 1;
            this.promijeniBtn.Text = "Promijeni sliku";
            this.promijeniBtn.UseVisualStyleBackColor = true;
            this.promijeniBtn.Click += new System.EventHandler(this.promijeniBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.promijeniBtn);
            this.Controls.Add(this.slika1Pb);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.slika1Pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slika1Pb;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button promijeniBtn;
    }
}

