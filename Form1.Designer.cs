namespace Buttons
{
    partial class Form1
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
            this.coffeeBtn = new System.Windows.Forms.Button();
            this.cakeBtn = new System.Windows.Forms.Button();
            this.teaBtn = new System.Windows.Forms.Button();
            this.salesLST = new System.Windows.Forms.ListBox();
            this.priceLST = new System.Windows.Forms.ListBox();
            this.totalTXT = new System.Windows.Forms.TextBox();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.Location = new System.Drawing.Point(13, 28);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(75, 23);
            this.coffeeBtn.TabIndex = 0;
            this.coffeeBtn.Text = "Coffee";
            this.coffeeBtn.UseVisualStyleBackColor = true;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // cakeBtn
            // 
            this.cakeBtn.Location = new System.Drawing.Point(13, 68);
            this.cakeBtn.Name = "cakeBtn";
            this.cakeBtn.Size = new System.Drawing.Size(75, 23);
            this.cakeBtn.TabIndex = 1;
            this.cakeBtn.Text = "Cake";
            this.cakeBtn.UseVisualStyleBackColor = true;
            this.cakeBtn.Click += new System.EventHandler(this.cakeBtn_Click);
            // 
            // teaBtn
            // 
            this.teaBtn.Location = new System.Drawing.Point(13, 108);
            this.teaBtn.Name = "teaBtn";
            this.teaBtn.Size = new System.Drawing.Size(75, 23);
            this.teaBtn.TabIndex = 2;
            this.teaBtn.Text = "Tea";
            this.teaBtn.UseVisualStyleBackColor = true;
            this.teaBtn.Click += new System.EventHandler(this.teaBtn_Click);
            // 
            // salesLST
            // 
            this.salesLST.FormattingEnabled = true;
            this.salesLST.Location = new System.Drawing.Point(145, 28);
            this.salesLST.Name = "salesLST";
            this.salesLST.Size = new System.Drawing.Size(171, 303);
            this.salesLST.TabIndex = 3;
            // 
            // priceLST
            // 
            this.priceLST.FormattingEnabled = true;
            this.priceLST.Location = new System.Drawing.Point(313, 28);
            this.priceLST.Name = "priceLST";
            this.priceLST.Size = new System.Drawing.Size(120, 303);
            this.priceLST.TabIndex = 4;
            // 
            // totalTXT
            // 
            this.totalTXT.Location = new System.Drawing.Point(313, 337);
            this.totalTXT.Name = "totalTXT";
            this.totalTXT.Size = new System.Drawing.Size(120, 20);
            this.totalTXT.TabIndex = 5;
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.Location = new System.Drawing.Point(13, 148);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(75, 23);
            this.clearItemBtn.TabIndex = 6;
            this.clearItemBtn.Text = "Clear Item";
            this.clearItemBtn.UseVisualStyleBackColor = true;
            this.clearItemBtn.Click += new System.EventHandler(this.clearItemBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(272, 343);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(37, 13);
            this.totalLbl.TabIndex = 7;
            this.totalLbl.Text = "Total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 379);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.clearItemBtn);
            this.Controls.Add(this.totalTXT);
            this.Controls.Add(this.priceLST);
            this.Controls.Add(this.salesLST);
            this.Controls.Add(this.teaBtn);
            this.Controls.Add(this.cakeBtn);
            this.Controls.Add(this.coffeeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coffeeBtn;
        private System.Windows.Forms.Button cakeBtn;
        private System.Windows.Forms.Button teaBtn;
        private System.Windows.Forms.ListBox salesLST;
        private System.Windows.Forms.ListBox priceLST;
        private System.Windows.Forms.TextBox totalTXT;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.Label totalLbl;
    }
}

