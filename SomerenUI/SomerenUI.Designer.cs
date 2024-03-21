namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBoxStudents = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            StudentNumber = new System.Windows.Forms.ColumnHeader();
            StudentName = new System.Windows.Forms.ColumnHeader();
            Class = new System.Windows.Forms.ColumnHeader();
            PhoneNumber = new System.Windows.Forms.ColumnHeader();
            lblStudents = new System.Windows.Forms.Label();
            pnlDrinks = new System.Windows.Forms.Panel();
            btnEditDrinks = new System.Windows.Forms.Button();
            pictureBoxDrinks = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            DrinkName = new System.Windows.Forms.ColumnHeader();
            Stock = new System.Windows.Forms.ColumnHeader();
            StockStatus = new System.Windows.Forms.ColumnHeader();
            Price = new System.Windows.Forms.ColumnHeader();
            Alcoholic = new System.Windows.Forms.ColumnHeader();
            VAT = new System.Windows.Forms.ColumnHeader();
            Sales = new System.Windows.Forms.ColumnHeader();
            lblDrinks = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudents).BeginInit();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrinks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1099, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            drinksToolStripMenuItem.Text = "Drinks Supplies";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBoxStudents);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(lblStudents);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBoxStudents
            // 
            pictureBoxStudents.Image = (System.Drawing.Image)resources.GetObject("pictureBoxStudents.Image");
            pictureBoxStudents.Location = new System.Drawing.Point(920, 0);
            pictureBoxStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxStudents.Name = "pictureBoxStudents";
            pictureBoxStudents.Size = new System.Drawing.Size(149, 164);
            pictureBoxStudents.TabIndex = 2;
            pictureBoxStudents.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StudentNumber, StudentName, Class, PhoneNumber });
            listViewStudents.FullRowSelect = true;
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // StudentNumber
            // 
            StudentNumber.Text = "Student Number";
            StudentNumber.Width = 200;
            // 
            // StudentName
            // 
            StudentName.Text = "Name";
            StudentName.Width = 150;
            // 
            // Class
            // 
            Class.Text = "Class";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Width = 150;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudents.Location = new System.Drawing.Point(15, 9);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new System.Drawing.Size(134, 41);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "Students";
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(btnEditDrinks);
            pnlDrinks.Controls.Add(pictureBoxDrinks);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(lblDrinks);
            pnlDrinks.Location = new System.Drawing.Point(14, 36);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1072, 621);
            pnlDrinks.TabIndex = 3;
            // 
            // btnEditDrinks
            // 
            btnEditDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEditDrinks.Location = new System.Drawing.Point(18, 493);
            btnEditDrinks.Name = "btnEditDrinks";
            btnEditDrinks.Size = new System.Drawing.Size(147, 106);
            btnEditDrinks.TabIndex = 3;
            btnEditDrinks.Text = "Edit Drinks";
            btnEditDrinks.UseVisualStyleBackColor = true;
            btnEditDrinks.Click += btnEditDrinks_Click;
            // 
            // pictureBoxDrinks
            // 
            pictureBoxDrinks.Image = (System.Drawing.Image)resources.GetObject("pictureBoxDrinks.Image");
            pictureBoxDrinks.Location = new System.Drawing.Point(920, 0);
            pictureBoxDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBoxDrinks.Name = "pictureBoxDrinks";
            pictureBoxDrinks.Size = new System.Drawing.Size(149, 164);
            pictureBoxDrinks.TabIndex = 2;
            pictureBoxDrinks.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { DrinkName, Stock, StockStatus, Price, Alcoholic, VAT, Sales });
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.Location = new System.Drawing.Point(18, 56);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(875, 408);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // DrinkName
            // 
            DrinkName.Text = "Name";
            DrinkName.Width = 150;
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            Stock.Width = 120;
            // 
            // StockStatus
            // 
            StockStatus.Text = "Stock Status";
            StockStatus.Width = 170;
            // 
            // Price
            // 
            Price.Text = "Price";
            // 
            // Alcoholic
            // 
            Alcoholic.Text = "Alcoholic";
            Alcoholic.Width = 150;
            // 
            // VAT
            // 
            VAT.Text = "VAT";
            VAT.Width = 120;
            // 
            // Sales
            // 
            Sales.Text = "Sales";
            Sales.Width = 100;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDrinks.Location = new System.Drawing.Point(15, 9);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new System.Drawing.Size(101, 41);
            lblDrinks.TabIndex = 0;
            lblDrinks.Text = "Drinks";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudents).EndInit();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrinks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader StudentNumber;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox pictureBoxDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader DrinkName;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Alcoholic;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.ColumnHeader StockStatus;
        private System.Windows.Forms.Button btnEditDrinks;
        private System.Windows.Forms.ColumnHeader Sales;
    }
}