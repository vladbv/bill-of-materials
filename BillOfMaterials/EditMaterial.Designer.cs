
namespace BillOfMaterials
{
    partial class EditMaterial
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
            this.editmid = new System.Windows.Forms.TextBox();
            this.editmname = new System.Windows.Forms.TextBox();
            this.editmdescription = new System.Windows.Forms.TextBox();
            this.editmmeasurement = new System.Windows.Forms.TextBox();
            this.materialeditfinish = new System.Windows.Forms.Button();
            this.lavel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editmid
            // 
            this.editmid.Location = new System.Drawing.Point(44, 55);
            this.editmid.Name = "editmid";
            this.editmid.Size = new System.Drawing.Size(97, 23);
            this.editmid.TabIndex = 0;
            // 
            // editmname
            // 
            this.editmname.Location = new System.Drawing.Point(44, 107);
            this.editmname.Name = "editmname";
            this.editmname.Size = new System.Drawing.Size(146, 23);
            this.editmname.TabIndex = 1;
            // 
            // editmdescription
            // 
            this.editmdescription.Location = new System.Drawing.Point(44, 155);
            this.editmdescription.Name = "editmdescription";
            this.editmdescription.Size = new System.Drawing.Size(287, 23);
            this.editmdescription.TabIndex = 2;
            // 
            // editmmeasurement
            // 
            this.editmmeasurement.Location = new System.Drawing.Point(44, 205);
            this.editmmeasurement.Name = "editmmeasurement";
            this.editmmeasurement.Size = new System.Drawing.Size(146, 23);
            this.editmmeasurement.TabIndex = 3;
            // 
            // materialeditfinish
            // 
            this.materialeditfinish.Location = new System.Drawing.Point(82, 274);
            this.materialeditfinish.Name = "materialeditfinish";
            this.materialeditfinish.Size = new System.Drawing.Size(75, 23);
            this.materialeditfinish.TabIndex = 4;
            this.materialeditfinish.Text = "EDIT";
            this.materialeditfinish.UseVisualStyleBackColor = true;
            this.materialeditfinish.Click += new System.EventHandler(this.materialeditfinish_Click);
            // 
            // lavel1
            // 
            this.lavel1.AutoSize = true;
            this.lavel1.Location = new System.Drawing.Point(44, 37);
            this.lavel1.Name = "lavel1";
            this.lavel1.Size = new System.Drawing.Size(64, 15);
            this.lavel1.TabIndex = 5;
            this.lavel1.Text = "Material ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Material Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Material Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Material Measurement";
            // 
            // EditMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lavel1);
            this.Controls.Add(this.materialeditfinish);
            this.Controls.Add(this.editmmeasurement);
            this.Controls.Add(this.editmdescription);
            this.Controls.Add(this.editmname);
            this.Controls.Add(this.editmid);
            this.Name = "EditMaterial";
            this.Text = "EditMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button materialeditfinish;
        private System.Windows.Forms.Label lavel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox editmid;
        public System.Windows.Forms.TextBox editmname;
        public System.Windows.Forms.TextBox editmdescription;
        public System.Windows.Forms.TextBox editmmeasurement;
    }
}