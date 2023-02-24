
namespace Shop
{
    partial class MenuBar
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
            this.to_products = new System.Windows.Forms.Button();
            this.to_Customers = new System.Windows.Forms.Button();
            this.to_SalesOrders = new System.Windows.Forms.Button();
            this.to_DailyTotals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_products
            // 
            this.to_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_products.Location = new System.Drawing.Point(85, 28);
            this.to_products.Name = "to_products";
            this.to_products.Size = new System.Drawing.Size(75, 23);
            this.to_products.TabIndex = 0;
            this.to_products.Text = "Products";
            this.to_products.UseVisualStyleBackColor = true;
            this.to_products.Click += new System.EventHandler(this.to_products_Click);
            // 
            // to_Customers
            // 
            this.to_Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_Customers.Location = new System.Drawing.Point(85, 79);
            this.to_Customers.Name = "to_Customers";
            this.to_Customers.Size = new System.Drawing.Size(75, 23);
            this.to_Customers.TabIndex = 1;
            this.to_Customers.Text = "Customers";
            this.to_Customers.UseVisualStyleBackColor = true;
            this.to_Customers.Click += new System.EventHandler(this.to_Customers_Click);
            // 
            // to_SalesOrders
            // 
            this.to_SalesOrders.Location = new System.Drawing.Point(85, 129);
            this.to_SalesOrders.Name = "to_SalesOrders";
            this.to_SalesOrders.Size = new System.Drawing.Size(75, 23);
            this.to_SalesOrders.TabIndex = 2;
            this.to_SalesOrders.Text = "Sales Orders";
            this.to_SalesOrders.UseVisualStyleBackColor = true;
            this.to_SalesOrders.Click += new System.EventHandler(this.SalesOrders_Click);
            // 
            // to_DailyTotals
            // 
            this.to_DailyTotals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_DailyTotals.Location = new System.Drawing.Point(85, 179);
            this.to_DailyTotals.Name = "to_DailyTotals";
            this.to_DailyTotals.Size = new System.Drawing.Size(75, 23);
            this.to_DailyTotals.TabIndex = 3;
            this.to_DailyTotals.Text = "Daily Totals";
            this.to_DailyTotals.UseVisualStyleBackColor = true;
            this.to_DailyTotals.Click += new System.EventHandler(this.to_DailyTotals_Click);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 251);
            this.Controls.Add(this.to_DailyTotals);
            this.Controls.Add(this.to_SalesOrders);
            this.Controls.Add(this.to_Customers);
            this.Controls.Add(this.to_products);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuBar";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button to_products;
        private System.Windows.Forms.Button to_Customers;
        private System.Windows.Forms.Button to_SalesOrders;
        private System.Windows.Forms.Button to_DailyTotals;
    }
}