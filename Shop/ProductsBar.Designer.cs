
namespace Shop
{
    partial class ProductsBar
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
            this.ItemType_box = new System.Windows.Forms.ComboBox();
            this.ItemCode_box = new System.Windows.Forms.TextBox();
            this.Desc_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.price_box = new System.Windows.Forms.TextBox();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.Back_to_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 24);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // ItemType_box
            // 
            this.ItemType_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemType_box.FormattingEnabled = true;
            this.ItemType_box.Items.AddRange(new object[] {
            "Food",
            "Electronics",
            "Office supplies"});
            this.ItemType_box.Location = new System.Drawing.Point(240, 53);
            this.ItemType_box.Name = "ItemType_box";
            this.ItemType_box.Size = new System.Drawing.Size(51, 21);
            this.ItemType_box.TabIndex = 7;
            // 
            // ItemCode_box
            // 
            this.ItemCode_box.Location = new System.Drawing.Point(25, 54);
            this.ItemCode_box.Multiline = true;
            this.ItemCode_box.Name = "ItemCode_box";
            this.ItemCode_box.Size = new System.Drawing.Size(52, 20);
            this.ItemCode_box.TabIndex = 8;
            this.ItemCode_box.TextChanged += new System.EventHandler(this.ItemCode_box_TextChanged);
            // 
            // Desc_box
            // 
            this.Desc_box.Location = new System.Drawing.Point(117, 55);
            this.Desc_box.Multiline = true;
            this.Desc_box.Name = "Desc_box";
            this.Desc_box.Size = new System.Drawing.Size(84, 20);
            this.Desc_box.TabIndex = 9;
            // 
            // cost_box
            // 
            this.cost_box.Location = new System.Drawing.Point(343, 55);
            this.cost_box.Multiline = true;
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(52, 20);
            this.cost_box.TabIndex = 10;
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(427, 55);
            this.price_box.Multiline = true;
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(52, 20);
            this.price_box.TabIndex = 11;
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(514, 53);
            this.quantity_box.Multiline = true;
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(52, 20);
            this.quantity_box.TabIndex = 12;
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.BackColor = System.Drawing.SystemColors.Control;
            this.AddItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Button.Location = new System.Drawing.Point(514, 126);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(75, 23);
            this.AddItem_Button.TabIndex = 13;
            this.AddItem_Button.Text = "Add Item";
            this.AddItem_Button.UseVisualStyleBackColor = true;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // Back_to_Menu
            // 
            this.Back_to_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_to_Menu.Location = new System.Drawing.Point(25, 125);
            this.Back_to_Menu.Name = "Back_to_Menu";
            this.Back_to_Menu.Size = new System.Drawing.Size(75, 23);
            this.Back_to_Menu.TabIndex = 14;
            this.Back_to_Menu.Text = "Menu";
            this.Back_to_Menu.UseVisualStyleBackColor = true;
            this.Back_to_Menu.Click += new System.EventHandler(this.Back_to_Menu_Click);
            // 
            // ProductsBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 491);
            this.Controls.Add(this.Back_to_Menu);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.quantity_box);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.cost_box);
            this.Controls.Add(this.Desc_box);
            this.Controls.Add(this.ItemCode_box);
            this.Controls.Add(this.ItemType_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsBar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Products";
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
        private System.Windows.Forms.ComboBox ItemType_box;
        private System.Windows.Forms.TextBox ItemCode_box;
        private System.Windows.Forms.TextBox Desc_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.Button Back_to_Menu;
    }
}

