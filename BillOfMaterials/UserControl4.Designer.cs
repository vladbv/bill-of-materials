
namespace BillOfMaterials
{
    partial class UserControl4
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.materialmeasurement = new System.Windows.Forms.TextBox();
            this.materialdescription = new System.Windows.Forms.TextBox();
            this.materialname = new System.Windows.Forms.TextBox();
            this.materialid = new System.Windows.Forms.TextBox();
            this.backbtnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD MATERIAL";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(137, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "ADD NEW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Description of Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Measurement of Material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Name of Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID of Material";
            // 
            // materialmeasurement
            // 
            this.materialmeasurement.Location = new System.Drawing.Point(19, 232);
            this.materialmeasurement.Name = "materialmeasurement";
            this.materialmeasurement.Size = new System.Drawing.Size(178, 23);
            this.materialmeasurement.TabIndex = 20;
            // 
            // materialdescription
            // 
            this.materialdescription.Location = new System.Drawing.Point(19, 187);
            this.materialdescription.Name = "materialdescription";
            this.materialdescription.Size = new System.Drawing.Size(253, 23);
            this.materialdescription.TabIndex = 19;
            // 
            // materialname
            // 
            this.materialname.Location = new System.Drawing.Point(19, 131);
            this.materialname.Name = "materialname";
            this.materialname.Size = new System.Drawing.Size(178, 23);
            this.materialname.TabIndex = 18;
            // 
            // materialid
            // 
            this.materialid.Location = new System.Drawing.Point(19, 79);
            this.materialid.Name = "materialid";
            this.materialid.Size = new System.Drawing.Size(78, 23);
            this.materialid.TabIndex = 17;
            // 
            // backbtnadd
            // 
            this.backbtnadd.Image = global::BillOfMaterials.Properties.Resources._23;
            this.backbtnadd.Location = new System.Drawing.Point(22, 307);
            this.backbtnadd.Name = "backbtnadd";
            this.backbtnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backbtnadd.Size = new System.Drawing.Size(75, 40);
            this.backbtnadd.TabIndex = 25;
            this.backbtnadd.UseVisualStyleBackColor = true;
            this.backbtnadd.Click += new System.EventHandler(this.backbtnadd_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backbtnadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.materialmeasurement);
            this.Controls.Add(this.materialdescription);
            this.Controls.Add(this.materialname);
            this.Controls.Add(this.materialid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(504, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox materialmeasurement;
        private System.Windows.Forms.TextBox materialdescription;
        private System.Windows.Forms.TextBox materialname;
        private System.Windows.Forms.TextBox materialid;
        private System.Windows.Forms.Button backbtnadd;
    }
}
