namespace DatabaseSqlHospital
{
    partial class doctors
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
            btn_editSelectedAlbum = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button4 = new Button();
            txt_staffnumber = new TextBox();
            txt_location = new TextBox();
            txt_depname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            lbl_empID = new Label();
            checkBox1 = new CheckBox();
            button6 = new Button();
            txt_department = new TextBox();
            label5 = new Label();
            button3 = new Button();
            txt_salary = new TextBox();
            txt_sex = new TextBox();
            txt_phone_number = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_editSelectedAlbum
            // 
            btn_editSelectedAlbum.Location = new Point(36, 471);
            btn_editSelectedAlbum.Name = "btn_editSelectedAlbum";
            btn_editSelectedAlbum.Size = new Size(255, 29);
            btn_editSelectedAlbum.TabIndex = 27;
            btn_editSelectedAlbum.Text = "Редактровать данные врача";
            btn_editSelectedAlbum.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(434, 245);
            button5.Name = "button5";
            button5.Size = new Size(146, 29);
            button5.TabIndex = 26;
            button5.Text = "Все записы";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(434, 279);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(243, 142);
            dataGridView2.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(txt_staffnumber);
            groupBox2.Controls.Add(txt_location);
            groupBox2.Controls.Add(txt_depname);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(434, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 200);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить запись";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(6, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // txt_staffnumber
            // 
            txt_staffnumber.Location = new Point(128, 97);
            txt_staffnumber.Name = "txt_staffnumber";
            txt_staffnumber.Size = new Size(110, 27);
            txt_staffnumber.TabIndex = 7;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(128, 64);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(110, 27);
            txt_location.TabIndex = 6;
            // 
            // txt_depname
            // 
            txt_depname.Location = new Point(128, 32);
            txt_depname.Name = "txt_depname";
            txt_depname.Size = new Size(112, 27);
            txt_depname.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 97);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 2;
            label8.Text = "Staff number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 64);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 1;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 32);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 0;
            label10.Text = "Doctors ID";
            label10.Click += label10_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_empID);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(txt_department);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_salary);
            groupBox1.Controls.Add(txt_sex);
            groupBox1.Controls.Add(txt_phone_number);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(36, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 221);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить врача";
            // 
            // lbl_empID
            // 
            lbl_empID.AutoSize = true;
            lbl_empID.Location = new Point(75, 167);
            lbl_empID.Name = "lbl_empID";
            lbl_empID.Size = new Size(68, 20);
            lbl_empID.TabIndex = 13;
            lbl_empID.Text = "doctorID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(12, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(144, 160);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(128, 127);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(112, 27);
            txt_department.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 127);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Employee ID";
            // 
            // button3
            // 
            button3.Location = new Point(8, 190);
            button3.Name = "button3";
            button3.Size = new Size(214, 29);
            button3.TabIndex = 5;
            button3.Text = "Добавить / редактировать";
            button3.UseVisualStyleBackColor = true;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(128, 92);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(112, 27);
            txt_salary.TabIndex = 8;
            // 
            // txt_sex
            // 
            txt_sex.Location = new Point(128, 60);
            txt_sex.Name = "txt_sex";
            txt_sex.Size = new Size(110, 27);
            txt_sex.TabIndex = 7;
            // 
            // txt_phone_number
            // 
            txt_phone_number.Location = new Point(128, 27);
            txt_phone_number.Name = "txt_phone_number";
            txt_phone_number.Size = new Size(110, 27);
            txt_phone_number.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 95);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Education";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Specialization";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Seniority";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(99, 27);
            textBox1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(143, 246);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 21;
            button2.Text = "Искать по ФИО врача";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(406, 188);
            dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 19;
            button1.Text = "Все сотрудники";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 506);
            Controls.Add(btn_editSelectedAlbum);
            Controls.Add(button5);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "doctors";
            Text = "doctors";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editSelectedAlbum;
        private Button button5;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox txt_staffnumber;
        private TextBox txt_location;
        private TextBox txt_depname;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private Label lbl_empID;
        private CheckBox checkBox1;
        private Button button6;
        private TextBox txt_department;
        private Label label5;
        private Button button3;
        private TextBox txt_salary;
        private TextBox txt_sex;
        private TextBox txt_phone_number;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}