namespace JD_Electronics_Application.Dashboard
{
    partial class AdministratorDashborad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorDashborad));
            this.btnmenu = new System.Windows.Forms.Button();
            this.mainCon2 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.fb_link = new System.Windows.Forms.LinkLabel();
            this.AdministratorDashPanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnFinancial = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Occupation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emp_name = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.AdministratorDashPanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.Transparent;
            this.btnmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmenu.BackgroundImage")));
            this.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmenu.FlatAppearance.BorderSize = 0;
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Location = new System.Drawing.Point(12, 16);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmenu.Size = new System.Drawing.Size(39, 44);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // mainCon2
            // 
            this.mainCon2.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Controls.Add(this.lbl_footer);
            this.panel5.Controls.Add(this.fb_link);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 912);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1656, 42);
            this.panel5.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(1486, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 20);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "YouTube";
            // 
            // lbl_footer
            // 
            this.lbl_footer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.Location = new System.Drawing.Point(25, 13);
            this.lbl_footer.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(271, 20);
            this.lbl_footer.TabIndex = 21;
            this.lbl_footer.Text = "Powered By 2MBS Software Solution";
            this.lbl_footer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fb_link
            // 
            this.fb_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fb_link.AutoSize = true;
            this.fb_link.Location = new System.Drawing.Point(1578, 13);
            this.fb_link.Name = "fb_link";
            this.fb_link.Size = new System.Drawing.Size(80, 20);
            this.fb_link.TabIndex = 22;
            this.fb_link.TabStop = true;
            this.fb_link.Text = "Facebook";
            // 
            // AdministratorDashPanel
            // 
            this.AdministratorDashPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdministratorDashPanel.BackgroundImage")));
            this.AdministratorDashPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdministratorDashPanel.Controls.Add(this.panel5);
            this.AdministratorDashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdministratorDashPanel.Location = new System.Drawing.Point(246, 79);
            this.AdministratorDashPanel.Name = "AdministratorDashPanel";
            this.AdministratorDashPanel.Size = new System.Drawing.Size(1656, 954);
            this.AdministratorDashPanel.TabIndex = 19;
            this.AdministratorDashPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdministratorDashPanel_Paint);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.btnEmployee);
            this.sidebar.Controls.Add(this.btnSupplier);
            this.sidebar.Controls.Add(this.btnFinancial);
            this.sidebar.Controls.Add(this.btnReport);
            this.sidebar.Controls.Add(this.btnScheduler);
            this.sidebar.Controls.Add(this.btnHelp);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 79);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(246, 954);
            this.sidebar.TabIndex = 18;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(245, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 49);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(245, 51);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "    Employee";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(3, 106);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(245, 51);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "    Supplier";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnFinancial
            // 
            this.btnFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFinancial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinancial.FlatAppearance.BorderSize = 0;
            this.btnFinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancial.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancial.ForeColor = System.Drawing.Color.White;
            this.btnFinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancial.Image")));
            this.btnFinancial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinancial.Location = new System.Drawing.Point(3, 163);
            this.btnFinancial.Name = "btnFinancial";
            this.btnFinancial.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFinancial.Size = new System.Drawing.Size(245, 51);
            this.btnFinancial.TabIndex = 2;
            this.btnFinancial.Text = "    Financial";
            this.btnFinancial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinancial.UseVisualStyleBackColor = false;
            this.btnFinancial.Click += new System.EventHandler(this.btnFinancial_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 220);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(245, 51);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "    Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnScheduler
            // 
            this.btnScheduler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnScheduler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScheduler.FlatAppearance.BorderSize = 0;
            this.btnScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduler.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduler.ForeColor = System.Drawing.Color.White;
            this.btnScheduler.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduler.Image")));
            this.btnScheduler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduler.Location = new System.Drawing.Point(3, 277);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnScheduler.Size = new System.Drawing.Size(245, 51);
            this.btnScheduler.TabIndex = 2;
            this.btnScheduler.Text = "    Schedule";
            this.btnScheduler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduler.UseVisualStyleBackColor = false;
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(3, 334);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(245, 51);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "    Help ?";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(245, 51);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "    Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Occupation);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.emp_name);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnmenu);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 79);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1231, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // Occupation
            // 
            this.Occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupation.Location = new System.Drawing.Point(1303, 40);
            this.Occupation.Name = "Occupation";
            this.Occupation.Size = new System.Drawing.Size(162, 27);
            this.Occupation.TabIndex = 107;
            this.Occupation.Text = "Administrator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(388, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 48);
            this.panel1.TabIndex = 7;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(682, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnsearch.Size = new System.Drawing.Size(41, 41);
            this.btnsearch.TabIndex = 106;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(642, 32);
            this.textBox1.TabIndex = 5;
            // 
            // emp_name
            // 
            this.emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.Location = new System.Drawing.Point(1303, 14);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(290, 27);
            this.emp_name.TabIndex = 108;
            this.emp_name.Text = "Full Name of Employee";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Stock Manager"});
            this.comboBox1.Location = new System.Drawing.Point(1642, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Working Space";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(69, 7);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(288, 60);
            this.button10.TabIndex = 2;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // AdministratorDashborad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.AdministratorDashPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.Name = "AdministratorDashborad";
            this.Text = "Administrator_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AministratorDashborad_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.AdministratorDashPanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Timer mainCon2;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.LinkLabel fb_link;
        private System.Windows.Forms.Panel AdministratorDashPanel;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnFinancial;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Occupation;
        private System.Windows.Forms.Label emp_name;
    }
}