namespace Week11
{
    partial class frmEmployees
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
            this.components = new System.ComponentModel.Container();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSampleDataSet3 = new Week11.employeeSampleDataSet3();
            this.btnClose = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Week11.employeeSampleDataSet3TableAdapters.employeesTableAdapter();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtptimepicker = new System.Windows.Forms.DateTimePicker();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudCommisionPercent = new System.Windows.Forms.NumericUpDown();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboManager = new System.Windows.Forms.ComboBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommisionPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.DataSource = this.employeesBindingSource;
            this.cboEmployees.DisplayMember = "firstName";
            this.cboEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(12, 23);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(638, 45);
            this.cboEmployees.TabIndex = 0;
            this.cboEmployees.ValueMember = "firstName";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.employeeSampleDataSet3;
            // 
            // employeeSampleDataSet3
            // 
            this.employeeSampleDataSet3.DataSetName = "employeeSampleDataSet3";
            this.employeeSampleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(529, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "firstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(61, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(129, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "lastName", true));
            this.txtLastName.Location = new System.Drawing.Point(61, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(129, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.textBox1.Location = new System.Drawing.Point(61, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "phoneNumber", true));
            this.textBox2.Location = new System.Drawing.Point(61, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 26);
            this.textBox2.TabIndex = 5;
            // 
            // dtptimepicker
            // 
            this.dtptimepicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "hireDate", true));
            this.dtptimepicker.Location = new System.Drawing.Point(61, 269);
            this.dtptimepicker.Name = "dtptimepicker";
            this.dtptimepicker.Size = new System.Drawing.Size(200, 26);
            this.dtptimepicker.TabIndex = 6;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "jobTitle", true));
            this.txtJobTitle.Location = new System.Drawing.Point(256, 95);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(129, 26);
            this.txtJobTitle.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "salary", true));
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(256, 137);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 8;
            // 
            // nudCommisionPercent
            // 
            this.nudCommisionPercent.DecimalPlaces = 3;
            this.nudCommisionPercent.Location = new System.Drawing.Point(402, 137);
            this.nudCommisionPercent.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCommisionPercent.Name = "nudCommisionPercent";
            this.nudCommisionPercent.Size = new System.Drawing.Size(120, 26);
            this.nudCommisionPercent.TabIndex = 9;
            // 
            // cboDepartment
            // 
            this.cboDepartment.AllowDrop = true;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(415, 95);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(149, 28);
            this.cboDepartment.TabIndex = 10;
            // 
            // cboManager
            // 
            this.cboManager.AllowDrop = true;
            this.cboManager.FormattingEnabled = true;
            this.cboManager.Location = new System.Drawing.Point(415, 181);
            this.cboManager.Name = "cboManager";
            this.cboManager.Size = new System.Drawing.Size(149, 28);
            this.cboManager.TabIndex = 11;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(336, 269);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(243, 28);
            this.cbo.TabIndex = 12;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 562);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.cboManager);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.nudCommisionPercent);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.dtptimepicker);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboEmployees);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommisionPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Button btnClose;
        private employeeSampleDataSet3 employeeSampleDataSet3;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private employeeSampleDataSet3TableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtptimepicker;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nudCommisionPercent;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboManager;
        private System.Windows.Forms.ComboBox cbo;
    }
}