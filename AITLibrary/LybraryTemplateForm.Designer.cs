namespace AITLibrary
{
    partial class LybraryTemplateForm
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
            this.menuStripSystemLybrary = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.myActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultCancelReserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedReservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSystemMessage = new System.Windows.Forms.Label();
            this.menuStripSystemLybrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSystemLybrary
            // 
            this.menuStripSystemLybrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStripSystemLybrary.Location = new System.Drawing.Point(0, 0);
            this.menuStripSystemLybrary.Name = "menuStripSystemLybrary";
            this.menuStripSystemLybrary.Size = new System.Drawing.Size(1084, 24);
            this.menuStripSystemLybrary.TabIndex = 1;
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUserDetails,
            this.myActivitiesToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.userToolStripMenuItem.Text = "My Details";
            // 
            // toolStripMenuItemUserDetails
            // 
            this.toolStripMenuItemUserDetails.Name = "toolStripMenuItemUserDetails";
            this.toolStripMenuItemUserDetails.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemUserDetails.Text = "User Details";
            this.toolStripMenuItemUserDetails.Click += new System.EventHandler(this.toolStripMenuItemUserDetails_Click);
            // 
            // myActivitiesToolStripMenuItem
            // 
            this.myActivitiesToolStripMenuItem.Name = "myActivitiesToolStripMenuItem";
            this.myActivitiesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.myActivitiesToolStripMenuItem.Text = "My Activity";
            this.myActivitiesToolStripMenuItem.Click += new System.EventHandler(this.myActivitiesToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.logOffToolStripMenuItem.Text = "Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.browseToolStripMenuItem,
            this.reserveToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewBorrowedReservedToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem1,
            this.returnToolStripMenuItem});
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            // 
            // borrowToolStripMenuItem1
            // 
            this.borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            this.borrowToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.borrowToolStripMenuItem1.Text = "Borrow";
            this.borrowToolStripMenuItem1.Click += new System.EventHandler(this.borrowToolStripMenuItem1_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveABookToolStripMenuItem,
            this.consultCancelReserveToolStripMenuItem});
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reserveToolStripMenuItem.Text = "Reserve";
            // 
            // reserveABookToolStripMenuItem
            // 
            this.reserveABookToolStripMenuItem.Name = "reserveABookToolStripMenuItem";
            this.reserveABookToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reserveABookToolStripMenuItem.Text = "Reserve a book";
            this.reserveABookToolStripMenuItem.Click += new System.EventHandler(this.reserveABookToolStripMenuItem_Click);
            // 
            // consultCancelReserveToolStripMenuItem
            // 
            this.consultCancelReserveToolStripMenuItem.Name = "consultCancelReserveToolStripMenuItem";
            this.consultCancelReserveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultCancelReserveToolStripMenuItem.Text = "Consult/Cancel reserve";
            this.consultCancelReserveToolStripMenuItem.Click += new System.EventHandler(this.consultCancelReserveToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // viewBorrowedReservedToolStripMenuItem
            // 
            this.viewBorrowedReservedToolStripMenuItem.Name = "viewBorrowedReservedToolStripMenuItem";
            this.viewBorrowedReservedToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.viewBorrowedReservedToolStripMenuItem.Text = "View Borrowed/Reserved";
            this.viewBorrowedReservedToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowedReservedToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.informationMaintenanceToolStripMenuItem,
            this.userMaintenanceToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.administrationToolStripMenuItem.Text = "System Management";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.bookToolStripMenuItem1.Text = "Books";
            this.bookToolStripMenuItem1.Click += new System.EventHandler(this.bookToolStripMenuItem1_Click);
            // 
            // informationMaintenanceToolStripMenuItem
            // 
            this.informationMaintenanceToolStripMenuItem.Name = "informationMaintenanceToolStripMenuItem";
            this.informationMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informationMaintenanceToolStripMenuItem.Text = "Master Information Domain";
            this.informationMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.informationMaintenanceToolStripMenuItem_Click);
            // 
            // userMaintenanceToolStripMenuItem
            // 
            this.userMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.listToolStripMenuItem});
            this.userMaintenanceToolStripMenuItem.Name = "userMaintenanceToolStripMenuItem";
            this.userMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.userMaintenanceToolStripMenuItem.Text = "Users";
            this.userMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.userMaintenanceToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookBorrowedToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bookBorrowedToolStripMenuItem
            // 
            this.bookBorrowedToolStripMenuItem.Name = "bookBorrowedToolStripMenuItem";
            this.bookBorrowedToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bookBorrowedToolStripMenuItem.Text = "Book Borrowed";
            this.bookBorrowedToolStripMenuItem.Click += new System.EventHandler(this.bookBorrowedToolStripMenuItem_Click);
            // 
            // labelSystemMessage
            // 
            this.labelSystemMessage.AutoSize = true;
            this.labelSystemMessage.Location = new System.Drawing.Point(13, 586);
            this.labelSystemMessage.Name = "labelSystemMessage";
            this.labelSystemMessage.Size = new System.Drawing.Size(22, 13);
            this.labelSystemMessage.TabIndex = 2;
            this.labelSystemMessage.Text = "[...]";
            // 
            // LybraryTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.labelSystemMessage);
            this.Controls.Add(this.menuStripSystemLybrary);
            this.Name = "LybraryTemplateForm";
            this.Text = "LybraryTemplateForm";
            this.Load += new System.EventHandler(this.LybraryTemplateForm_Load);
            this.menuStripSystemLybrary.ResumeLayout(false);
            this.menuStripSystemLybrary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSystemLybrary;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUserDetails;
        private System.Windows.Forms.ToolStripMenuItem myActivitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultCancelReserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedReservedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informationMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowedToolStripMenuItem;
        public System.Windows.Forms.Label labelSystemMessage;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    }
}