
namespace BillOfMaterials
{
    partial class EditProduct
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
            this.editpid = new System.Windows.Forms.TextBox();
            this.editpname = new System.Windows.Forms.TextBox();
            this.editpdescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editpbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editpid
            // 
            this.editpid.Location = new System.Drawing.Point(46, 43);
            this.editpid.Name = "editpid";
            this.editpid.Size = new System.Drawing.Size(87, 23);
            this.editpid.TabIndex = 0;
            // 
            // editpname
            // 
            this.editpname.Location = new System.Drawing.Point(46, 102);
            this.editpname.Name = "editpname";
            this.editpname.Size = new System.Drawing.Size(156, 23);
            this.editpname.TabIndex = 1;
            // 
            // editpdescription
            // 
            this.editpdescription.Location = new System.Drawing.Point(46, 159);
            this.editpdescription.Name = "editpdescription";
            this.editpdescription.Size = new System.Drawing.Size(227, 23);
            this.editpdescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // editpbutton
            // 
            this.editpbutton.Location = new System.Drawing.Point(154, 217);
            this.editpbutton.Name = "editpbutton";
            this.editpbutton.Size = new System.Drawing.Size(75, 23);
            this.editpbutton.TabIndex = 6;
            this.editpbutton.Text = "Edit";
            this.editpbutton.UseVisualStyleBackColor = true;
            this.editpbutton.Click += new System.EventHandler(this.editpbutton_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 266);
            this.Controls.Add(this.editpbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editpdescription);
            this.Controls.Add(this.editpname);
            this.Controls.Add(this.editpid);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox editpid;
        public System.Windows.Forms.TextBox editpname;
        public System.Windows.Forms.TextBox editpdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editpbutton;
    }
}