
namespace BillOfMaterials
{
    partial class UserControl5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl5));
            this.materialid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletematerial = new System.Windows.Forms.Button();
            this.editmaterial = new System.Windows.Forms.Button();
            this.addmaterial = new System.Windows.Forms.Button();
            this.materialrefresh = new System.Windows.Forms.Button();
            this.materialname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchmaterial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialdata = new System.Windows.Forms.DataGridView();
            this.userControl41 = new BillOfMaterials.UserControl4();
            ((System.ComponentModel.ISupportInitialize)(this.materialdata)).BeginInit();
            this.SuspendLayout();
            // 
            // materialid
            // 
            this.materialid.Location = new System.Drawing.Point(81, 63);
            this.materialid.Name = "materialid";
            this.materialid.Size = new System.Drawing.Size(57, 23);
            this.materialid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "MATERIALS";
            // 
            // deletematerial
            // 
            this.deletematerial.BackColor = System.Drawing.Color.Red;
            this.deletematerial.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletematerial.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deletematerial.Location = new System.Drawing.Point(389, 342);
            this.deletematerial.Name = "deletematerial";
            this.deletematerial.Size = new System.Drawing.Size(86, 33);
            this.deletematerial.TabIndex = 13;
            this.deletematerial.Text = "DELETE";
            this.deletematerial.UseVisualStyleBackColor = false;
            this.deletematerial.Click += new System.EventHandler(this.button1_Click);
            // 
            // editmaterial
            // 
            this.editmaterial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editmaterial.Location = new System.Drawing.Point(272, 342);
            this.editmaterial.Name = "editmaterial";
            this.editmaterial.Size = new System.Drawing.Size(83, 36);
            this.editmaterial.TabIndex = 12;
            this.editmaterial.Text = "EDIT";
            this.editmaterial.UseVisualStyleBackColor = true;
            this.editmaterial.Click += new System.EventHandler(this.button2_Click);
            // 
            // addmaterial
            // 
            this.addmaterial.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addmaterial.Location = new System.Drawing.Point(12, 346);
            this.addmaterial.Name = "addmaterial";
            this.addmaterial.Size = new System.Drawing.Size(165, 29);
            this.addmaterial.TabIndex = 11;
            this.addmaterial.Text = "ADD NEW";
            this.addmaterial.UseVisualStyleBackColor = true;
            this.addmaterial.Click += new System.EventHandler(this.button4_Click);
            // 
            // materialrefresh
            // 
            this.materialrefresh.Image = ((System.Drawing.Image)(resources.GetObject("materialrefresh.Image")));
            this.materialrefresh.Location = new System.Drawing.Point(12, 15);
            this.materialrefresh.Name = "materialrefresh";
            this.materialrefresh.Size = new System.Drawing.Size(35, 39);
            this.materialrefresh.TabIndex = 19;
            this.materialrefresh.UseVisualStyleBackColor = true;
            this.materialrefresh.Click += new System.EventHandler(this.materialrefresh_Click);
            // 
            // materialname
            // 
            this.materialname.Location = new System.Drawing.Point(172, 63);
            this.materialname.Name = "materialname";
            this.materialname.Size = new System.Drawing.Size(160, 23);
            this.materialname.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By ID",
            "By Name"});
            this.comboBox1.Location = new System.Drawing.Point(354, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // searchmaterial
            // 
            this.searchmaterial.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchmaterial.Location = new System.Drawing.Point(338, 60);
            this.searchmaterial.Name = "searchmaterial";
            this.searchmaterial.Size = new System.Drawing.Size(165, 29);
            this.searchmaterial.TabIndex = 22;
            this.searchmaterial.Text = "SEARCH";
            this.searchmaterial.UseVisualStyleBackColor = true;
            this.searchmaterial.Click += new System.EventHandler(this.searchmaterial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Material Name";
            // 
            // materialdata
            // 
            this.materialdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialdata.Location = new System.Drawing.Point(12, 92);
            this.materialdata.Name = "materialdata";
            this.materialdata.RowTemplate.Height = 25;
            this.materialdata.Size = new System.Drawing.Size(512, 244);
            this.materialdata.TabIndex = 25;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(0, 0);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(524, 397);
            this.userControl41.TabIndex = 26;
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchmaterial);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialname);
            this.Controls.Add(this.materialrefresh);
            this.Controls.Add(this.deletematerial);
            this.Controls.Add(this.editmaterial);
            this.Controls.Add(this.addmaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialid);
            this.Controls.Add(this.userControl41);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(799, 504);
            ((System.ComponentModel.ISupportInitialize)(this.materialdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox materialid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletematerial;
        private System.Windows.Forms.Button editmaterial;
        private System.Windows.Forms.Button addmaterial;
        private System.Windows.Forms.Button materialrefresh;
        private System.Windows.Forms.TextBox materialname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchmaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView materialdata;
        private UserControl4 userControl41;
    }
}
