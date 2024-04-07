namespace SomerenUI
{
    partial class AddEditStudentForm
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
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            textBoxStudentNumber = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            lblRoomNumber = new System.Windows.Forms.Label();
            lblStudentNumber = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblStudentClass = new System.Windows.Forms.Label();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxTelephone = new System.Windows.Forms.TextBox();
            textBoxClass = new System.Windows.Forms.TextBox();
            comboBoxRoom = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(155, 274);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(142, 47);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(154, 387);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(142, 47);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new System.Drawing.Point(248, 38);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(175, 35);
            textBoxFirstName.TabIndex = 17;
            // 
            // textBoxStudentNumber
            // 
            textBoxStudentNumber.Location = new System.Drawing.Point(248, 253);
            textBoxStudentNumber.Name = "textBoxStudentNumber";
            textBoxStudentNumber.Size = new System.Drawing.Size(175, 35);
            textBoxStudentNumber.TabIndex = 15;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(34, 43);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(118, 30);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "First Name:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new System.Drawing.Point(35, 312);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new System.Drawing.Size(154, 30);
            lblRoomNumber.TabIndex = 13;
            lblRoomNumber.Text = "Room Number:";
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Location = new System.Drawing.Point(34, 258);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new System.Drawing.Size(171, 30);
            lblStudentNumber.TabIndex = 11;
            lblStudentNumber.Text = "Student Number:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(35, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(117, 30);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Last Name:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(35, 146);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(113, 30);
            lblTelephone.TabIndex = 23;
            lblTelephone.Text = "Telephone:";
            // 
            // lblStudentClass
            // 
            lblStudentClass.AutoSize = true;
            lblStudentClass.Location = new System.Drawing.Point(35, 199);
            lblStudentClass.Name = "lblStudentClass";
            lblStudentClass.Size = new System.Drawing.Size(65, 30);
            lblStudentClass.TabIndex = 24;
            lblStudentClass.Text = "Class:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new System.Drawing.Point(248, 89);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(175, 35);
            textBoxLastName.TabIndex = 25;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Location = new System.Drawing.Point(248, 141);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new System.Drawing.Size(175, 35);
            textBoxTelephone.TabIndex = 26;
            // 
            // textBoxClass
            // 
            textBoxClass.Location = new System.Drawing.Point(248, 194);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new System.Drawing.Size(175, 35);
            textBoxClass.TabIndex = 27;
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new System.Drawing.Point(248, 304);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new System.Drawing.Size(175, 38);
            comboBoxRoom.TabIndex = 28;
            // 
            // AddEditStudentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(466, 481);
            Controls.Add(comboBoxRoom);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxTelephone);
            Controls.Add(textBoxLastName);
            Controls.Add(lblStudentClass);
            Controls.Add(lblTelephone);
            Controls.Add(lblLastName);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxStudentNumber);
            Controls.Add(lblFirstName);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblStudentNumber);
            Name = "AddEditStudentForm";
            Text = "AddEditStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.ComboBox comboBoxRoom;
    }
}