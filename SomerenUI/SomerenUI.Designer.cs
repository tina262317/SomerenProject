﻿namespace SomerenUI
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
            DrinksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            btnDeleteStudent = new System.Windows.Forms.Button();
            btnEditStudent = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            studentNumber = new System.Windows.Forms.ColumnHeader();
            studentRoom = new System.Windows.Forms.ColumnHeader();
            firstName = new System.Windows.Forms.ColumnHeader();
            lastName = new System.Windows.Forms.ColumnHeader();
            telephone = new System.Windows.Forms.ColumnHeader();
            studentClass = new System.Windows.Forms.ColumnHeader();
            lblStudents = new System.Windows.Forms.Label();
            pnlDrinks = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            nameDrinks = new System.Windows.Forms.ColumnHeader();
            typeDrinks = new System.Windows.Forms.ColumnHeader();
            priceDrink = new System.Windows.Forms.ColumnHeader();
            stockAmount = new System.Windows.Forms.ColumnHeader();
            stockStatusDrink = new System.Windows.Forms.ColumnHeader();
            labelDrinks = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            roomNumber = new System.Windows.Forms.ColumnHeader();
            numberOfBeds = new System.Windows.Forms.ColumnHeader();
            type = new System.Windows.Forms.ColumnHeader();
            lblRoom = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, DrinksMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1649, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(232, 40);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(232, 40);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // DrinksMenuItem
            // 
            DrinksMenuItem.Name = "DrinksMenuItem";
            DrinksMenuItem.Size = new System.Drawing.Size(89, 34);
            DrinksMenuItem.Text = "Drinks";
            DrinksMenuItem.Click += toolStripMenuItem1_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 43);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1608, 932);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(22, 24);
            lblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(365, 30);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(btnDeleteStudent);
            pnlStudents.Controls.Add(btnEditStudent);
            pnlStudents.Controls.Add(btnAdd);
            pnlStudents.Controls.Add(pictureBox4);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(lblStudents);
            pnlStudents.Location = new System.Drawing.Point(16, 43);
            pnlStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1608, 932);
            pnlStudents.TabIndex = 6;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeleteStudent.Location = new System.Drawing.Point(522, 767);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new System.Drawing.Size(167, 69);
            btnDeleteStudent.TabIndex = 5;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEditStudent.Location = new System.Drawing.Point(272, 767);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new System.Drawing.Size(167, 69);
            btnEditStudent.TabIndex = 4;
            btnEditStudent.Text = "Edit";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(27, 767);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(167, 69);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1380, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(223, 246);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.AutoArrange = false;
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { studentNumber, studentRoom, firstName, lastName, telephone, studentClass });
            listViewStudents.FullRowSelect = true;
            listViewStudents.Location = new System.Drawing.Point(27, 84);
            listViewStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewStudents.MultiSelect = false;
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1310, 610);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentNumber
            // 
            studentNumber.Text = "Student Number";
            studentNumber.Width = 170;
            // 
            // studentRoom
            // 
            studentRoom.Text = "Room Number";
            studentRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            studentRoom.Width = 150;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            firstName.Width = 120;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lastName.Width = 150;
            // 
            // telephone
            // 
            telephone.Text = "Telephone";
            telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            telephone.Width = 120;
            // 
            // studentClass
            // 
            studentClass.Text = "Class";
            studentClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudents.Location = new System.Drawing.Point(22, 14);
            lblStudents.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new System.Drawing.Size(187, 57);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "Students";
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(btnDelete);
            pnlDrinks.Controls.Add(btnEdit);
            pnlDrinks.Controls.Add(btnCreate);
            pnlDrinks.Controls.Add(pictureBox3);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(labelDrinks);
            pnlDrinks.Location = new System.Drawing.Point(16, 43);
            pnlDrinks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1608, 932);
            pnlDrinks.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(522, 767);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(167, 69);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(272, 767);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(167, 69);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(27, 767);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(167, 69);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1380, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(223, 246);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.AutoArrange = false;
            listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { nameDrinks, typeDrinks, priceDrink, stockAmount, stockStatusDrink });
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.Location = new System.Drawing.Point(27, 84);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewDrinks.MultiSelect = false;
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(1310, 610);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // nameDrinks
            // 
            nameDrinks.Text = "Name";
            nameDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nameDrinks.Width = 160;
            // 
            // typeDrinks
            // 
            typeDrinks.Text = "Alcoholic";
            typeDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            typeDrinks.Width = 120;
            // 
            // priceDrink
            // 
            priceDrink.Text = "Price";
            priceDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            priceDrink.Width = 80;
            // 
            // stockAmount
            // 
            stockAmount.Text = "Stock Amount";
            stockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            stockAmount.Width = 150;
            // 
            // stockStatusDrink
            // 
            stockStatusDrink.Text = "Stock Status";
            stockStatusDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            stockStatusDrink.Width = 200;
            // 
            // labelDrinks
            // 
            labelDrinks.AutoSize = true;
            labelDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDrinks.Location = new System.Drawing.Point(22, 14);
            labelDrinks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelDrinks.Name = "labelDrinks";
            labelDrinks.Size = new System.Drawing.Size(142, 57);
            labelDrinks.TabIndex = 0;
            labelDrinks.Text = "Drinks";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox2);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(lblRoom);
            pnlRooms.Location = new System.Drawing.Point(14, 43);
            pnlRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1608, 932);
            pnlRooms.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1380, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(223, 246);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { roomNumber, numberOfBeds, type });
            listViewRooms.Location = new System.Drawing.Point(27, 84);
            listViewRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1310, 610);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomNumber
            // 
            roomNumber.Text = "Room Number";
            roomNumber.Width = 150;
            // 
            // numberOfBeds
            // 
            numberOfBeds.Text = "Number of Beds";
            numberOfBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numberOfBeds.Width = 180;
            // 
            // type
            // 
            type.Text = "Type";
            type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            type.Width = 100;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRoom.Location = new System.Drawing.Point(22, 14);
            lblRoom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new System.Drawing.Size(153, 57);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Rooms";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1380, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(223, 246);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 0;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1649, 1010);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlStudents);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ColumnHeader roomNumber;
        private System.Windows.Forms.ColumnHeader numberOfBeds;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ToolStripMenuItem DrinksMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.ColumnHeader nameDrinks;
        private System.Windows.Forms.ColumnHeader typeDrinks;
        private System.Windows.Forms.ColumnHeader priceDrink;
        private System.Windows.Forms.ColumnHeader stockStatusDrink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ColumnHeader stockAmount;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentNumber;
        private System.Windows.Forms.ColumnHeader studentRoom;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ColumnHeader studentClass;
    }
}