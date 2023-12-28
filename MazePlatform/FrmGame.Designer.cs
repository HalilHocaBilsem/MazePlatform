namespace MazePlatform
{
    partial class FrmGame
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
            this.pCizimAlani = new System.Windows.Forms.PictureBox();
            this.btnKalem = new System.Windows.Forms.Button();
            this.btnDaire = new System.Windows.Forms.Button();
            this.btnDortgen = new System.Windows.Forms.Button();
            this.tRed = new System.Windows.Forms.TrackBar();
            this.tBlue = new System.Windows.Forms.TrackBar();
            this.tGreen = new System.Windows.Forms.TrackBar();
            this.pSeciliRenk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCizimAlani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSeciliRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // pCizimAlani
            // 
            this.pCizimAlani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCizimAlani.BackColor = System.Drawing.Color.White;
            this.pCizimAlani.Location = new System.Drawing.Point(32, 157);
            this.pCizimAlani.Name = "pCizimAlani";
            this.pCizimAlani.Size = new System.Drawing.Size(1246, 389);
            this.pCizimAlani.TabIndex = 0;
            this.pCizimAlani.TabStop = false;
            // 
            // btnKalem
            // 
            this.btnKalem.Location = new System.Drawing.Point(712, 29);
            this.btnKalem.Name = "btnKalem";
            this.btnKalem.Size = new System.Drawing.Size(114, 59);
            this.btnKalem.TabIndex = 1;
            this.btnKalem.Text = "Kalem";
            this.btnKalem.UseVisualStyleBackColor = true;
            // 
            // btnDaire
            // 
            this.btnDaire.Location = new System.Drawing.Point(840, 29);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(83, 53);
            this.btnDaire.TabIndex = 5;
            this.btnDaire.Text = "Daire";
            this.btnDaire.UseVisualStyleBackColor = true;
            // 
            // btnDortgen
            // 
            this.btnDortgen.Location = new System.Drawing.Point(929, 29);
            this.btnDortgen.Name = "btnDortgen";
            this.btnDortgen.Size = new System.Drawing.Size(83, 53);
            this.btnDortgen.TabIndex = 6;
            this.btnDortgen.Text = "Dörtgen";
            this.btnDortgen.UseVisualStyleBackColor = true;
            // 
            // tRed
            // 
            this.tRed.AutoSize = false;
            this.tRed.Location = new System.Drawing.Point(32, 12);
            this.tRed.Maximum = 255;
            this.tRed.Name = "tRed";
            this.tRed.Size = new System.Drawing.Size(200, 24);
            this.tRed.TabIndex = 7;
            this.tRed.ValueChanged += new System.EventHandler(this.tGreen_ValueChanged);
            // 
            // tBlue
            // 
            this.tBlue.AutoSize = false;
            this.tBlue.Location = new System.Drawing.Point(32, 74);
            this.tBlue.Maximum = 255;
            this.tBlue.Name = "tBlue";
            this.tBlue.Size = new System.Drawing.Size(200, 25);
            this.tBlue.TabIndex = 8;
            this.tBlue.ValueChanged += new System.EventHandler(this.tGreen_ValueChanged);
            // 
            // tGreen
            // 
            this.tGreen.AutoSize = false;
            this.tGreen.Location = new System.Drawing.Point(32, 41);
            this.tGreen.Maximum = 255;
            this.tGreen.Name = "tGreen";
            this.tGreen.Size = new System.Drawing.Size(200, 26);
            this.tGreen.TabIndex = 9;
            this.tGreen.ValueChanged += new System.EventHandler(this.tGreen_ValueChanged);
            // 
            // pSeciliRenk
            // 
            this.pSeciliRenk.BackColor = System.Drawing.Color.Black;
            this.pSeciliRenk.Location = new System.Drawing.Point(244, 16);
            this.pSeciliRenk.Name = "pSeciliRenk";
            this.pSeciliRenk.Size = new System.Drawing.Size(89, 83);
            this.pSeciliRenk.TabIndex = 10;
            this.pSeciliRenk.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 568);
            this.Controls.Add(this.pSeciliRenk);
            this.Controls.Add(this.tGreen);
            this.Controls.Add(this.tBlue);
            this.Controls.Add(this.tRed);
            this.Controls.Add(this.btnDortgen);
            this.Controls.Add(this.btnDaire);
            this.Controls.Add(this.btnKalem);
            this.Controls.Add(this.pCizimAlani);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            ((System.ComponentModel.ISupportInitialize)(this.pCizimAlani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSeciliRenk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pCizimAlani;
        private System.Windows.Forms.Button btnKalem;
        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.Button btnDortgen;
        private System.Windows.Forms.TrackBar tRed;
        private System.Windows.Forms.TrackBar tBlue;
        private System.Windows.Forms.TrackBar tGreen;
        private System.Windows.Forms.PictureBox pSeciliRenk;
    }
}