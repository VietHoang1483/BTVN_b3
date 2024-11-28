namespace BTVN_b3
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
            this.lvQLNV = new System.Windows.Forms.ListView();
            this.clnlastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnfirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvQLNV
            // 
            this.lvQLNV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvQLNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnfirstname,
            this.clnlastname,
            this.clnphone});
            this.lvQLNV.FullRowSelect = true;
            this.lvQLNV.GridLines = true;
            this.lvQLNV.HideSelection = false;
            this.lvQLNV.Location = new System.Drawing.Point(12, 31);
            this.lvQLNV.Name = "lvQLNV";
            this.lvQLNV.Size = new System.Drawing.Size(492, 289);
            this.lvQLNV.TabIndex = 0;
            this.lvQLNV.UseCompatibleStateImageBehavior = false;
            this.lvQLNV.View = System.Windows.Forms.View.Details;
            this.lvQLNV.SelectedIndexChanged += new System.EventHandler(this.QLNV_SelectedIndexChanged);
            // 
            // clnlastname
            // 
            this.clnlastname.Text = "Last Name";
            this.clnlastname.Width = 130;
            // 
            // clnfirstname
            // 
            this.clnfirstname.Text = "First Name";
            this.clnfirstname.Width = 130;
            // 
            // clnphone
            // 
            this.clnphone.Text = "Phone";
            this.clnphone.Width = 130;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(526, 105);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(72, 16);
            this.lblLastname.TabIndex = 1;
            this.lblLastname.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(529, 124);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(365, 22);
            this.txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(529, 50);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(365, 22);
            this.txtfirstname.TabIndex = 3;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(529, 206);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(365, 22);
            this.txtphone.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(513, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(728, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 343);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lvQLNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvQLNV;
        private System.Windows.Forms.ColumnHeader clnlastname;
        private System.Windows.Forms.ColumnHeader clnfirstname;
        private System.Windows.Forms.ColumnHeader clnphone;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

