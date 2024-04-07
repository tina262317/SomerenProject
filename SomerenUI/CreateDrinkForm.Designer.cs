namespace SomerenUI
{
    partial class CreateDrinkForm
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
            lblName = new System.Windows.Forms.Label();
            lblAlcoholic = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxStock = new System.Windows.Forms.TextBox();
            rdoYes = new System.Windows.Forms.RadioButton();
            rdoNo = new System.Windows.Forms.RadioButton();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(67, 69);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(74, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblAlcoholic
            // 
            lblAlcoholic.AutoSize = true;
            lblAlcoholic.Location = new System.Drawing.Point(67, 136);
            lblAlcoholic.Name = "lblAlcoholic";
            lblAlcoholic.Size = new System.Drawing.Size(103, 30);
            lblAlcoholic.TabIndex = 1;
            lblAlcoholic.Text = "Alcoholic:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(67, 204);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(158, 30);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price (e.g. 1.99):";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(67, 272);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(67, 30);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(195, 69);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(175, 35);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(231, 204);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(139, 35);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new System.Drawing.Point(195, 272);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new System.Drawing.Size(175, 35);
            textBoxStock.TabIndex = 6;
            // 
            // rdoYes
            // 
            rdoYes.AutoSize = true;
            rdoYes.Checked = true;
            rdoYes.Location = new System.Drawing.Point(195, 136);
            rdoYes.Name = "rdoYes";
            rdoYes.Size = new System.Drawing.Size(68, 34);
            rdoYes.TabIndex = 7;
            rdoYes.TabStop = true;
            rdoYes.Text = "Yes";
            rdoYes.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            rdoNo.AutoSize = true;
            rdoNo.Location = new System.Drawing.Point(304, 136);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new System.Drawing.Size(66, 34);
            rdoNo.TabIndex = 8;
            rdoNo.Text = "No";
            rdoNo.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreate.Location = new System.Drawing.Point(139, 367);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(142, 47);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(139, 367);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(142, 47);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // CreateDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(444, 469);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(rdoNo);
            Controls.Add(rdoYes);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblAlcoholic);
            Controls.Add(lblName);
            Name = "CreateDrinkForm";
            Text = "CreateDrinkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlcoholic;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
    }
}