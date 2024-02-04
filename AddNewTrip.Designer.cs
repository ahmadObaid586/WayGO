namespace WinGo
{
    partial class AddNewTrip
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
            this.sPanel1 = new WinGo.SPanel();
            this.lblError = new System.Windows.Forms.Label();
            this.dTP_Triptime = new System.Windows.Forms.DateTimePicker();
            this.dTP_Tripdate = new System.Windows.Forms.DateTimePicker();
            this.PriceTicket_lst = new System.Windows.Forms.ListBox();
            this.NumBus_lst = new System.Windows.Forms.ListBox();
            this.Distination_lst = new System.Windows.Forms.ListBox();
            this.Source_lst = new System.Windows.Forms.ListBox();
            this.btn_AddTrip = new CustomControls.RJControls.RJButton();
            this.lbl_numbus = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_Src = new System.Windows.Forms.Label();
            this.lbl_dis = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_Time_Now = new System.Windows.Forms.Label();
            this.lbl_Name_Company = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.lblError);
            this.sPanel1.Controls.Add(this.dTP_Triptime);
            this.sPanel1.Controls.Add(this.dTP_Tripdate);
            this.sPanel1.Controls.Add(this.PriceTicket_lst);
            this.sPanel1.Controls.Add(this.NumBus_lst);
            this.sPanel1.Controls.Add(this.Distination_lst);
            this.sPanel1.Controls.Add(this.Source_lst);
            this.sPanel1.Controls.Add(this.btn_AddTrip);
            this.sPanel1.Controls.Add(this.lbl_numbus);
            this.sPanel1.Controls.Add(this.lbl_price);
            this.sPanel1.Controls.Add(this.lbl_Src);
            this.sPanel1.Controls.Add(this.lbl_dis);
            this.sPanel1.Controls.Add(this.lbl_date);
            this.sPanel1.Controls.Add(this.lbl_time);
            this.sPanel1.Controls.Add(this.lbl_Time_Now);
            this.sPanel1.Controls.Add(this.lbl_Name_Company);
            this.sPanel1.Controls.Add(this.panel3);
            this.sPanel1.Edge = 120;
            this.sPanel1.Location = new System.Drawing.Point(123, 149);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(870, 532);
            this.sPanel1.TabIndex = 0;
            this.sPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.lblError.Location = new System.Drawing.Point(221, 476);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(207, 32);
            this.lblError.TabIndex = 75;
            // 
            // dTP_Triptime
            // 
            this.dTP_Triptime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTP_Triptime.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTP_Triptime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Triptime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dTP_Triptime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Triptime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Triptime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTP_Triptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_Triptime.Location = new System.Drawing.Point(202, 208);
            this.dTP_Triptime.Name = "dTP_Triptime";
            this.dTP_Triptime.ShowUpDown = true;
            this.dTP_Triptime.Size = new System.Drawing.Size(263, 25);
            this.dTP_Triptime.TabIndex = 74;
            this.dTP_Triptime.Value = new System.DateTime(2023, 10, 2, 0, 0, 0, 0);
            // 
            // dTP_Tripdate
            // 
            this.dTP_Tripdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTP_Tripdate.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTP_Tripdate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Tripdate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dTP_Tripdate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Tripdate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.dTP_Tripdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTP_Tripdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_Tripdate.Location = new System.Drawing.Point(202, 258);
            this.dTP_Tripdate.MinDate = new System.DateTime(2023, 10, 2, 0, 0, 0, 0);
            this.dTP_Tripdate.Name = "dTP_Tripdate";
            this.dTP_Tripdate.Size = new System.Drawing.Size(263, 25);
            this.dTP_Tripdate.TabIndex = 73;
            this.dTP_Tripdate.Value = new System.DateTime(2023, 10, 9, 0, 0, 0, 0);
            this.dTP_Tripdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PriceTicket_lst
            // 
            this.PriceTicket_lst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceTicket_lst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceTicket_lst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceTicket_lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.PriceTicket_lst.FormatString = "N2";
            this.PriceTicket_lst.FormattingEnabled = true;
            this.PriceTicket_lst.ItemHeight = 19;
            this.PriceTicket_lst.Items.AddRange(new object[] {
            "7000",
            "8000",
            "9000",
            "10000",
            "15000",
            "20000"});
            this.PriceTicket_lst.Location = new System.Drawing.Point(202, 350);
            this.PriceTicket_lst.Name = "PriceTicket_lst";
            this.PriceTicket_lst.Size = new System.Drawing.Size(263, 42);
            this.PriceTicket_lst.TabIndex = 72;
            // 
            // NumBus_lst
            // 
            this.NumBus_lst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumBus_lst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumBus_lst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumBus_lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.NumBus_lst.FormattingEnabled = true;
            this.NumBus_lst.ItemHeight = 19;
            this.NumBus_lst.Location = new System.Drawing.Point(202, 300);
            this.NumBus_lst.Name = "NumBus_lst";
            this.NumBus_lst.Size = new System.Drawing.Size(263, 42);
            this.NumBus_lst.TabIndex = 71;
            // 
            // Distination_lst
            // 
            this.Distination_lst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Distination_lst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Distination_lst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Distination_lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.Distination_lst.FormattingEnabled = true;
            this.Distination_lst.ItemHeight = 19;
            this.Distination_lst.Items.AddRange(new object[] {
            "hama",
            "tartous",
            "دمشق",
            "حمص",
            "حماه",
            "طرطوس",
            "بانياس",
            "اللاذقية ",
            "حلب",
            "دير الزور",
            "الحسكة",
            "الرقة"});
            this.Distination_lst.Location = new System.Drawing.Point(202, 150);
            this.Distination_lst.Name = "Distination_lst";
            this.Distination_lst.Size = new System.Drawing.Size(263, 42);
            this.Distination_lst.TabIndex = 68;
            // 
            // Source_lst
            // 
            this.Source_lst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Source_lst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Source_lst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Source_lst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.Source_lst.FormattingEnabled = true;
            this.Source_lst.ItemHeight = 19;
            this.Source_lst.Items.AddRange(new object[] {
            "hama",
            "tartous",
            "دمشق",
            "حمص",
            "حماه",
            "طرطوس",
            "بانياس",
            "اللاذقية ",
            "حلب",
            "دير الزور",
            "الحسكة",
            "الرقة"});
            this.Source_lst.Location = new System.Drawing.Point(202, 100);
            this.Source_lst.Name = "Source_lst";
            this.Source_lst.Size = new System.Drawing.Size(263, 42);
            this.Source_lst.TabIndex = 67;
            this.Source_lst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Source_lst_MouseClick);
            // 
            // btn_AddTrip
            // 
            this.btn_AddTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_AddTrip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_AddTrip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AddTrip.BorderRadius = 25;
            this.btn_AddTrip.BorderSize = 0;
            this.btn_AddTrip.FlatAppearance.BorderSize = 0;
            this.btn_AddTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTrip.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddTrip.ForeColor = System.Drawing.Color.White;
            this.btn_AddTrip.Location = new System.Drawing.Point(171, 414);
            this.btn_AddTrip.Name = "btn_AddTrip";
            this.btn_AddTrip.Size = new System.Drawing.Size(308, 50);
            this.btn_AddTrip.TabIndex = 66;
            this.btn_AddTrip.Text = "إضافة";
            this.btn_AddTrip.TextColor = System.Drawing.Color.White;
            this.btn_AddTrip.UseVisualStyleBackColor = false;
            this.btn_AddTrip.Click += new System.EventHandler(this.btn_AddTrip_Click);
            // 
            // lbl_numbus
            // 
            this.lbl_numbus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_numbus.AutoSize = true;
            this.lbl_numbus.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_numbus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_numbus.Location = new System.Drawing.Point(529, 300);
            this.lbl_numbus.Name = "lbl_numbus";
            this.lbl_numbus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_numbus.Size = new System.Drawing.Size(114, 34);
            this.lbl_numbus.TabIndex = 65;
            this.lbl_numbus.Text = "رقم الباص";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_price.Location = new System.Drawing.Point(529, 350);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_price.Size = new System.Drawing.Size(128, 34);
            this.lbl_price.TabIndex = 64;
            this.lbl_price.Text = "سعر التذكرة";
            // 
            // lbl_Src
            // 
            this.lbl_Src.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Src.AutoSize = true;
            this.lbl_Src.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Src.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Src.Location = new System.Drawing.Point(544, 100);
            this.lbl_Src.Name = "lbl_Src";
            this.lbl_Src.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Src.Size = new System.Drawing.Size(92, 34);
            this.lbl_Src.TabIndex = 63;
            this.lbl_Src.Text = "الانطلاق";
            // 
            // lbl_dis
            // 
            this.lbl_dis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dis.AutoSize = true;
            this.lbl_dis.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_dis.Location = new System.Drawing.Point(555, 150);
            this.lbl_dis.Name = "lbl_dis";
            this.lbl_dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dis.Size = new System.Drawing.Size(81, 34);
            this.lbl_dis.TabIndex = 62;
            this.lbl_dis.Text = "الوجهة";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_date.Location = new System.Drawing.Point(563, 250);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_date.Size = new System.Drawing.Size(80, 34);
            this.lbl_date.TabIndex = 61;
            this.lbl_date.Text = "التاريخ";
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_time.Location = new System.Drawing.Point(555, 199);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_time.Size = new System.Drawing.Size(81, 34);
            this.lbl_time.TabIndex = 60;
            this.lbl_time.Text = "الساعة";
            // 
            // lbl_Time_Now
            // 
            this.lbl_Time_Now.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Time_Now.AutoSize = true;
            this.lbl_Time_Now.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time_Now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Time_Now.Location = new System.Drawing.Point(60, 34);
            this.lbl_Time_Now.Name = "lbl_Time_Now";
            this.lbl_Time_Now.Size = new System.Drawing.Size(0, 34);
            this.lbl_Time_Now.TabIndex = 53;
            this.lbl_Time_Now.Click += new System.EventHandler(this.label4_Click);
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
            this.lbl_Name_Company.TabIndex = 52;
            this.lbl_Name_Company.Text = "شركة ";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.Location = new System.Drawing.Point(-41, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 1);
            this.panel3.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1092, 749);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddNewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddNewTrip";
            this.Size = new System.Drawing.Size(1092, 749);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel1;
        private Panel panel3;
        private Label lbl_Name_Company;
        private Label lbl_Time_Now;
        private Label lbl_numbus;
        private Label lbl_price;
        private Label lbl_Src;
        private Label lbl_dis;
        private Label lbl_date;
        private Label lbl_time;
        private CustomControls.RJControls.RJButton btn_AddTrip;
        private ListBox Distination_lst;
        private ListBox Source_lst;
        private ListBox PriceTicket_lst;
        private ListBox NumBus_lst;
        private DateTimePicker dTP_Tripdate;
        private DateTimePicker dTP_Triptime;
        private Label lblError;
        private Panel panel1;
    }
}
