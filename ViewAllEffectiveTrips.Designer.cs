namespace WinGo
{
    partial class ViewAllEffectiveTrips
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sPanel1 = new WinGo.SPanel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError_1 = new System.Windows.Forms.Label();
            this.lbl_Name_Company = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SearchWorld = new WinGo.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Log_in = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Date_Now = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_ِAvailableTrips = new System.Windows.Forms.DataGridView();
            this.colNameDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumOfSeates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_More_INFO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colReservation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detailsOfTrips_Effec = new WinGo.DetailsOfTrips();
            this.ticketBooking = new WinGo.TicketBooking();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_search = new CustomControls.RJControls.RJButton();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ِAvailableTrips)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.btn_search);
            this.sPanel1.Controls.Add(this.lbl_error);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Controls.Add(this.lblError_1);
            this.sPanel1.Controls.Add(this.lbl_Name_Company);
            this.sPanel1.Controls.Add(this.panel2);
            this.sPanel1.Controls.Add(this.txt_SearchWorld);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Controls.Add(this.btn_Log_in);
            this.sPanel1.Controls.Add(this.label9);
            this.sPanel1.Controls.Add(this.label10);
            this.sPanel1.Controls.Add(this.label8);
            this.sPanel1.Controls.Add(this.label7);
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.lbl_Date_Now);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.panel3);
            this.sPanel1.Controls.Add(this.dGV_ِAvailableTrips);
            this.sPanel1.Edge = 120;
            this.sPanel1.Location = new System.Drawing.Point(123, 149);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(870, 532);
            this.sPanel1.TabIndex = 2;
            // 
            // lbl_error
            // 
            this.lbl_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_error.Location = new System.Drawing.Point(360, 34);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 34);
            this.lbl_error.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(443, 265);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 82;
            // 
            // lblError_1
            // 
            this.lblError_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError_1.AutoSize = true;
            this.lblError_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblError_1.Location = new System.Drawing.Point(435, 257);
            this.lblError_1.Name = "lblError_1";
            this.lblError_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError_1.Size = new System.Drawing.Size(0, 18);
            this.lblError_1.TabIndex = 81;
            // 
            // lbl_Name_Company
            // 
            this.lbl_Name_Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name_Company.AutoSize = true;
            this.lbl_Name_Company.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Name_Company.Location = new System.Drawing.Point(664, 34);
            this.lbl_Name_Company.Name = "lbl_Name_Company";
            this.lbl_Name_Company.Size = new System.Drawing.Size(76, 34);
            this.lbl_Name_Company.TabIndex = 67;
            this.lbl_Name_Company.Text = "شركة ";
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
            // txt_SearchWorld
            // 
            this.txt_SearchWorld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SearchWorld.BackColor = System.Drawing.Color.White;
            this.txt_SearchWorld.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_SearchWorld.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SearchWorld.BorderRadius = 15;
            this.txt_SearchWorld.BorderSize = 2;
            this.txt_SearchWorld.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_SearchWorld.Location = new System.Drawing.Point(207, 92);
            this.txt_SearchWorld.Multiline = true;
            this.txt_SearchWorld.Name = "txt_SearchWorld";
            this.txt_SearchWorld.PasswordChar = true;
            this.txt_SearchWorld.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SearchWorld.PlaceholderText = "";
            this.txt_SearchWorld.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SearchWorld.Size = new System.Drawing.Size(284, 32);
            this.txt_SearchWorld.TabIndex = 69;
            this.txt_SearchWorld.Texts = "";
            this.txt_SearchWorld.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(501, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "بحث عن رحلة";
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
            // lbl_Date_Now
            // 
            this.lbl_Date_Now.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date_Now.AutoSize = true;
            this.lbl_Date_Now.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date_Now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Date_Now.Location = new System.Drawing.Point(61, 34);
            this.lbl_Date_Now.Name = "lbl_Date_Now";
            this.lbl_Date_Now.Size = new System.Drawing.Size(0, 34);
            this.lbl_Date_Now.TabIndex = 53;
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
            // dGV_ِAvailableTrips
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_ِAvailableTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_ِAvailableTrips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGV_ِAvailableTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_ِAvailableTrips.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ِAvailableTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_ِAvailableTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ِAvailableTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameDriver,
            this.colAidName,
            this.colBusNum,
            this.dataGridViewTextBoxColumn1,
            this.colNumOfSeates,
            this.colPrice,
            this.colBusType,
            this.col_More_INFO,
            this.colReservation});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_ِAvailableTrips.DefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_ِAvailableTrips.EnableHeadersVisualStyles = false;
            this.dGV_ِAvailableTrips.Location = new System.Drawing.Point(33, 151);
            this.dGV_ِAvailableTrips.Name = "dGV_ِAvailableTrips";
            this.dGV_ِAvailableTrips.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dGV_ِAvailableTrips.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_ِAvailableTrips.RowTemplate.Height = 25;
            this.dGV_ِAvailableTrips.Size = new System.Drawing.Size(816, 347);
            this.dGV_ِAvailableTrips.TabIndex = 80;
            this.dGV_ِAvailableTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_ِAvailableTrips_CellContentClick);
            this.dGV_ِAvailableTrips.CellStyleContentChanged += new System.Windows.Forms.DataGridViewCellStyleContentChangedEventHandler(this.dGV_ِAvailableTrips_CellStyleContentChanged);
            // 
            // colNameDriver
            // 
            this.colNameDriver.HeaderText = "تاريخ الرحلة";
            this.colNameDriver.Name = "colNameDriver";
            this.colNameDriver.Width = 115;
            // 
            // colAidName
            // 
            this.colAidName.HeaderText = "وقت الانطلاق";
            this.colAidName.Name = "colAidName";
            this.colAidName.Width = 110;
            // 
            // colBusNum
            // 
            this.colBusNum.HeaderText = "مكان الانطلاق";
            this.colBusNum.Name = "colBusNum";
            this.colBusNum.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "الوجهة";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colNumOfSeates
            // 
            this.colNumOfSeates.HeaderText = "رقم الباص";
            this.colNumOfSeates.Name = "colNumOfSeates";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "سعر التذكرة";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 90;
            // 
            // colBusType
            // 
            this.colBusType.HeaderText = "نوع الباص";
            this.colBusType.Name = "colBusType";
            this.colBusType.Width = 50;
            // 
            // col_More_INFO
            // 
            this.col_More_INFO.HeaderText = "تفاصيل";
            this.col_More_INFO.Name = "col_More_INFO";
            this.col_More_INFO.Text = "تفاصيل";
            this.col_More_INFO.UseColumnTextForButtonValue = true;
            this.col_More_INFO.Width = 50;
            // 
            // colReservation
            // 
            this.colReservation.HeaderText = "حجز";
            this.colReservation.Name = "colReservation";
            this.colReservation.Text = "حجز";
            this.colReservation.UseColumnTextForButtonValue = true;
            this.colReservation.Width = 50;
            // 
            // detailsOfTrips_Effec
            // 
            this.detailsOfTrips_Effec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsOfTrips_Effec.Location = new System.Drawing.Point(0, 0);
            this.detailsOfTrips_Effec.Name = "detailsOfTrips_Effec";
            this.detailsOfTrips_Effec.Size = new System.Drawing.Size(1092, 749);
            this.detailsOfTrips_Effec.TabIndex = 3;
            // 
            // ticketBooking
            // 
            this.ticketBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketBooking.Location = new System.Drawing.Point(0, 0);
            this.ticketBooking.Name = "ticketBooking";
            this.ticketBooking.Size = new System.Drawing.Size(1092, 749);
            this.ticketBooking.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sPanel1);
            this.panel4.Controls.Add(this.detailsOfTrips_Effec);
            this.panel4.Controls.Add(this.ticketBooking);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 749);
            this.panel4.TabIndex = 84;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_search.BorderRadius = 10;
            this.btn_search.BorderSize = 0;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(98, 92);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 32);
            this.btn_search.TabIndex = 84;
            this.btn_search.Text = "بحث";
            this.btn_search.TextColor = System.Drawing.Color.White;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // ViewAllEffectiveTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "ViewAllEffectiveTrips";
            this.Size = new System.Drawing.Size(1092, 749);
            this.Load += new System.EventHandler(this.ViewAllEffectiveTrips_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ِAvailableTrips)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel1;
        private DataGridView dGV_ِAvailableTrips;
        private Panel panel2;
        private RJTextBox txt_SearchWorld;
        private Label label2;
        private Panel panel1;
        private Label lbl_Name_Company;
        private CustomControls.RJControls.RJButton btn_Log_in;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbl_Date_Now;
        private Label label3;
        private Panel panel3;
        private DataGridViewTextBoxColumn colNameDriver;
        private DataGridViewTextBoxColumn colAidName;
        private DataGridViewTextBoxColumn colBusNum;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colNumOfSeates;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colBusType;
        private DataGridViewButtonColumn col_More_INFO;
        private DataGridViewButtonColumn colReservation;
        private DetailsOfTrips detailsOfTrips_Effec;
        private TicketBooking ticketBooking;
        private Label label1;
        private Label lblError_1;
        private Label lbl_error;
        private Panel panel4;
        private CustomControls.RJControls.RJButton btn_search;
    }
}
