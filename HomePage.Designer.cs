namespace WinGo
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnl_homepage = new System.Windows.Forms.Panel();
            this.tlp_homepage = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_sidepar = new System.Windows.Forms.Panel();
            this.ViewAllTrioAvalable_btn = new CustomControls.RJControls.RJButton();
            this.ViewLastTrips_btn = new CustomControls.RJControls.RJButton();
            this.btn_addTrip = new CustomControls.RJControls.RJButton();
            this.ViewAllBus_btn = new CustomControls.RJControls.RJButton();
            this.SidePanel = new WinGo.SPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewAllBuses1 = new WinGo.ViewAllBuses();
            this.ViewLastTrips_lst = new WinGo.ViewLastTrips();
            this.mainPage_1 = new WinGo.MainPage_();
            this.addNewTrip1 = new WinGo.AddNewTrip();
            this.viewAllEffectiveTrips = new WinGo.ViewAllEffectiveTrips();
            this.pnl_homepage.SuspendLayout();
            this.tlp_homepage.SuspendLayout();
            this.pnl_sidepar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_homepage
            // 
            this.pnl_homepage.Controls.Add(this.tlp_homepage);
            this.pnl_homepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_homepage.Location = new System.Drawing.Point(0, 0);
            this.pnl_homepage.Name = "pnl_homepage";
            this.pnl_homepage.Size = new System.Drawing.Size(1370, 738);
            this.pnl_homepage.TabIndex = 0;
            // 
            // tlp_homepage
            // 
            this.tlp_homepage.ColumnCount = 2;
            this.tlp_homepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.91138F));
            this.tlp_homepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08863F));
            this.tlp_homepage.Controls.Add(this.pnl_sidepar, 1, 0);
            this.tlp_homepage.Controls.Add(this.panel1, 0, 0);
            this.tlp_homepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_homepage.Location = new System.Drawing.Point(0, 0);
            this.tlp_homepage.Name = "tlp_homepage";
            this.tlp_homepage.RowCount = 1;
            this.tlp_homepage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_homepage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_homepage.Size = new System.Drawing.Size(1370, 738);
            this.tlp_homepage.TabIndex = 0;
            // 
            // pnl_sidepar
            // 
            this.pnl_sidepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.pnl_sidepar.Controls.Add(this.ViewAllTrioAvalable_btn);
            this.pnl_sidepar.Controls.Add(this.ViewLastTrips_btn);
            this.pnl_sidepar.Controls.Add(this.btn_addTrip);
            this.pnl_sidepar.Controls.Add(this.ViewAllBus_btn);
            this.pnl_sidepar.Controls.Add(this.SidePanel);
            this.pnl_sidepar.Controls.Add(this.pictureBox1);
            this.pnl_sidepar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_sidepar.Location = new System.Drawing.Point(1097, 3);
            this.pnl_sidepar.Name = "pnl_sidepar";
            this.pnl_sidepar.Size = new System.Drawing.Size(270, 732);
            this.pnl_sidepar.TabIndex = 0;
            this.pnl_sidepar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sidepar_Paint);
            // 
            // ViewAllTrioAvalable_btn
            // 
            this.ViewAllTrioAvalable_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewAllTrioAvalable_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewAllTrioAvalable_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewAllTrioAvalable_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ViewAllTrioAvalable_btn.BorderRadius = 10;
            this.ViewAllTrioAvalable_btn.BorderSize = 0;
            this.ViewAllTrioAvalable_btn.FlatAppearance.BorderSize = 0;
            this.ViewAllTrioAvalable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAllTrioAvalable_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewAllTrioAvalable_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewAllTrioAvalable_btn.Location = new System.Drawing.Point(31, 468);
            this.ViewAllTrioAvalable_btn.Name = "ViewAllTrioAvalable_btn";
            this.ViewAllTrioAvalable_btn.Size = new System.Drawing.Size(223, 50);
            this.ViewAllTrioAvalable_btn.TabIndex = 17;
            this.ViewAllTrioAvalable_btn.Text = "عرض الرحلات الفعالة";
            this.ViewAllTrioAvalable_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewAllTrioAvalable_btn.UseVisualStyleBackColor = false;
            this.ViewAllTrioAvalable_btn.Click += new System.EventHandler(this.ViewAllTrioAvalable_btn_Click);
            // 
            // ViewLastTrips_btn
            // 
            this.ViewLastTrips_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewLastTrips_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewLastTrips_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewLastTrips_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ViewLastTrips_btn.BorderRadius = 10;
            this.ViewLastTrips_btn.BorderSize = 0;
            this.ViewLastTrips_btn.FlatAppearance.BorderSize = 0;
            this.ViewLastTrips_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLastTrips_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewLastTrips_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewLastTrips_btn.Location = new System.Drawing.Point(32, 408);
            this.ViewLastTrips_btn.Name = "ViewLastTrips_btn";
            this.ViewLastTrips_btn.Size = new System.Drawing.Size(223, 50);
            this.ViewLastTrips_btn.TabIndex = 15;
            this.ViewLastTrips_btn.Text = "عرض الرحلات السابقة";
            this.ViewLastTrips_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewLastTrips_btn.UseVisualStyleBackColor = false;
            this.ViewLastTrips_btn.Click += new System.EventHandler(this.ViewLastTrips_btn_Click);
            // 
            // btn_addTrip
            // 
            this.btn_addTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btn_addTrip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btn_addTrip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_addTrip.BorderRadius = 10;
            this.btn_addTrip.BorderSize = 0;
            this.btn_addTrip.FlatAppearance.BorderSize = 0;
            this.btn_addTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTrip.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btn_addTrip.Location = new System.Drawing.Point(32, 345);
            this.btn_addTrip.Name = "btn_addTrip";
            this.btn_addTrip.Size = new System.Drawing.Size(223, 50);
            this.btn_addTrip.TabIndex = 14;
            this.btn_addTrip.Text = "إضافة رحلة جديدة";
            this.btn_addTrip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.btn_addTrip.UseVisualStyleBackColor = false;
            this.btn_addTrip.Click += new System.EventHandler(this.btn_addTrip_Click);
            // 
            // ViewAllBus_btn
            // 
            this.ViewAllBus_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewAllBus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewAllBus_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ViewAllBus_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ViewAllBus_btn.BorderRadius = 10;
            this.ViewAllBus_btn.BorderSize = 0;
            this.ViewAllBus_btn.FlatAppearance.BorderSize = 0;
            this.ViewAllBus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAllBus_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewAllBus_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewAllBus_btn.Location = new System.Drawing.Point(31, 530);
            this.ViewAllBus_btn.Name = "ViewAllBus_btn";
            this.ViewAllBus_btn.Size = new System.Drawing.Size(223, 50);
            this.ViewAllBus_btn.TabIndex = 16;
            this.ViewAllBus_btn.Text = "عرض باصات الشركة";
            this.ViewAllBus_btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.ViewAllBus_btn.UseVisualStyleBackColor = false;
            this.ViewAllBus_btn.Click += new System.EventHandler(this.ViewAllBus_btn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SidePanel.BorderColor = System.Drawing.Color.White;
            this.SidePanel.Edge = 20;
            this.SidePanel.Location = new System.Drawing.Point(233, 311);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 50);
            this.SidePanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.viewAllBuses1);
            this.panel1.Controls.Add(this.ViewLastTrips_lst);
            this.panel1.Controls.Add(this.mainPage_1);
            this.panel1.Controls.Add(this.addNewTrip1);
            this.panel1.Controls.Add(this.viewAllEffectiveTrips);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 732);
            this.panel1.TabIndex = 1;
            // 
            // viewAllBuses1
            // 
            this.viewAllBuses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllBuses1.Location = new System.Drawing.Point(0, 0);
            this.viewAllBuses1.Name = "viewAllBuses1";
            this.viewAllBuses1.Size = new System.Drawing.Size(1088, 732);
            this.viewAllBuses1.TabIndex = 20;
            this.viewAllBuses1.Load += new System.EventHandler(this.viewAllBuses1_Load);
            // 
            // ViewLastTrips_lst
            // 
            this.ViewLastTrips_lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewLastTrips_lst.Location = new System.Drawing.Point(0, 0);
            this.ViewLastTrips_lst.Name = "ViewLastTrips_lst";
            this.ViewLastTrips_lst.Size = new System.Drawing.Size(1088, 732);
            this.ViewLastTrips_lst.TabIndex = 18;
            // 
            // mainPage_1
            // 
            this.mainPage_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage_1.Location = new System.Drawing.Point(0, 0);
            this.mainPage_1.Name = "mainPage_1";
            this.mainPage_1.Size = new System.Drawing.Size(1088, 732);
            this.mainPage_1.TabIndex = 16;
            // 
            // addNewTrip1
            // 
            this.addNewTrip1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addNewTrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addNewTrip1.Location = new System.Drawing.Point(0, 0);
            this.addNewTrip1.Name = "addNewTrip1";
            this.addNewTrip1.Size = new System.Drawing.Size(1088, 732);
            this.addNewTrip1.TabIndex = 17;
            // 
            // viewAllEffectiveTrips
            // 
            this.viewAllEffectiveTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllEffectiveTrips.Location = new System.Drawing.Point(0, 0);
            this.viewAllEffectiveTrips.Name = "viewAllEffectiveTrips";
            this.viewAllEffectiveTrips.Size = new System.Drawing.Size(1088, 732);
            this.viewAllEffectiveTrips.TabIndex = 19;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 738);
            this.Controls.Add(this.pnl_homepage);
            this.MaximumSize = new System.Drawing.Size(1386, 777);
            this.MinimumSize = new System.Drawing.Size(1210, 726);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnl_homepage.ResumeLayout(false);
            this.tlp_homepage.ResumeLayout(false);
            this.pnl_sidepar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_homepage;
        private TableLayoutPanel tlp_homepage;
        private Panel pnl_sidepar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private SPanel SidePanel;
        private MainPage_ mainPage_1;
        private AddNewTrip addNewTrip1;
        private CustomControls.RJControls.RJButton ViewAllTrioAvalable_btn;
        private CustomControls.RJControls.RJButton ViewLastTrips_btn;
        private CustomControls.RJControls.RJButton btn_addTrip;
        private CustomControls.RJControls.RJButton ViewAllBus_btn;
        private ViewLastTrips ViewLastTrips_lst;
        private ViewAllEffectiveTrips viewAllEffectiveTrips;
        public ViewAllBuses viewAllBuses1;
    }
}