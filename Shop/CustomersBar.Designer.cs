
namespace Shop.Models
{
    partial class CustomersBar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerName_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.address1_box = new System.Windows.Forms.TextBox();
            this.address2_box = new System.Windows.Forms.TextBox();
            this.Status_box = new System.Windows.Forms.ComboBox();
            this.CreditLimit_box = new System.Windows.Forms.TextBox();
            this.Customer_reg_button = new System.Windows.Forms.Button();
            this.Back_To_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Credit Limit";
            // 
            // CustomerName_box
            // 
            this.CustomerName_box.Location = new System.Drawing.Point(12, 44);
            this.CustomerName_box.Name = "CustomerName_box";
            this.CustomerName_box.Size = new System.Drawing.Size(76, 20);
            this.CustomerName_box.TabIndex = 6;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(103, 44);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(87, 20);
            this.phone_box.TabIndex = 7;
            // 
            // address1_box
            // 
            this.address1_box.Location = new System.Drawing.Point(196, 44);
            this.address1_box.Name = "address1_box";
            this.address1_box.Size = new System.Drawing.Size(103, 20);
            this.address1_box.TabIndex = 8;
            // 
            // address2_box
            // 
            this.address2_box.Location = new System.Drawing.Point(305, 44);
            this.address2_box.Name = "address2_box";
            this.address2_box.Size = new System.Drawing.Size(87, 20);
            this.address2_box.TabIndex = 9;
            // 
            // Status_box
            // 
            this.Status_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Status_box.FormattingEnabled = true;
            this.Status_box.Items.AddRange(new object[] {
            "Active",
            "Credit Hold",
            "Inactive"});
            this.Status_box.Location = new System.Drawing.Point(414, 42);
            this.Status_box.Name = "Status_box";
            this.Status_box.Size = new System.Drawing.Size(66, 21);
            this.Status_box.TabIndex = 11;
            // 
            // CreditLimit_box
            // 
            this.CreditLimit_box.Location = new System.Drawing.Point(503, 44);
            this.CreditLimit_box.Name = "CreditLimit_box";
            this.CreditLimit_box.Size = new System.Drawing.Size(55, 20);
            this.CreditLimit_box.TabIndex = 12;
            // 
            // Customer_reg_button
            // 
            this.Customer_reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer_reg_button.Location = new System.Drawing.Point(483, 111);
            this.Customer_reg_button.Name = "Customer_reg_button";
            this.Customer_reg_button.Size = new System.Drawing.Size(75, 23);
            this.Customer_reg_button.TabIndex = 13;
            this.Customer_reg_button.Text = "Register";
            this.Customer_reg_button.UseVisualStyleBackColor = true;
            this.Customer_reg_button.Click += new System.EventHandler(this.Customer_reg_button_Click);
            // 
            // Back_To_Menu
            // 
            this.Back_To_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_To_Menu.Location = new System.Drawing.Point(15, 110);
            this.Back_To_Menu.Name = "Back_To_Menu";
            this.Back_To_Menu.Size = new System.Drawing.Size(75, 23);
            this.Back_To_Menu.TabIndex = 14;
            this.Back_To_Menu.Text = "To Menu";
            this.Back_To_Menu.UseVisualStyleBackColor = true;
            this.Back_To_Menu.Click += new System.EventHandler(this.Back_To_Menu_Click);
            // 
            // CustomersBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 464);
            this.Controls.Add(this.Back_To_Menu);
            this.Controls.Add(this.Customer_reg_button);
            this.Controls.Add(this.CreditLimit_box);
            this.Controls.Add(this.Status_box);
            this.Controls.Add(this.address2_box);
            this.Controls.Add(this.address1_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.CustomerName_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersBar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerName_box;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.TextBox address1_box;
        private System.Windows.Forms.TextBox address2_box;
        private System.Windows.Forms.ComboBox Status_box;
        private System.Windows.Forms.TextBox CreditLimit_box;
        private System.Windows.Forms.Button Customer_reg_button;
        private System.Windows.Forms.Button Back_To_Menu;
    }
}