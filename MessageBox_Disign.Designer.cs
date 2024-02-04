namespace WinGo
{
    partial class MessageBox_Disign
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
            this.sPanel_MessageBox = new WinGo.SPanel();
            this.btn_No = new CustomControls.RJControls.RJButton();
            this.btn_Ok = new CustomControls.RJControls.RJButton();
            this.Message_lbl = new System.Windows.Forms.Label();
            this.sPanel_MessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel_MessageBox
            // 
            this.sPanel_MessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.sPanel_MessageBox.BorderColor = System.Drawing.Color.Turquoise;
            this.sPanel_MessageBox.Controls.Add(this.btn_No);
            this.sPanel_MessageBox.Controls.Add(this.btn_Ok);
            this.sPanel_MessageBox.Controls.Add(this.Message_lbl);
            this.sPanel_MessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPanel_MessageBox.Edge = 50;
            this.sPanel_MessageBox.Location = new System.Drawing.Point(0, 0);
            this.sPanel_MessageBox.Name = "sPanel_MessageBox";
            this.sPanel_MessageBox.Size = new System.Drawing.Size(447, 210);
            this.sPanel_MessageBox.TabIndex = 0;
            this.sPanel_MessageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel_MessageBox_Paint);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_No.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_No.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_No.BorderRadius = 10;
            this.btn_No.BorderSize = 0;
            this.btn_No.FlatAppearance.BorderSize = 0;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_No.ForeColor = System.Drawing.Color.White;
            this.btn_No.Location = new System.Drawing.Point(80, 131);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(80, 40);
            this.btn_No.TabIndex = 87;
            this.btn_No.Text = "لا";
            this.btn_No.TextColor = System.Drawing.Color.White;
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Ok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Ok.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Ok.BorderRadius = 10;
            this.btn_Ok.BorderSize = 0;
            this.btn_Ok.FlatAppearance.BorderSize = 0;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(254, 131);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(80, 40);
            this.btn_Ok.TabIndex = 86;
            this.btn_Ok.Text = "نعم";
            this.btn_Ok.TextColor = System.Drawing.Color.White;
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Message_lbl
            // 
            this.Message_lbl.AutoSize = true;
            this.Message_lbl.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.Message_lbl.Location = new System.Drawing.Point(102, 50);
            this.Message_lbl.Name = "Message_lbl";
            this.Message_lbl.Size = new System.Drawing.Size(0, 30);
            this.Message_lbl.TabIndex = 69;
            this.Message_lbl.Click += new System.EventHandler(this.Message_lbl_Click);
            // 
            // MessageBox_Disign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 210);
            this.Controls.Add(this.sPanel_MessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox_Disign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox_Disign";
            this.Load += new System.EventHandler(this.MessageBox_Disign_Load);
            this.sPanel_MessageBox.ResumeLayout(false);
            this.sPanel_MessageBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel_MessageBox;
        private Label Message_lbl;
        private CustomControls.RJControls.RJButton btn_No;
        private CustomControls.RJControls.RJButton btn_Ok;
    }
}