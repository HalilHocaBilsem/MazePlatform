namespace MazePlatform
{
    partial class FrmLevelEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevelEditor));
            this.btnNewMap = new System.Windows.Forms.Button();
            this.btnOpenMap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGrass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDanger = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNewMap
            // 
            this.btnNewMap.Location = new System.Drawing.Point(12, 12);
            this.btnNewMap.Name = "btnNewMap";
            this.btnNewMap.Size = new System.Drawing.Size(114, 49);
            this.btnNewMap.TabIndex = 1;
            this.btnNewMap.Text = "Yeni Harita";
            this.btnNewMap.UseVisualStyleBackColor = true;
            this.btnNewMap.Click += new System.EventHandler(this.btnNewMap_Click);
            // 
            // btnOpenMap
            // 
            this.btnOpenMap.Location = new System.Drawing.Point(132, 12);
            this.btnOpenMap.Name = "btnOpenMap";
            this.btnOpenMap.Size = new System.Drawing.Size(114, 49);
            this.btnOpenMap.TabIndex = 2;
            this.btnOpenMap.Text = "Harita Aç";
            this.btnOpenMap.UseVisualStyleBackColor = true;
            this.btnOpenMap.Click += new System.EventHandler(this.btnOpenMap_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGrass
            // 
            this.btnGrass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrass.BackgroundImage")));
            this.btnGrass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrass.Location = new System.Drawing.Point(442, 12);
            this.btnGrass.Name = "btnGrass";
            this.btnGrass.Size = new System.Drawing.Size(50, 49);
            this.btnGrass.TabIndex = 4;
            this.btnGrass.Tag = "G";
            this.btnGrass.UseVisualStyleBackColor = true;
            this.btnGrass.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(498, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 49);
            this.button5.TabIndex = 5;
            this.button5.Tag = "B";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnDanger
            // 
            this.btnDanger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDanger.BackgroundImage")));
            this.btnDanger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanger.Location = new System.Drawing.Point(610, 12);
            this.btnDanger.Name = "btnDanger";
            this.btnDanger.Size = new System.Drawing.Size(50, 49);
            this.btnDanger.TabIndex = 7;
            this.btnDanger.Tag = "D";
            this.btnDanger.UseVisualStyleBackColor = true;
            this.btnDanger.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestion.BackgroundImage")));
            this.btnQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Location = new System.Drawing.Point(554, 12);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(50, 49);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Tag = "Q";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(723, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(50, 49);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Tag = "F";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(667, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 49);
            this.btnStart.TabIndex = 8;
            this.btnStart.Tag = "S";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMap.Location = new System.Drawing.Point(10, 87);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1300, 600);
            this.panelMap.TabIndex = 10;
            // 
            // FrmLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 695);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDanger);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnGrass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenMap);
            this.Controls.Add(this.btnNewMap);
            this.Name = "FrmLevelEditor";
            this.Text = "FrmLevelEditor";
            this.Load += new System.EventHandler(this.FrmLevelEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewMap;
        private System.Windows.Forms.Button btnOpenMap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGrass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDanger;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelMap;
    }
}