namespace WinGo
{
    partial class DetailsOfTrips
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_detailsTrip = new WinGo.SPanel();
            this.btn_Print = new CustomControls.RJControls.RJButton();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_BackPage = new CustomControls.RJControls.RJButton();
            this.btn_DeleteTrip = new CustomControls.RJControls.RJButton();
            this.btn_Bus_INFO = new CustomControls.RJControls.RJButton();
            this.dGV_CustomerInfo = new System.Windows.Forms.DataGridView();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_More_INFO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Log_in = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.viewSub_Bus_Info = new WinGo.ViewSub_Bus_Info();
            this.more_Informations_Customer = new WinGo.More_Informations_Customer();
            this.pnl_detailsTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_detailsTrip
            // 
            this.pnl_detailsTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_detailsTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pnl_detailsTrip.BorderColor = System.Drawing.Color.White;
            this.pnl_detailsTrip.Controls.Add(this.btn_Print);
            this.pnl_detailsTrip.Controls.Add(this.lbl_msg);
            this.pnl_detailsTrip.Controls.Add(this.lbl_error);
            this.pnl_detailsTrip.Controls.Add(this.btn_BackPage);
            this.pnl_detailsTrip.Controls.Add(this.btn_DeleteTrip);
            this.pnl_detailsTrip.Controls.Add(this.btn_Bus_INFO);
            this.pnl_detailsTrip.Controls.Add(this.dGV_CustomerInfo);
            this.pnl_detailsTrip.Controls.Add(this.panel2);
            this.pnl_detailsTrip.Controls.Add(this.label2);
            this.pnl_detailsTrip.Controls.Add(this.panel1);
            this.pnl_detailsTrip.Controls.Add(this.btn_Log_in);
            this.pnl_detailsTrip.Controls.Add(this.label9);
            this.pnl_detailsTrip.Controls.Add(this.label10);
            this.pnl_detailsTrip.Controls.Add(this.label8);
            this.pnl_detailsTrip.Controls.Add(this.label7);
            this.pnl_detailsTrip.Controls.Add(this.label6);
            this.pnl_detailsTrip.Controls.Add(this.label5);
            this.pnl_detailsTrip.Controls.Add(this.label3);
            this.pnl_detailsTrip.Controls.Add(this.panel3);
            this.pnl_detailsTrip.Edge = 120;
            this.pnl_detailsTrip.Location = new System.Drawing.Point(123, 149);
            this.pnl_detailsTrip.Name = "pnl_detailsTrip";
            this.pnl_detailsTrip.Size = new System.Drawing.Size(870, 532);
            this.pnl_detailsTrip.TabIndex = 2;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Print.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Print.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Print.BorderRadius = 10;
            this.btn_Print.BorderSize = 0;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(446, 10);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(110, 50);
            this.btn_Print.TabIndex = 88;
            this.btn_Print.Text = "طباعة";
            this.btn_Print.TextColor = System.Drawing.Color.White;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click_1);
            // 
            // lbl_msg
            // 
            this.lbl_msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_msg.Location = new System.Drawing.Point(450, 118);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 30);
            this.lbl_msg.TabIndex = 87;
            // 
            // lbl_error
            // 
            this.lbl_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(494, 119);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_error.Size = new System.Drawing.Size(0, 19);
            this.lbl_error.TabIndex = 86;
            // 
            // btn_BackPage
            // 
            this.btn_BackPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_BackPage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_BackPage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BackPage.BorderRadius = 10;
            this.btn_BackPage.BorderSize = 0;
            this.btn_BackPage.FlatAppearance.BorderSize = 0;
            this.btn_BackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackPage.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackPage.ForeColor = System.Drawing.Color.White;
            this.btn_BackPage.Location = new System.Drawing.Point(43, 10);
            this.btn_BackPage.Name = "btn_BackPage";
            this.btn_BackPage.Size = new System.Drawing.Size(110, 50);
            this.btn_BackPage.TabIndex = 85;
            this.btn_BackPage.Text = "عودة";
            this.btn_BackPage.TextColor = System.Drawing.Color.White;
            this.btn_BackPage.UseVisualStyleBackColor = false;
            this.btn_BackPage.Click += new System.EventHandler(this.btn_BackPage_Click);
            // 
            // btn_DeleteTrip
            // 
            this.btn_DeleteTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_DeleteTrip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_DeleteTrip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DeleteTrip.BorderRadius = 10;
            this.btn_DeleteTrip.BorderSize = 0;
            this.btn_DeleteTrip.FlatAppearance.BorderSize = 0;
            this.btn_DeleteTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTrip.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteTrip.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteTrip.Location = new System.Drawing.Point(173, 10);
            this.btn_DeleteTrip.Name = "btn_DeleteTrip";
            this.btn_DeleteTrip.Size = new System.Drawing.Size(110, 50);
            this.btn_DeleteTrip.TabIndex = 83;
            this.btn_DeleteTrip.Text = "حذف الرحلة";
            this.btn_DeleteTrip.TextColor = System.Drawing.Color.White;
            this.btn_DeleteTrip.UseVisualStyleBackColor = false;
            this.btn_DeleteTrip.Click += new System.EventHandler(this.btn_DeleteTrip_Click);
            // 
            // btn_Bus_INFO
            // 
            this.btn_Bus_INFO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Bus_INFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Bus_INFO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_Bus_INFO.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Bus_INFO.BorderRadius = 10;
            this.btn_Bus_INFO.BorderSize = 0;
            this.btn_Bus_INFO.FlatAppearance.BorderSize = 0;
            this.btn_Bus_INFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bus_INFO.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Bus_INFO.ForeColor = System.Drawing.Color.White;
            this.btn_Bus_INFO.Location = new System.Drawing.Point(310, 10);
            this.btn_Bus_INFO.Name = "btn_Bus_INFO";
            this.btn_Bus_INFO.Size = new System.Drawing.Size(110, 50);
            this.btn_Bus_INFO.TabIndex = 82;
            this.btn_Bus_INFO.Text = "معلومات الباص";
            this.btn_Bus_INFO.TextColor = System.Drawing.Color.White;
            this.btn_Bus_INFO.UseVisualStyleBackColor = false;
            this.btn_Bus_INFO.Click += new System.EventHandler(this.btn_Bus_INFO_Click);
            // 
            // dGV_CustomerInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_CustomerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_CustomerInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGV_CustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_CustomerInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_CustomerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_CustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhoneNumber,
            this.colNameCustomer,
            this.colLastName,
            this.colGender,
            this.col_More_INFO});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_CustomerInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_CustomerInfo.EnableHeadersVisualStyles = false;
            this.dGV_CustomerInfo.Location = new System.Drawing.Point(27, 151);
            this.dGV_CustomerInfo.Name = "dGV_CustomerInfo";
            this.dGV_CustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dGV_CustomerInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_CustomerInfo.RowTemplate.Height = 25;
            this.dGV_CustomerInfo.Size = new System.Drawing.Size(822, 347);
            this.dGV_CustomerInfo.TabIndex = 80;
            this.dGV_CustomerInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CustomerInfo_CellContentClick);
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "رقم الهاتف";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Width = 200;
            // 
            // colNameCustomer
            // 
            this.colNameCustomer.HeaderText = "الاسم";
            this.colNameCustomer.Name = "colNameCustomer";
            this.colNameCustomer.Width = 170;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "الكنية";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 150;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "الجنس";
            this.colGender.Name = "colGender";
            this.colGender.Width = 129;
            // 
            // col_More_INFO
            // 
            this.col_More_INFO.HeaderText = "تفاصيل";
            this.col_More_INFO.Name = "col_More_INFO";
            this.col_More_INFO.Text = "تفاصيل";
            this.col_More_INFO.UseColumnTextForButtonValue = true;
            this.col_More_INFO.Width = 130;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 1);
            this.panel2.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(300, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "الأشخاص الموجودين في الرحلة";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(4, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 0);
            this.panel1.TabIndex = 52;
            // 
            // btn_Log_in
            // 
            this.btn_Log_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_Log_in.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_Log_in.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Log_in.BorderRadius = 25;
            this.btn_Log_in.BorderSize = 0;
            this.btn_Log_in.FlatAppearance.BorderSize = 0;
            this.btn_Log_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Log_in.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Log_in.ForeColor = System.Drawing.Color.White;
            this.btn_Log_in.Location = new System.Drawing.Point(887, 856);
            this.btn_Log_in.Name = "btn_Log_in";
            this.btn_Log_in.Size = new System.Drawing.Size(308, 50);
            this.btn_Log_in.TabIndex = 66;
            this.btn_Log_in.Text = "إضافة";
            this.btn_Log_in.TextColor = System.Drawing.Color.White;
            this.btn_Log_in.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label9.Location = new System.Drawing.Point(1245, 742);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(114, 34);
            this.label9.TabIndex = 65;
            this.label9.Text = "رقم الباص";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label10.Location = new System.Drawing.Point(1245, 792);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(128, 34);
            this.label10.TabIndex = 64;
            this.label10.Text = "سعر التذكرة";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label8.Location = new System.Drawing.Point(1260, 542);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(92, 34);
            this.label8.TabIndex = 63;
            this.label8.Text = "الانطلاق";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label7.Location = new System.Drawing.Point(1271, 592);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(81, 34);
            this.label7.TabIndex = 62;
            this.label7.Text = "الوجهة";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label6.Location = new System.Drawing.Point(1273, 642);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(80, 34);
            this.label6.TabIndex = 61;
            this.label6.Text = "التاريخ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(1272, 692);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(81, 34);
            this.label5.TabIndex = 60;
            this.label5.Text = "الساعة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(1334, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "شركة القدموس";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.Location = new System.Drawing.Point(5, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 0);
            this.panel3.TabIndex = 51;
            // 
            // viewSub_Bus_Info
            // 
            this.viewSub_Bus_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSub_Bus_Info.Location = new System.Drawing.Point(0, 0);
            this.viewSub_Bus_Info.Name = "viewSub_Bus_Info";
            this.viewSub_Bus_Info.Size = new System.Drawing.Size(1092, 749);
            this.viewSub_Bus_Info.TabIndex = 3;
            this.viewSub_Bus_Info.Load += new System.EventHandler(this.viewSub_Bus_Info_Load);
            // 
            // more_Informations_Customer
            // 
            this.more_Informations_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.more_Informations_Customer.Location = new System.Drawing.Point(0, 0);
            this.more_Informations_Customer.Name = "more_Informations_Customer";
            this.more_Informations_Customer.Size = new System.Drawing.Size(1092, 749);
            this.more_Informations_Customer.TabIndex = 86;
            // 
            // DetailsOfTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_detailsTrip);
            this.Controls.Add(this.viewSub_Bus_Info);
            this.Controls.Add(this.more_Informations_Customer);
            this.Name = "DetailsOfTrips";
            this.Size = new System.Drawing.Size(1092, 749);
            this.Load += new System.EventHandler(this.DetailsOfTrips_Load);
            this.pnl_detailsTrip.ResumeLayout(false);
            this.pnl_detailsTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CustomerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel pnl_detailsTrip;
        private DataGridView dGV_CustomerInfo;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private CustomControls.RJControls.RJButton btn_Log_in;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel3;
        private CustomControls.RJControls.RJButton btn_BackPage;
        private CustomControls.RJControls.RJButton btn_DeleteTrip;
        private CustomControls.RJControls.RJButton btn_Bus_INFO;
        private DataGridViewTextBoxColumn colPhoneNumber;
        private DataGridViewTextBoxColumn colNameCustomer;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewButtonColumn col_More_INFO;
        private ViewSub_Bus_Info viewSub_Bus_Info;
        private More_Informations_Customer more_Informations_Customer;
        private Label lbl_error;
        private Label lbl_msg;
        private CustomControls.RJControls.RJButton btn_Print;
    }
}
