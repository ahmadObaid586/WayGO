namespace WinGo
{
    partial class MainPage_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage_));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sPanel2 = new WinGo.SPanel();
            this.lbl_Name_Company = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(334, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // sPanel2
            // 
            this.sPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.sPanel2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.sPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sPanel2.Controls.Add(this.label2);
            this.sPanel2.Controls.Add(this.lbl_Name_Company);
            this.sPanel2.Controls.Add(this.label1);
            this.sPanel2.Edge = 50;
            this.sPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.sPanel2.Location = new System.Drawing.Point(231, 200);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(518, 337);
            this.sPanel2.TabIndex = 16;
            // 
            // lbl_Name_Company
            // 
            this.lbl_Name_Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name_Company.AutoSize = true;
            this.lbl_Name_Company.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.lbl_Name_Company.Location = new System.Drawing.Point(172, 188);
            this.lbl_Name_Company.Name = "lbl_Name_Company";
            this.lbl_Name_Company.Size = new System.Drawing.Size(0, 31);
            this.lbl_Name_Company.TabIndex = 1;
            this.lbl_Name_Company.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "             أنت الآن في صفحة الوكيل      ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.sPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 564);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(267, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = " شركة ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MainPage_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainPage_";
            this.Size = new System.Drawing.Size(955, 564);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox2;
        private SPanel sPanel2;
        private Label lbl_Name_Company;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
