namespace WinGo
{
    partial class Log_in
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.sPanel1 = new WinGo.SPanel();
            this.txtPassWord = new WinGo.RJTextBox();
            this.txtUserName = new WinGo.RJTextBox();
            this.btn_Log_in = new CustomControls.RJControls.RJButton();
            this.lblError_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.AutoSize = true;
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.txtPassWord);
            this.sPanel1.Controls.Add(this.txtUserName);
            this.sPanel1.Controls.Add(this.btn_Log_in);
            this.sPanel1.Controls.Add(this.lblError_1);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.panel3);
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Edge = 80;
            this.sPanel1.Location = new System.Drawing.Point(309, 170);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(516, 430);
            this.sPanel1.TabIndex = 16;
            this.sPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPassWord.BackColor = System.Drawing.Color.White;
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(69)))), ((int)(((byte)(116)))));
            this.txtPassWord.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtPassWord.BorderRadius = 15;
            this.txtPassWord.BorderSize = 2;
            this.txtPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassWord.Location = new System.Drawing.Point(62, 255);
            this.txtPassWord.Multiline = true;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = true;
            this.txtPassWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassWord.Size = new System.Drawing.Size(386, 41);
            this.txtPassWord.TabIndex = 53;
            this.txtPassWord.Texts = "";
            this.txtPassWord.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(65, 154);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = true;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(386, 41);
            this.txtUserName.TabIndex = 52;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // btn_Log_in
            // 
            this.btn_Log_in.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btn_Log_in.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btn_Log_in.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Log_in.BorderRadius = 25;
            this.btn_Log_in.BorderSize = 0;
            this.btn_Log_in.FlatAppearance.BorderSize = 0;
            this.btn_Log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Log_in.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Log_in.ForeColor = System.Drawing.Color.White;
            this.btn_Log_in.Location = new System.Drawing.Point(104, 336);
            this.btn_Log_in.Name = "btn_Log_in";
            this.btn_Log_in.Size = new System.Drawing.Size(308, 50);
            this.btn_Log_in.TabIndex = 58;
            this.btn_Log_in.Text = "تسجيل الدخول";
            this.btn_Log_in.TextColor = System.Drawing.Color.White;
            this.btn_Log_in.UseVisualStyleBackColor = false;
            this.btn_Log_in.Click += new System.EventHandler(this.btn_Log_in_Click_1);
            // 
            // lblError_1
            // 
            this.lblError_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblError_1.AutoSize = true;
            this.lblError_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError_1.Location = new System.Drawing.Point(173, 315);
            this.lblError_1.Name = "lblError_1";
            this.lblError_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError_1.Size = new System.Drawing.Size(0, 18);
            this.lblError_1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(358, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = ":كلمة المرور";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(345, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = ":اسم المستخدم";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(157, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 44);
            this.label2.TabIndex = 53;
            this.label2.Text = "تسجيل الدخول";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(247)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(247)))));
            this.panel3.Location = new System.Drawing.Point(65, 300);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 1);
            this.panel3.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(247)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(247)))));
            this.panel1.Location = new System.Drawing.Point(65, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 1);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sPanel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 640);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Log_in";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة تسجيل الدخول";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SPanel sPanel1;
        private Label lblError_1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
     //   private Button_Radius btn_Log_in;
        private Panel panel1;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton btn_Log_in;
        private RJTextBox txtUserName;
        private RJTextBox txtPassWord;
        private Panel panel2;
    }
}