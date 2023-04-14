namespace GatePassGenerator
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVisitiorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validatePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.generatePassToolStripMenuItem,
            this.validatePassToolStripMenuItem,
            this.filterPassToolStripMenuItem,
            this.btnlogout,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1726, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.viewAllEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeToolStripMenuItem.Image")));
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(166, 64);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addEmployeeToolStripMenuItem.Image")));
            this.addEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(288, 66);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateEmployeeToolStripMenuItem.Image")));
            this.updateEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(288, 66);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // viewAllEmployeeToolStripMenuItem
            // 
            this.viewAllEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllEmployeeToolStripMenuItem.Image")));
            this.viewAllEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewAllEmployeeToolStripMenuItem.Name = "viewAllEmployeeToolStripMenuItem";
            this.viewAllEmployeeToolStripMenuItem.Size = new System.Drawing.Size(288, 66);
            this.viewAllEmployeeToolStripMenuItem.Text = "View All Employee";
            this.viewAllEmployeeToolStripMenuItem.Click += new System.EventHandler(this.viewAllEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployeeToolStripMenuItem.Image")));
            this.deleteEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(288, 66);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVisitiorToolStripMenuItem,
            this.viewVisitorToolStripMenuItem,
            this.updateVisitorToolStripMenuItem});
            this.visitorToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitorToolStripMenuItem.Image")));
            this.visitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(138, 64);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // addVisitiorToolStripMenuItem
            // 
            this.addVisitiorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addVisitiorToolStripMenuItem.Image")));
            this.addVisitiorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addVisitiorToolStripMenuItem.Name = "addVisitiorToolStripMenuItem";
            this.addVisitiorToolStripMenuItem.Size = new System.Drawing.Size(255, 66);
            this.addVisitiorToolStripMenuItem.Text = "Add Visitior";
            this.addVisitiorToolStripMenuItem.Click += new System.EventHandler(this.addVisitiorToolStripMenuItem_Click);
            // 
            // viewVisitorToolStripMenuItem
            // 
            this.viewVisitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewVisitorToolStripMenuItem.Image")));
            this.viewVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewVisitorToolStripMenuItem.Name = "viewVisitorToolStripMenuItem";
            this.viewVisitorToolStripMenuItem.Size = new System.Drawing.Size(255, 66);
            this.viewVisitorToolStripMenuItem.Text = "View Visitor";
            this.viewVisitorToolStripMenuItem.Click += new System.EventHandler(this.viewVisitorToolStripMenuItem_Click);
            // 
            // updateVisitorToolStripMenuItem
            // 
            this.updateVisitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateVisitorToolStripMenuItem.Image")));
            this.updateVisitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateVisitorToolStripMenuItem.Name = "updateVisitorToolStripMenuItem";
            this.updateVisitorToolStripMenuItem.Size = new System.Drawing.Size(255, 66);
            this.updateVisitorToolStripMenuItem.Text = "Update Visitor";
            this.updateVisitorToolStripMenuItem.Click += new System.EventHandler(this.updateVisitorToolStripMenuItem_Click);
            // 
            // generatePassToolStripMenuItem
            // 
            this.generatePassToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generatePassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generatePassToolStripMenuItem.Image")));
            this.generatePassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generatePassToolStripMenuItem.Name = "generatePassToolStripMenuItem";
            this.generatePassToolStripMenuItem.Size = new System.Drawing.Size(203, 64);
            this.generatePassToolStripMenuItem.Text = "Generate Pass";
            this.generatePassToolStripMenuItem.Click += new System.EventHandler(this.generatePassToolStripMenuItem_Click);
            // 
            // validatePassToolStripMenuItem
            // 
            this.validatePassToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.validatePassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatePassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validatePassToolStripMenuItem.Image")));
            this.validatePassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.validatePassToolStripMenuItem.Name = "validatePassToolStripMenuItem";
            this.validatePassToolStripMenuItem.Size = new System.Drawing.Size(193, 64);
            this.validatePassToolStripMenuItem.Text = "Validate Pass";
            this.validatePassToolStripMenuItem.Click += new System.EventHandler(this.validatePassToolStripMenuItem_Click);
            // 
            // filterPassToolStripMenuItem
            // 
            this.filterPassToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.filterPassToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPassToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filterPassToolStripMenuItem.Image")));
            this.filterPassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.filterPassToolStripMenuItem.Name = "filterPassToolStripMenuItem";
            this.filterPassToolStripMenuItem.Size = new System.Drawing.Size(168, 64);
            this.filterPassToolStripMenuItem.Text = "Filter Pass";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(141, 64);
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 64);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1726, 873);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVisitiorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validatePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnlogout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem updateVisitorToolStripMenuItem;
    }
}