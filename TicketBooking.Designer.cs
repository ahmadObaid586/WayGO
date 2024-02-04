namespace WinGo
{
    partial class TicketBooking
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
            this.lbl_Ticket_price = new System.Windows.Forms.Label();
            this.sPanel2 = new WinGo.SPanel();
            this.tlp_Resarivation_Seates = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_textprice = new System.Windows.Forms.Label();
            this.btn_rest = new CustomControls.RJControls.RJButton();
            this.lbl_SumOfPrices = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_reservation_seats = new CustomControls.RJControls.RJButton();
            this.btn_BackPage = new CustomControls.RJControls.RJButton();
            this.lbl_Total_Paid_Price = new System.Windows.Forms.Label();
            this.btn_Log_in = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Ticket = new WinGo.Resrvation_Customer_Info();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sPanel1.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.lbl_Ticket_price);
            this.sPanel1.Controls.Add(this.sPanel2);
            this.sPanel1.Controls.Add(this.lbl_textprice);
            this.sPanel1.Controls.Add(this.btn_rest);
            this.sPanel1.Controls.Add(this.lbl_SumOfPrices);
            this.sPanel1.Controls.Add(this.panel2);
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Controls.Add(this.panel3);
            this.sPanel1.Controls.Add(this.btn_reservation_seats);
            this.sPanel1.Controls.Add(this.btn_BackPage);
            this.sPanel1.Controls.Add(this.lbl_Total_Paid_Price);
            this.sPanel1.Controls.Add(this.btn_Log_in);
            this.sPanel1.Controls.Add(this.label9);
            this.sPanel1.Controls.Add(this.label10);
            this.sPanel1.Controls.Add(this.label8);
            this.sPanel1.Controls.Add(this.label7);
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Edge = 120;
            this.sPanel1.Location = new System.Drawing.Point(123, 149);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(870, 532);
            this.sPanel1.TabIndex = 3;
            this.sPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // lbl_Ticket_price
            // 
            this.lbl_Ticket_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ticket_price.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ticket_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Ticket_price.Location = new System.Drawing.Point(611, 446);
            this.lbl_Ticket_price.Name = "lbl_Ticket_price";
            this.lbl_Ticket_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Ticket_price.Size = new System.Drawing.Size(121, 32);
            this.lbl_Ticket_price.TabIndex = 98;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.Controls.Add(this.tlp_Resarivation_Seates);
            this.sPanel2.Edge = 40;
            this.sPanel2.Location = new System.Drawing.Point(196, 16);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(512, 416);
            this.sPanel2.TabIndex = 97;
            // 
            // tlp_Resarivation_Seates
            // 
            this.tlp_Resarivation_Seates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Resarivation_Seates.ColumnCount = 5;
            this.tlp_Resarivation_Seates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Resarivation_Seates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Resarivation_Seates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Resarivation_Seates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Resarivation_Seates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Resarivation_Seates.Location = new System.Drawing.Point(24, 12);
            this.tlp_Resarivation_Seates.Name = "tlp_Resarivation_Seates";
            this.tlp_Resarivation_Seates.RowCount = 11;
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tlp_Resarivation_Seates.Size = new System.Drawing.Size(476, 391);
            this.tlp_Resarivation_Seates.TabIndex = 67;
            this.tlp_Resarivation_Seates.Paint += new System.Windows.Forms.PaintEventHandler(this.tlp_Resarivation_Seates_Paint);
            this.tlp_Resarivation_Seates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Resarivation_Seates_MouseClick);
            this.tlp_Resarivation_Seates.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlp_Resarivation_Seates_MouseDown);
            // 
            // lbl_textprice
            // 
            this.lbl_textprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_textprice.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_textprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_textprice.Location = new System.Drawing.Point(727, 445);
            this.lbl_textprice.Name = "lbl_textprice";
            this.lbl_textprice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_textprice.Size = new System.Drawing.Size(121, 32);
            this.lbl_textprice.TabIndex = 96;
            this.lbl_textprice.Text = "سعر التذكرة :";
            // 
            // btn_rest
            // 
            this.btn_rest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_rest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_rest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_rest.BorderRadius = 10;
            this.btn_rest.BorderSize = 0;
            this.btn_rest.FlatAppearance.BorderSize = 0;
            this.btn_rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rest.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_rest.ForeColor = System.Drawing.Color.White;
            this.btn_rest.Location = new System.Drawing.Point(209, 456);
            this.btn_rest.Name = "btn_rest";
            this.btn_rest.Size = new System.Drawing.Size(188, 52);
            this.btn_rest.TabIndex = 95;
            this.btn_rest.Text = "تراجع";
            this.btn_rest.TextColor = System.Drawing.Color.White;
            this.btn_rest.UseVisualStyleBackColor = false;
            this.btn_rest.Click += new System.EventHandler(this.btn_rest_Click);
            // 
            // lbl_SumOfPrices
            // 
            this.lbl_SumOfPrices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SumOfPrices.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SumOfPrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_SumOfPrices.Location = new System.Drawing.Point(611, 478);
            this.lbl_SumOfPrices.Name = "lbl_SumOfPrices";
            this.lbl_SumOfPrices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SumOfPrices.Size = new System.Drawing.Size(97, 30);
            this.lbl_SumOfPrices.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.Location = new System.Drawing.Point(4, 439);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 1);
            this.panel2.TabIndex = 93;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel1.Location = new System.Drawing.Point(3, 439);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 0);
            this.panel1.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel3.Location = new System.Drawing.Point(4, 439);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 0);
            this.panel3.TabIndex = 91;
            // 
            // btn_reservation_seats
            // 
            this.btn_reservation_seats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reservation_seats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_reservation_seats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(141)))), ((int)(((byte)(175)))));
            this.btn_reservation_seats.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_reservation_seats.BorderRadius = 10;
            this.btn_reservation_seats.BorderSize = 0;
            this.btn_reservation_seats.FlatAppearance.BorderSize = 0;
            this.btn_reservation_seats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation_seats.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reservation_seats.ForeColor = System.Drawing.Color.White;
            this.btn_reservation_seats.Location = new System.Drawing.Point(403, 456);
            this.btn_reservation_seats.Name = "btn_reservation_seats";
            this.btn_reservation_seats.Size = new System.Drawing.Size(188, 52);
            this.btn_reservation_seats.TabIndex = 90;
            this.btn_reservation_seats.Text = "حجز";
            this.btn_reservation_seats.TextColor = System.Drawing.Color.White;
            this.btn_reservation_seats.UseVisualStyleBackColor = false;
            this.btn_reservation_seats.Click += new System.EventHandler(this.btn_reservation_seats_Click);
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
            this.btn_BackPage.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackPage.ForeColor = System.Drawing.Color.White;
            this.btn_BackPage.Location = new System.Drawing.Point(13, 456);
            this.btn_BackPage.Name = "btn_BackPage";
            this.btn_BackPage.Size = new System.Drawing.Size(188, 52);
            this.btn_BackPage.TabIndex = 87;
            this.btn_BackPage.Text = "عودة";
            this.btn_BackPage.TextColor = System.Drawing.Color.White;
            this.btn_BackPage.UseVisualStyleBackColor = false;
            this.btn_BackPage.Click += new System.EventHandler(this.btn_BackPage_Click_1);
            // 
            // lbl_Total_Paid_Price
            // 
            this.lbl_Total_Paid_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Total_Paid_Price.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total_Paid_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.lbl_Total_Paid_Price.Location = new System.Drawing.Point(704, 478);
            this.lbl_Total_Paid_Price.Name = "lbl_Total_Paid_Price";
            this.lbl_Total_Paid_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Total_Paid_Price.Size = new System.Drawing.Size(146, 30);
            this.lbl_Total_Paid_Price.TabIndex = 89;
            this.lbl_Total_Paid_Price.Text = "المبلغ الإجمالي :";
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
            this.btn_Log_in.Location = new System.Drawing.Point(1222, 1072);
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
            this.label9.Location = new System.Drawing.Point(1580, 958);
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
            this.label10.Location = new System.Drawing.Point(1580, 1008);
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
            this.label8.Location = new System.Drawing.Point(1595, 758);
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
            this.label7.Location = new System.Drawing.Point(1606, 808);
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
            this.label6.Location = new System.Drawing.Point(1608, 858);
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
            this.label5.Location = new System.Drawing.Point(1607, 908);
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
            this.label3.Location = new System.Drawing.Point(1669, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "شركة القدموس";
            // 
            // pnl_Ticket
            // 
            this.pnl_Ticket.Location = new System.Drawing.Point(0, 0);
            this.pnl_Ticket.Name = "pnl_Ticket";
            this.pnl_Ticket.Size = new System.Drawing.Size(1092, 749);
            this.pnl_Ticket.TabIndex = 4;
            this.pnl_Ticket.Load += new System.EventHandler(this.pnl_Ticket_Load);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 749);
            this.panel4.TabIndex = 96;
            // 
            // TicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Ticket);
            this.Name = "TicketBooking";
            this.Size = new System.Drawing.Size(1092, 749);
            this.Load += new System.EventHandler(this.TicketBooking_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.sPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel1;
        private CustomControls.RJControls.RJButton btn_Log_in;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TableLayoutPanel tlp_Resarivation_Seates;
        private Label lbl_Total_Paid_Price;
        private CustomControls.RJControls.RJButton btn_BackPage;
        private Resrvation_Customer_Info pnl_Ticket;
        private CustomControls.RJControls.RJButton btn_reservation_seats;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lbl_SumOfPrices;
        private CustomControls.RJControls.RJButton btn_rest;
        private Panel panel4;
        private Label lbl_textprice;
        private SPanel sPanel2;
        private Label lbl_Ticket_price;
    }
}
