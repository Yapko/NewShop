namespace Shop.Views
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.usersListView = new System.Windows.Forms.ListView();
            this.usernameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.requestsListView = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.usersContextMenuStrip.SuspendLayout();
            this.requestsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.tabPage1);
            this.adminTabControl.Controls.Add(this.tabPage2);
            this.adminTabControl.Location = new System.Drawing.Point(18, 19);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(412, 413);
            this.adminTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.usersListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // usersListView
            // 
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameColumn,
            this.statusColumn});
            this.usersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersListView.FullRowSelect = true;
            this.usersListView.GridLines = true;
            this.usersListView.LabelEdit = true;
            this.usersListView.Location = new System.Drawing.Point(3, 3);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(398, 381);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            this.usersListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersListView_MouseClick);
            // 
            // usernameColumn
            // 
            this.usernameColumn.Text = "Username";
            this.usernameColumn.Width = 180;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            this.statusColumn.Width = 214;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.requestsListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Requests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // requestsListView
            // 
            this.requestsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader22,
            this.columnHeader32,
            this.columnHeader52});
            this.requestsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsListView.FullRowSelect = true;
            this.requestsListView.GridLines = true;
            this.requestsListView.LabelEdit = true;
            this.requestsListView.Location = new System.Drawing.Point(3, 3);
            this.requestsListView.Name = "requestsListView";
            this.requestsListView.Size = new System.Drawing.Size(398, 381);
            this.requestsListView.TabIndex = 1;
            this.requestsListView.UseCompatibleStateImageBehavior = false;
            this.requestsListView.View = System.Windows.Forms.View.Details;
            this.requestsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RequestsListView_MouseClick);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Username";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Email address";
            this.columnHeader22.Width = 100;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "First name";
            this.columnHeader32.Width = 100;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Last name";
            this.columnHeader52.Width = 100;
            // 
            // usersContextMenuStrip
            // 
            this.usersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeStatusToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.usersContextMenuStrip.Name = "contextMenuStrip1";
            this.usersContextMenuStrip.Size = new System.Drawing.Size(156, 48);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.loggedUserToolStripMenuItem});
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changeStatusToolStripMenuItem.Text = "Change status";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.ManagerToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            this.supervisorToolStripMenuItem.Click += new System.EventHandler(this.SupervisorToolStripMenuItem_Click);
            // 
            // loggedUserToolStripMenuItem
            // 
            this.loggedUserToolStripMenuItem.Name = "loggedUserToolStripMenuItem";
            this.loggedUserToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.loggedUserToolStripMenuItem.Text = "LoggedUser";
            this.loggedUserToolStripMenuItem.Click += new System.EventHandler(this.LoggedUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // requestsContextMenuStrip
            // 
            this.requestsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.requestsContextMenuStrip.Name = "contextMenuStrip2";
            this.requestsContextMenuStrip.Size = new System.Drawing.Size(119, 48);
            // 
            // acceptToolStripMenuItem
            // 
            this.acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            this.acceptToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.acceptToolStripMenuItem.Text = "Accept";
            this.acceptToolStripMenuItem.Click += new System.EventHandler(this.AcceptToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.RejectToolStripMenuItem_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminTabControl);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(448, 448);
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.adminTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.usersContextMenuStrip.ResumeLayout(false);
            this.requestsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.ColumnHeader usernameColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ContextMenuStrip usersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip requestsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem acceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.ListView requestsListView;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader52;
    }
}
