namespace MiniPayroll
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.lblEID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_compute = new System.Windows.Forms.Button();
            this.txt_totalsalary = new System.Windows.Forms.TextBox();
            this.lbl_totalsalary = new System.Windows.Forms.Label();
            this.txt_salaryperday = new System.Windows.Forms.TextBox();
            this.lbl_salaryperday = new System.Windows.Forms.Label();
            this.txt_workingdays = new System.Windows.Forms.TextBox();
            this.lbl_workingdays = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.gbox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(296, 19);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(739, 344);
            this.DGV1.TabIndex = 1;
            this.DGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellClick);
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEID.Location = new System.Drawing.Point(6, 31);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(63, 18);
            this.lblEID.TabIndex = 2;
            this.lblEID.Text = "Employee ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(10, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 26);
            this.txtID.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(10, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(10, 333);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(232, 26);
            this.txtMobile.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(6, 306);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 18);
            this.lblMobile.TabIndex = 9;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 18);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(7, 447);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(63, 18);
            this.lblBD.TabIndex = 12;
            this.lblBD.Text = "Bank Details:";
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB1.Location = new System.Drawing.Point(10, 472);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(232, 28);
            this.txtB1.TabIndex = 14;
            this.txtB1.Text = "";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(10, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 26);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(6, 374);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 18);
            this.lblSSN.TabIndex = 16;
            this.lblSSN.Text = "SSN:";
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(10, 401);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(232, 26);
            this.txtSSN.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(12, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 34);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MintCream;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdate.Location = new System.Drawing.Point(109, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MintCream;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(206, 545);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbox1
            // 
            this.gbox1.BackColor = System.Drawing.Color.MintCream;
            this.gbox1.Controls.Add(this.lblEID);
            this.gbox1.Controls.Add(this.txtID);
            this.gbox1.Controls.Add(this.lblName);
            this.gbox1.Controls.Add(this.txtName);
            this.gbox1.Controls.Add(this.txtB1);
            this.gbox1.Controls.Add(this.lblAddress);
            this.gbox1.Controls.Add(this.lblBD);
            this.gbox1.Controls.Add(this.lblMobile);
            this.gbox1.Controls.Add(this.txtSSN);
            this.gbox1.Controls.Add(this.txtAddress);
            this.gbox1.Controls.Add(this.lblEmail);
            this.gbox1.Controls.Add(this.lblSSN);
            this.gbox1.Controls.Add(this.txtEmail);
            this.gbox1.Controls.Add(this.txtMobile);
            this.gbox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbox1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox1.ForeColor = System.Drawing.Color.Teal;
            this.gbox1.Location = new System.Drawing.Point(12, 19);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(268, 519);
            this.gbox1.TabIndex = 24;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "Add Employee";
            this.gbox1.Enter += new System.EventHandler(this.gbox1_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MintCream;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(109, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 33);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.btn_compute);
            this.groupBox1.Controls.Add(this.txt_totalsalary);
            this.groupBox1.Controls.Add(this.lbl_totalsalary);
            this.groupBox1.Controls.Add(this.txt_salaryperday);
            this.groupBox1.Controls.Add(this.lbl_salaryperday);
            this.groupBox1.Controls.Add(this.txt_workingdays);
            this.groupBox1.Controls.Add(this.lbl_workingdays);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(296, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compute Salary";
            // 
            // btn_compute
            // 
            this.btn_compute.BackColor = System.Drawing.Color.Teal;
            this.btn_compute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compute.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_compute.Location = new System.Drawing.Point(166, 129);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(98, 34);
            this.btn_compute.TabIndex = 6;
            this.btn_compute.Text = "COMPUTE";
            this.btn_compute.UseVisualStyleBackColor = false;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // txt_totalsalary
            // 
            this.txt_totalsalary.Enabled = false;
            this.txt_totalsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalsalary.Location = new System.Drawing.Point(120, 93);
            this.txt_totalsalary.Name = "txt_totalsalary";
            this.txt_totalsalary.ReadOnly = true;
            this.txt_totalsalary.Size = new System.Drawing.Size(175, 26);
            this.txt_totalsalary.TabIndex = 5;
            // 
            // lbl_totalsalary
            // 
            this.lbl_totalsalary.AutoSize = true;
            this.lbl_totalsalary.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalsalary.Location = new System.Drawing.Point(50, 97);
            this.lbl_totalsalary.Name = "lbl_totalsalary";
            this.lbl_totalsalary.Size = new System.Drawing.Size(64, 18);
            this.lbl_totalsalary.TabIndex = 4;
            this.lbl_totalsalary.Text = "Total Salary:";
            // 
            // txt_salaryperday
            // 
            this.txt_salaryperday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaryperday.Location = new System.Drawing.Point(120, 56);
            this.txt_salaryperday.Name = "txt_salaryperday";
            this.txt_salaryperday.Size = new System.Drawing.Size(175, 26);
            this.txt_salaryperday.TabIndex = 3;
            // 
            // lbl_salaryperday
            // 
            this.lbl_salaryperday.AutoSize = true;
            this.lbl_salaryperday.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salaryperday.Location = new System.Drawing.Point(36, 64);
            this.lbl_salaryperday.Name = "lbl_salaryperday";
            this.lbl_salaryperday.Size = new System.Drawing.Size(78, 18);
            this.lbl_salaryperday.TabIndex = 2;
            this.lbl_salaryperday.Text = "Salary per Day:";
            // 
            // txt_workingdays
            // 
            this.txt_workingdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workingdays.Location = new System.Drawing.Point(120, 24);
            this.txt_workingdays.Name = "txt_workingdays";
            this.txt_workingdays.Size = new System.Drawing.Size(55, 26);
            this.txt_workingdays.TabIndex = 1;
            // 
            // lbl_workingdays
            // 
            this.lbl_workingdays.AutoSize = true;
            this.lbl_workingdays.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workingdays.Location = new System.Drawing.Point(15, 28);
            this.lbl_workingdays.Name = "lbl_workingdays";
            this.lbl_workingdays.Size = new System.Drawing.Size(99, 18);
            this.lbl_workingdays.TabIndex = 0;
            this.lbl_workingdays.Text = "No. of Working days:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MintCream;
            this.btnLogout.BackgroundImage = global::MiniPayroll.Properties.Resources.logout7;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Teal;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.Location = new System.Drawing.Point(752, 401);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 100);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1044, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DGV1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label lblEID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.RichTextBox txtB1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbl_workingdays;
        private System.Windows.Forms.TextBox txt_workingdays;
        private System.Windows.Forms.Label lbl_salaryperday;
        private System.Windows.Forms.TextBox txt_salaryperday;
        private System.Windows.Forms.Label lbl_totalsalary;
        private System.Windows.Forms.TextBox txt_totalsalary;
        private System.Windows.Forms.Button btn_compute;
    }
}