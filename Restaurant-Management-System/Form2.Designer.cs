
namespace Restaurant_Management_System
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.order_tab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.res_tab = new System.Windows.Forms.TabPage();
            this.billing_tab = new System.Windows.Forms.TabPage();
            this.log_tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f2_close = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.order_tab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.order_tab);
            this.tabControl1.Controls.Add(this.res_tab);
            this.tabControl1.Controls.Add(this.billing_tab);
            this.tabControl1.Controls.Add(this.log_tab);
            this.tabControl1.Location = new System.Drawing.Point(1, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // order_tab
            // 
            this.order_tab.Controls.Add(this.tabControl2);
            this.order_tab.Location = new System.Drawing.Point(4, 29);
            this.order_tab.Name = "order_tab";
            this.order_tab.Padding = new System.Windows.Forms.Padding(3);
            this.order_tab.Size = new System.Drawing.Size(942, 461);
            this.order_tab.TabIndex = 0;
            this.order_tab.Text = "Order";
            this.order_tab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(943, 461);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Snacks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main Course";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(935, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dessert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(935, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cold Drinks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(935, 428);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Beverages";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // res_tab
            // 
            this.res_tab.Location = new System.Drawing.Point(4, 29);
            this.res_tab.Name = "res_tab";
            this.res_tab.Padding = new System.Windows.Forms.Padding(3);
            this.res_tab.Size = new System.Drawing.Size(942, 461);
            this.res_tab.TabIndex = 1;
            this.res_tab.Text = "Reservation";
            this.res_tab.UseVisualStyleBackColor = true;
            // 
            // billing_tab
            // 
            this.billing_tab.Location = new System.Drawing.Point(4, 29);
            this.billing_tab.Name = "billing_tab";
            this.billing_tab.Padding = new System.Windows.Forms.Padding(3);
            this.billing_tab.Size = new System.Drawing.Size(942, 461);
            this.billing_tab.TabIndex = 2;
            this.billing_tab.Text = "Costumer Billing";
            this.billing_tab.UseVisualStyleBackColor = true;
            // 
            // log_tab
            // 
            this.log_tab.Location = new System.Drawing.Point(4, 29);
            this.log_tab.Name = "log_tab";
            this.log_tab.Padding = new System.Windows.Forms.Padding(3);
            this.log_tab.Size = new System.Drawing.Size(942, 461);
            this.log_tab.TabIndex = 3;
            this.log_tab.Text = "Costumer Log";
            this.log_tab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "9841414141";
            // 
            // f2_close
            // 
            this.f2_close.AutoSize = true;
            this.f2_close.Location = new System.Drawing.Point(891, 9);
            this.f2_close.Name = "f2_close";
            this.f2_close.Size = new System.Drawing.Size(49, 20);
            this.f2_close.TabIndex = 3;
            this.f2_close.Text = "Close";
            this.f2_close.Click += new System.EventHandler(this.f2_close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 585);
            this.Controls.Add(this.f2_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.order_tab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage order_tab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage res_tab;
        private System.Windows.Forms.TabPage billing_tab;
        private System.Windows.Forms.TabPage log_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label f2_close;
    }
}