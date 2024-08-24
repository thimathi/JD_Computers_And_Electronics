namespace JD_Electronics_Application
{
    partial class Manager_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Dashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.btnRegistor = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCusStetus = new System.Windows.Forms.Button();
            this.btnfinancial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.mainCon2 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.ManagerDashPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.fb_link = new System.Windows.Forms.LinkLabel();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ManagerDashPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.btnfinancial);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.btnEmployee);
            this.sidebar.Controls.Add(this.btnSupplier);
            this.sidebar.Controls.Add(this.btnWorkers);
            this.sidebar.Controls.Add(this.btnSchedule);
            this.sidebar.Controls.Add(this.btnReport);
            this.sidebar.Controls.Add(this.btnHelp);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 79);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(246, 930);
            this.sidebar.TabIndex = 14;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
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
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.Controls.Add(this.btnRegistor);
            this.menuContainer.Controls.Add(this.btnManage);
            this.menuContainer.Controls.Add(this.button4);
            this.menuContainer.Controls.Add(this.btnCusStetus);
            this.menuContainer.Location = new System.Drawing.Point(3, 49);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(250, 49);
            this.menuContainer.TabIndex = 13;
            // 
            // btnRegistor
            // 
            this.btnRegistor.FlatAppearance.BorderSize = 0;
            this.btnRegistor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistor.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistor.ForeColor = System.Drawing.Color.White;
            this.btnRegistor.Location = new System.Drawing.Point(0, 46);
            this.btnRegistor.Name = "btnRegistor";
            this.btnRegistor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistor.Size = new System.Drawing.Size(246, 41);
            this.btnRegistor.TabIndex = 8;
            this.btnRegistor.Text = "Registration";
            this.btnRegistor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistor.UseVisualStyleBackColor = true;
            this.btnRegistor.Click += new System.EventHandler(this.btnRegistor_Click);
            // 
            // btnManage
            // 
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(0, 87);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManage.Size = new System.Drawing.Size(256, 44);
            this.btnManage.TabIndex = 9;
            this.btnManage.Text = "Manage";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, 4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(245, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "    User Account";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCusStetus
            // 
            this.btnCusStetus.FlatAppearance.BorderSize = 0;
            this.btnCusStetus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusStetus.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusStetus.ForeColor = System.Drawing.Color.White;
            this.btnCusStetus.Location = new System.Drawing.Point(3, 132);
            this.btnCusStetus.Name = "btnCusStetus";
            this.btnCusStetus.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCusStetus.Size = new System.Drawing.Size(246, 41);
            this.btnCusStetus.TabIndex = 10;
            this.btnCusStetus.Text = "Status";
            this.btnCusStetus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusStetus.UseVisualStyleBackColor = true;
            this.btnCusStetus.Click += new System.EventHandler(this.btnCusStetus_Click);
            // 
            // btnfinancial
            // 
            this.btnfinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnfinancial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfinancial.FlatAppearance.BorderSize = 0;
            this.btnfinancial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinancial.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinancial.ForeColor = System.Drawing.Color.White;
            this.btnfinancial.Image = ((System.Drawing.Image)(resources.GetObject("btnfinancial.Image")));
            this.btnfinancial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfinancial.Location = new System.Drawing.Point(3, 104);
            this.btnfinancial.Name = "btnfinancial";
            this.btnfinancial.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnfinancial.Size = new System.Drawing.Size(245, 51);
            this.btnfinancial.TabIndex = 2;
            this.btnfinancial.Text = "    Financial";
            this.btnfinancial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfinancial.UseVisualStyleBackColor = false;
            this.btnfinancial.Click += new System.EventHandler(this.btnfinancial_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 161);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(245, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "    Stock";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnEmployee.Location = new System.Drawing.Point(3, 218);
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
            this.btnSupplier.Location = new System.Drawing.Point(3, 275);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(245, 51);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "    Supplier";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkers.ForeColor = System.Drawing.Color.White;
            this.btnWorkers.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkers.Image")));
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(3, 332);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnWorkers.Size = new System.Drawing.Size(245, 51);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "    Workers";
            this.btnWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkers.UseVisualStyleBackColor = false;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(3, 389);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(245, 51);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "    Schedule";
            this.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
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
            this.btnReport.Location = new System.Drawing.Point(3, 446);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(245, 51);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "    Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.btnHelp.Location = new System.Drawing.Point(3, 503);
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
            this.btnLogout.Location = new System.Drawing.Point(3, 560);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(245, 51);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "    Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnmenu.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnmenu);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1826, 79);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1169, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1241, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manager";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1241, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name of Employee";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cashier",
            "Stock Manager"});
            this.comboBox1.Location = new System.Drawing.Point(1551, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Working Space";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(386, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 48);
            this.panel1.TabIndex = 4;
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
            this.textBox1.Size = new System.Drawing.Size(642, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
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
            this.button10.Click += new System.EventHandler(this.button5_Click);
            // 
            // mainCon2
            // 
            this.mainCon2.Interval = 10;
            this.mainCon2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick_1);
            // 
            // ManagerDashPanel
            // 
            this.ManagerDashPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManagerDashPanel.BackgroundImage")));
            this.ManagerDashPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManagerDashPanel.Controls.Add(this.panel5);
            this.ManagerDashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerDashPanel.Location = new System.Drawing.Point(246, 79);
            this.ManagerDashPanel.Name = "ManagerDashPanel";
            this.ManagerDashPanel.Size = new System.Drawing.Size(1580, 930);
            this.ManagerDashPanel.TabIndex = 15;
            this.ManagerDashPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManagerDashPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Controls.Add(this.lbl_footer);
            this.panel5.Controls.Add(this.fb_link);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 888);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1580, 42);
            this.panel5.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(1410, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 16);
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
            this.lbl_footer.Size = new System.Drawing.Size(225, 16);
            this.lbl_footer.TabIndex = 21;
            this.lbl_footer.Text = "Powered By 2MBS Software Solution";
            this.lbl_footer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fb_link
            // 
            this.fb_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fb_link.AutoSize = true;
            this.fb_link.Location = new System.Drawing.Point(1502, 13);
            this.fb_link.Name = "fb_link";
            this.fb_link.Size = new System.Drawing.Size(69, 16);
            this.fb_link.TabIndex = 22;
            this.fb_link.TabStop = true;
            this.fb_link.Text = "Facebook";
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1826, 1009);
            this.Controls.Add(this.ManagerDashPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.Name = "Manager_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ManagerDashPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Timer mainCon2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel ManagerDashPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.LinkLabel fb_link;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Button btnRegistor;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnCusStetus;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnfinancial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}