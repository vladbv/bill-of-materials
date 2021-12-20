
namespace BillOfMaterials
{
    partial class UserControl1
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
            this.addexpenses = new System.Windows.Forms.Button();
            this.editexpenses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expenseid = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.deleteexpenses = new System.Windows.Forms.Button();
            this.expensesdatagrid = new System.Windows.Forms.DataGridView();
            this.expensename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchexpenses = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.expensesdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addexpenses
            // 
            this.addexpenses.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addexpenses.Location = new System.Drawing.Point(69, 408);
            this.addexpenses.Name = "addexpenses";
            this.addexpenses.Size = new System.Drawing.Size(165, 29);
            this.addexpenses.TabIndex = 1;
            this.addexpenses.Text = "ADD NEW";
            this.addexpenses.UseVisualStyleBackColor = true;
            this.addexpenses.Click += new System.EventHandler(this.button1_Click);
            // 
            // editexpenses
            // 
            this.editexpenses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editexpenses.Location = new System.Drawing.Point(262, 401);
            this.editexpenses.Name = "editexpenses";
            this.editexpenses.Size = new System.Drawing.Size(83, 36);
            this.editexpenses.TabIndex = 2;
            this.editexpenses.Text = "EDIT";
            this.editexpenses.UseVisualStyleBackColor = true;
            this.editexpenses.Click += new System.EventHandler(this.editexpenses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXPENSES";
            // 
            // expenseid
            // 
            this.expenseid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expenseid.Location = new System.Drawing.Point(46, 71);
            this.expenseid.Name = "expenseid";
            this.expenseid.Size = new System.Drawing.Size(69, 29);
            this.expenseid.TabIndex = 4;
            this.expenseid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // deleteexpenses
            // 
            this.deleteexpenses.BackColor = System.Drawing.Color.Red;
            this.deleteexpenses.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteexpenses.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteexpenses.Location = new System.Drawing.Point(382, 406);
            this.deleteexpenses.Name = "deleteexpenses";
            this.deleteexpenses.Size = new System.Drawing.Size(86, 33);
            this.deleteexpenses.TabIndex = 5;
            this.deleteexpenses.Text = "DELETE";
            this.deleteexpenses.UseVisualStyleBackColor = false;
            this.deleteexpenses.Click += new System.EventHandler(this.deleteexpenses_Click);
            // 
            // expensesdatagrid
            // 
            this.expensesdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expensesdatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.expensesdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesdatagrid.Location = new System.Drawing.Point(29, 134);
            this.expensesdatagrid.Name = "expensesdatagrid";
            this.expensesdatagrid.RowTemplate.Height = 25;
            this.expensesdatagrid.Size = new System.Drawing.Size(477, 245);
            this.expensesdatagrid.TabIndex = 6;
            this.expensesdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expensesdatagrid_CellContentClick);
            // 
            // expensename
            // 
            this.expensename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expensename.Location = new System.Drawing.Point(175, 71);
            this.expensename.Name = "expensename";
            this.expensename.Size = new System.Drawing.Size(181, 29);
            this.expensename.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expense Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID of Expense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please enter data in the fields and click a button to perform a different operati" +
    "on";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searchexpenses
            // 
            this.searchexpenses.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchexpenses.Location = new System.Drawing.Point(362, 71);
            this.searchexpenses.Name = "searchexpenses";
            this.searchexpenses.Size = new System.Drawing.Size(165, 29);
            this.searchexpenses.TabIndex = 11;
            this.searchexpenses.Text = "SEARCH";
            this.searchexpenses.UseVisualStyleBackColor = true;
            this.searchexpenses.Click += new System.EventHandler(this.searchexpenses_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By ID",
            "By Name"});
            this.comboBox1.Location = new System.Drawing.Point(382, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchexpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expensename);
            this.Controls.Add(this.expensesdatagrid);
            this.Controls.Add(this.deleteexpenses);
            this.Controls.Add(this.expenseid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editexpenses);
            this.Controls.Add(this.addexpenses);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(876, 532);
            this.Load += new System.EventHandler(this.UserControl1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.expensesdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addexpenses;
        private System.Windows.Forms.Button editexpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expenseid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button deleteexpenses;
        private System.Windows.Forms.DataGridView expensesdatagrid;
        private System.Windows.Forms.TextBox expensename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchexpenses;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
