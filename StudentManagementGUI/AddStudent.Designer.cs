namespace StudentManagementGUI
{
    partial class AddStudent
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
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            cbClass = new ComboBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            richAdress = new RichTextBox();
            dtpBirthday = new DateTimePicker();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(cbClass);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richAdress);
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1285, 532);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1054, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(186, 79);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(807, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(186, 79);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(383, 145);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(122, 36);
            rdFemale.TabIndex = 13;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(183, 149);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(98, 36);
            rdMale.TabIndex = 12;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // cbClass
            // 
            cbClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(807, 241);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(433, 53);
            cbClass.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(807, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(433, 50);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(674, 251);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 8;
            label6.Text = "Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 149);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 149);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // richAdress
            // 
            richAdress.Location = new Point(183, 251);
            richAdress.Name = "richAdress";
            richAdress.Size = new Size(433, 210);
            richAdress.TabIndex = 5;
            richAdress.Text = "";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(807, 55);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(433, 50);
            dtpBirthday.TabIndex = 4;
            dtpBirthday.Value = new DateTime(2023, 10, 23, 23, 54, 0, 0);
            dtpBirthday.MinDate = new DateTime(1990, 1, 1);
            dtpBirthday.MaxDate = new DateTime(2015, 12, 31);
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(183, 55);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(433, 50);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 251);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 65);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Birthday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 65);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 556);
            Controls.Add(groupBox1);
            Name = "AddStudent";
            Text = "Add Student";
            Load += AddStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private ComboBox cbClass;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox richAdress;
        private DateTimePicker dtpBirthday;
        private TextBox txtFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
    }
}