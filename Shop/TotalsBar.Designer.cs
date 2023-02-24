
namespace Shop
{
    partial class TotalsBar
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
            this.TotalAmt_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Select_Code = new System.Windows.Forms.ComboBox();
            this.TotalQuantity_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mostSold_Code_Box = new System.Windows.Forms.TextBox();
            this.mostSold_Desc_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amount";
            // 
            // TotalAmt_Box
            // 
            this.TotalAmt_Box.Location = new System.Drawing.Point(145, 32);
            this.TotalAmt_Box.Name = "TotalAmt_Box";
            this.TotalAmt_Box.Size = new System.Drawing.Size(68, 20);
            this.TotalAmt_Box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Quantity By Code";
            // 
            // Select_Code
            // 
            this.Select_Code.FormattingEnabled = true;
            this.Select_Code.Location = new System.Drawing.Point(145, 78);
            this.Select_Code.Name = "Select_Code";
            this.Select_Code.Size = new System.Drawing.Size(58, 21);
            this.Select_Code.TabIndex = 3;
            // 
            // TotalQuantity_Box
            // 
            this.TotalQuantity_Box.Location = new System.Drawing.Point(225, 78);
            this.TotalQuantity_Box.Name = "TotalQuantity_Box";
            this.TotalQuantity_Box.Size = new System.Drawing.Size(68, 20);
            this.TotalQuantity_Box.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Most sold item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Most sold item Description";
            // 
            // mostSold_Code_Box
            // 
            this.mostSold_Code_Box.Location = new System.Drawing.Point(145, 122);
            this.mostSold_Code_Box.Name = "mostSold_Code_Box";
            this.mostSold_Code_Box.Size = new System.Drawing.Size(68, 20);
            this.mostSold_Code_Box.TabIndex = 7;
            // 
            // mostSold_Desc_Box
            // 
            this.mostSold_Desc_Box.Location = new System.Drawing.Point(159, 152);
            this.mostSold_Desc_Box.Name = "mostSold_Desc_Box";
            this.mostSold_Desc_Box.Size = new System.Drawing.Size(115, 20);
            this.mostSold_Desc_Box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // TotalsBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 357);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mostSold_Desc_Box);
            this.Controls.Add(this.mostSold_Code_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalQuantity_Box);
            this.Controls.Add(this.Select_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalAmt_Box);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TotalsBar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TotalsBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalAmt_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Select_Code;
        private System.Windows.Forms.TextBox TotalQuantity_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mostSold_Code_Box;
        private System.Windows.Forms.TextBox mostSold_Desc_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}