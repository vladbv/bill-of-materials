
namespace BillOfMaterials
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productdescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backbtnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE A NEW PRODUCT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(124, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "ADD NEW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Product ID";
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(18, 69);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(62, 23);
            this.productid.TabIndex = 8;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(18, 121);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(159, 23);
            this.productname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Product Name";
            // 
            // productdescription
            // 
            this.productdescription.Location = new System.Drawing.Point(18, 177);
            this.productdescription.Name = "productdescription";
            this.productdescription.Size = new System.Drawing.Size(361, 23);
            this.productdescription.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Product Description";
            // 
            // backbtnadd
            // 
            this.backbtnadd.Image = global::BillOfMaterials.Properties.Resources._23;
            this.backbtnadd.Location = new System.Drawing.Point(19, 308);
            this.backbtnadd.Name = "backbtnadd";
            this.backbtnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backbtnadd.Size = new System.Drawing.Size(75, 40);
            this.backbtnadd.TabIndex = 13;
            this.backbtnadd.UseVisualStyleBackColor = true;
            this.backbtnadd.Click += new System.EventHandler(this.backbtnadd_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backbtnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productdescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.productid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(482, 384);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productdescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backbtnadd;
    }
}
