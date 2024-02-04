namespace WinGo
{
    partial class ViewAllBuses
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
            this.edit_Bus_Info = new WinGo.Edit_Bus_Info();
            this.made_Trips = new WinGo.Made_Trips();
            this.panel19 = new System.Windows.Forms.Panel();
            this.pnl_ViewAllBuses = new WinGo.SPanel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btn_addTrip = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name_Company = new System.Windows.Forms.Label();
            this.btn_Log_in = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_DriverInfo = new System.Windows.Forms.DataGridView();
            this.colNameDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumOfSeates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTrips = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_AddNewBus = new WinGo.AddBus();
            this.panel19.SuspendLayout();
            this.pnl_ViewAllBuses.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DriverInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_Bus_Info
            // 
            this.edit_Bus_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_Bus_Info.Location = new System.Drawing.Point(0, 0);
            this.edit_Bus_Info.Name = "edit_Bus_Info";
            this.edit_Bus_Info.Size = new System.Drawing.Size(1092, 749);
            this.edit_Bus_Info.TabIndex = 80;
            this.edit_Bus_Info.Load += new System.EventHandler(this.edit_Bus_Info_Load);
            // 
            // made_Trips
            // 
            this.made_Trips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.made_Trips.Location = new System.Drawing.Point(0, 0);
            this.made_Trips.Name = "made_Trips";
            this.made_Trips.Size = new System.Drawing.Size(1092, 749);
            this.made_Trips.TabIndex = 80;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.pnl_ViewAllBuses);
            this.panel19.Controls.Add(this.edit_Bus_Info);
            this.panel19.Controls.Add(this.made_Trips);
            this.panel19.Controls.Add(this.pnl_AddNewBus);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1092, 749);
            this.panel19.TabIndex = 83;
            // 
            // pnl_ViewAllBuses
            // 
            this.pnl_ViewAllBuses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_ViewAllBuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pnl_ViewAllBuses.BorderColor = System.Drawing.Color.White;
            this.pnl_ViewAllBuses.Controls.Add(this.lbl_msg);
            this.pnl_ViewAllBuses.Controls.Add(this.panel13);
            this.pnl_ViewAllBuses.Controls.Add(this.panel17);
            this.pnl_ViewAllBuses.Controls.Add(this.panel18);
            this.pnl_ViewAllBuses.Controls.Add(this.btn_addTrip);
            this.pnl_ViewAllBuses.Controls.Add(this.panel2);
            this.pnl_ViewAllBuses.Controls.Add(this.label2);
            this.pnl_ViewAllBuses.Controls.Add(this.panel1);
            this.pnl_ViewAllBuses.Controls.Add(this.lbl_Name_Company);
            this.pnl_ViewAllBuses.Controls.Add(this.btn_Log_in);
            this.pnl_ViewAllBuses.Controls.Add(this.label9);
            this.pnl_ViewAllBuses.Controls.Add(this.label10);
            this.pnl_ViewAllBuses.Controls.Add(this.label8);
            this.pnl_ViewAllBuses.Controls.Add(this.label7);
            this.pnl_ViewAllBuses.Controls.Add(this.label6);
            this.pnl_ViewAllBuses.Controls.Add(this.label5);
            this.pnl_ViewAllBuses.Controls.Add(this.label3);
            this.pnl_ViewAllBuses.Controls.Add(this.panel3);
            this.pnl_ViewAllBuses.Controls.Add(this.dGV_DriverInfo);
            this.pnl_ViewAllBuses.Edge = 120;
            this.pnl_ViewAllBuses.Location = new System.Drawing.Point(123, 149);
            this.pnl_ViewAllBuses.Name = "pnl_ViewAllBuses";
            this.pnl_ViewAllBuses.Size = new System.Drawing.Size(870, 532);
            this.pnl_ViewAllBuses.TabIndex = 2;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(384, 46);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 19);
            this.lbl_msg.TabIndex = 82;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel13.Location = new System.Drawing.Point(5, 127);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(859, 1);
            this.panel13.TabIndex = 78;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel14.Location = new System.Drawing.Point(0, 44);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(859, 1);
            this.panel14.TabIndex = 77;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel15.Location = new System.Drawing.Point(-1, 44);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(860, 0);
            this.panel15.TabIndex = 76;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel16.Location = new System.Drawing.Point(0, 44);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(860, 0);
            this.panel16.TabIndex = 75;
            // 
            // panel17
            // 
            this.panel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel17.Location = new System.Drawing.Point(4, 127);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(860, 0);
            this.panel17.TabIndex = 77;
            // 
            // panel18
            // 
            this.panel18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel18.Location = new System.Drawing.Point(5, 127);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(860, 0);
            this.panel18.TabIndex = 76;
            // 
            // btn_addTrip
            // 
            this.btn_addTrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_addTrip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.btn_addTrip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addTrip.BorderRadius = 10;
            this.btn_addTrip.BorderSize = 0;
            this.btn_addTrip.FlatAppearance.BorderSize = 0;
            this.btn_addTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTrip.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addTrip.ForeColor = System.Drawing.Color.White;
            this.btn_addTrip.Location = new System.Drawing.Point(41, 17);
            this.btn_addTrip.Name = "btn_addTrip";
            this.btn_addTrip.Size = new System.Drawing.Size(113, 50);
            this.btn_addTrip.TabIndex = 75;
            this.btn_addTrip.Text = "إضافة باص";
            this.btn_addTrip.TextColor = System.Drawing.Color.White;
            this.btn_addTrip.UseVisualStyleBackColor = false;
            this.btn_addTrip.Click += new System.EventHandler(this.btn_addTrip_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 1);
            this.panel2.TabIndex = 74;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel7.Location = new System.Drawing.Point(0, 42);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(859, 1);
            this.panel7.TabIndex = 80;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel8.Location = new System.Drawing.Point(0, 44);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(859, 1);
            this.panel8.TabIndex = 77;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel9.Location = new System.Drawing.Point(-1, 44);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(860, 0);
            this.panel9.TabIndex = 76;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel10.Location = new System.Drawing.Point(0, 44);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(860, 0);
            this.panel10.TabIndex = 75;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel11.Location = new System.Drawing.Point(-1, 42);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(860, 0);
            this.panel11.TabIndex = 79;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel12.Location = new System.Drawing.Point(0, 42);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(860, 0);
            this.panel12.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 1);
            this.panel4.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel5.Location = new System.Drawing.Point(-1, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 0);
            this.panel5.TabIndex = 76;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(860, 0);
            this.panel6.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(371, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "الباصات الموجودة";
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
            // dGV_DriverInfo
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_DriverInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_DriverInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGV_DriverInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_DriverInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_DriverInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_DriverInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DriverInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameDriver,
            this.colAidName,
            this.colBusNum,
            this.colTypeBus,
            this.colNumOfSeates,
            this.col_Delete,
            this.colEdit,
            this.colTrips});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_DriverInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_DriverInfo.EnableHeadersVisualStyles = false;
            this.dGV_DriverInfo.Location = new System.Drawing.Point(8, 149);
            this.dGV_DriverInfo.Name = "dGV_DriverInfo";
            this.dGV_DriverInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dGV_DriverInfo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_DriverInfo.RowTemplate.Height = 25;
            this.dGV_DriverInfo.Size = new System.Drawing.Size(842, 344);
            this.dGV_DriverInfo.TabIndex = 79;
            this.dGV_DriverInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_DriverInfo_CellContentClick);
            // 
            // colNameDriver
            // 
            this.colNameDriver.HeaderText = "اسم السائق";
            this.colNameDriver.Name = "colNameDriver";
            this.colNameDriver.Width = 112;
            // 
            // colAidName
            // 
            this.colAidName.HeaderText = "اسم مساعد السائق";
            this.colAidName.Name = "colAidName";
            this.colAidName.Width = 128;
            // 
            // colBusNum
            // 
            this.colBusNum.HeaderText = "رقم الباص";
            this.colBusNum.Name = "colBusNum";
            // 
            // colTypeBus
            // 
            this.colTypeBus.HeaderText = "نوع الباص";
            this.colTypeBus.Name = "colTypeBus";
            // 
            // colNumOfSeates
            // 
            this.colNumOfSeates.HeaderText = "عدد المقاعد";
            this.colNumOfSeates.Name = "colNumOfSeates";
            this.colNumOfSeates.Width = 90;
            // 
            // col_Delete
            // 
            this.col_Delete.HeaderText = "حذف";
            this.col_Delete.Name = "col_Delete";
            this.col_Delete.Text = "حذف";
            this.col_Delete.UseColumnTextForButtonValue = true;
            this.col_Delete.Width = 90;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "تعديل";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "نعديل";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 90;
            // 
            // colTrips
            // 
            this.colTrips.HeaderText = "الرحلات";
            this.colTrips.Name = "colTrips";
            this.colTrips.Text = "الرحلات";
            this.colTrips.UseColumnTextForButtonValue = true;
            this.colTrips.Width = 90;
            // 
            // pnl_AddNewBus
            // 
            this.pnl_AddNewBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AddNewBus.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddNewBus.Name = "pnl_AddNewBus";
            this.pnl_AddNewBus.Size = new System.Drawing.Size(1092, 749);
            this.pnl_AddNewBus.TabIndex = 80;
            this.pnl_AddNewBus.Load += new System.EventHandler(this.addBus1_Load_1);
            // 
            // ViewAllBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel19);
            this.Name = "ViewAllBuses";
            this.Size = new System.Drawing.Size(1092, 749);
            this.Load += new System.EventHandler(this.ViewAllBuses_Load);
            this.panel19.ResumeLayout(false);
            this.pnl_ViewAllBuses.ResumeLayout(false);
            this.pnl_ViewAllBuses.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DriverInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewButtonColumn colDelete;
        private Edit_Bus_Info edit_Bus_Info;
        private Made_Trips made_Trips;
        private Panel panel19;
        private SPanel pnl_ViewAllBuses;
        private Label lbl_msg;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private CustomControls.RJControls.RJButton btn_addTrip;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
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
        private Label label3;
        private Panel panel3;
        private DataGridView dGV_DriverInfo;
        private DataGridViewTextBoxColumn colNameDriver;
        private DataGridViewTextBoxColumn colAidName;
        private DataGridViewTextBoxColumn colBusNum;
        private DataGridViewTextBoxColumn colTypeBus;
        private DataGridViewTextBoxColumn colNumOfSeates;
        private DataGridViewButtonColumn col_Delete;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colTrips;
        private AddBus pnl_AddNewBus;
    }
}
