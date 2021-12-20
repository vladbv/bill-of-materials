
namespace BillOfMaterials
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addnewproduct = new System.Windows.Forms.Button();
            this.editproduct = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchexpenses = new System.Windows.Forms.Button();
            this.productsdata = new System.Windows.Forms.DataGridView();
            this.productrefresh = new System.Windows.Forms.Button();
            this.pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControl32 = new BillOfMaterials.UserControl3();
            ((System.ComponentModel.ISupportInitialize)(this.productsdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pid.Location = new System.Drawing.Point(76, 36);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(71, 29);
            this.pid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRODUCTS";
            // 
            // addnewproduct
            // 
            this.addnewproduct.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnewproduct.Location = new System.Drawing.Point(26, 331);
            this.addnewproduct.Name = "addnewproduct";
            this.addnewproduct.Size = new System.Drawing.Size(165, 29);
            this.addnewproduct.TabIndex = 7;
            this.addnewproduct.Text = "ADD NEW";
            this.addnewproduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addnewproduct.UseVisualStyleBackColor = true;
            this.addnewproduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // editproduct
            // 
            this.editproduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editproduct.Location = new System.Drawing.Point(243, 331);
            this.editproduct.Name = "editproduct";
            this.editproduct.Size = new System.Drawing.Size(83, 36);
            this.editproduct.TabIndex = 8;
            this.editproduct.Text = "EDIT";
            this.editproduct.UseVisualStyleBackColor = true;
            this.editproduct.Click += new System.EventHandler(this.editproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.BackColor = System.Drawing.Color.Red;
            this.deleteproduct.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteproduct.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteproduct.Location = new System.Drawing.Point(356, 334);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(86, 33);
            this.deleteproduct.TabIndex = 9;
            this.deleteproduct.Text = "DELETE";
            this.deleteproduct.UseVisualStyleBackColor = false;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By ID",
            "By Name"});
            this.comboBox1.Location = new System.Drawing.Point(399, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // searchexpenses
            // 
            this.searchexpenses.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchexpenses.Location = new System.Drawing.Point(377, 36);
            this.searchexpenses.Name = "searchexpenses";
            this.searchexpenses.Size = new System.Drawing.Size(165, 29);
            this.searchexpenses.TabIndex = 14;
            this.searchexpenses.Text = "SEARCH";
            this.searchexpenses.UseVisualStyleBackColor = true;
            this.searchexpenses.Click += new System.EventHandler(this.searchexpenses_Click);
            // 
            // productsdata
            // 
            this.productsdata.AllowUserToAddRows = false;
            this.productsdata.AllowUserToDeleteRows = false;
            this.productsdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsdata.Location = new System.Drawing.Point(0, 71);
            this.productsdata.Name = "productsdata";
            this.productsdata.ReadOnly = true;
            this.productsdata.RowTemplate.Height = 25;
            this.productsdata.Size = new System.Drawing.Size(701, 254);
            this.productsdata.TabIndex = 16;
            this.productsdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // productrefresh
            // 
            this.productrefresh.Image = ((System.Drawing.Image)(resources.GetObject("productrefresh.Image")));
            this.productrefresh.Location = new System.Drawing.Point(9, 5);
            this.productrefresh.Name = "productrefresh";
            this.productrefresh.Size = new System.Drawing.Size(35, 39);
            this.productrefresh.TabIndex = 18;
            this.productrefresh.UseVisualStyleBackColor = true;
            this.productrefresh.Click += new System.EventHandler(this.productrefresh_Click);
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pname.Location = new System.Drawing.Point(169, 36);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(178, 29);
            this.pname.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Name";
            // 
            // userControl32
            // 
            this.userControl32.Location = new System.Drawing.Point(0, 5);
            this.userControl32.Name = "userControl32";
            this.userControl32.Size = new System.Drawing.Size(599, 410);
            this.userControl32.TabIndex = 17;
            this.userControl32.Load += new System.EventHandler(this.userControl32_Load);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.productrefresh);
            this.Controls.Add(this.productsdata);
            this.Controls.Add(this.searchexpenses);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteproduct);
            this.Controls.Add(this.editproduct);
            this.Controls.Add(this.addnewproduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.userControl32);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(738, 415);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnewproduct;
        private System.Windows.Forms.Button editproduct;
        private System.Windows.Forms.Button deleteproduct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchexpenses;
        private UserControl3 userControl31;
        private System.Windows.Forms.DataGridView productsdata;
        private System.Windows.Forms.Button productrefresh;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UserControl3 userControl32;
    }
}
