namespace DatabaseSqlHospital
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
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
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            txt_staffnumber = new TextBox();
            txt_location = new TextBox();
            txt_depname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            btn_editSelectedAlbum = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(252, 153);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 0;
            button1.Text = "Все сотрудники";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(728, 188);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(385, 153);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 2;
            button2.Text = "Искать по ФИО сотрудника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(600, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 3;
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
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 262);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить сотрудника";
            // 
            // lbl_empID
            // 
            lbl_empID.AutoSize = true;
            lbl_empID.Location = new Point(75, 204);
            lbl_empID.Name = "lbl_empID";
            lbl_empID.Size = new Size(54, 20);
            lbl_empID.TabIndex = 13;
            lbl_empID.Text = "empID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(12, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(144, 197);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(128, 164);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(112, 27);
            txt_department.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 164);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "Department ID";
            // 
            // button3
            // 
            button3.Location = new Point(8, 227);
            button3.Name = "button3";
            button3.Size = new Size(214, 29);
            button3.TabIndex = 5;
            button3.Text = "Добавить / редактировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(128, 129);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(112, 27);
            txt_salary.TabIndex = 8;
            // 
            // txt_sex
            // 
            txt_sex.Location = new Point(128, 97);
            txt_sex.Name = "txt_sex";
            txt_sex.Size = new Size(110, 27);
            txt_sex.TabIndex = 7;
            // 
            // txt_phone_number
            // 
            txt_phone_number.Location = new Point(128, 64);
            txt_phone_number.Name = "txt_phone_number";
            txt_phone_number.Size = new Size(110, 27);
            txt_phone_number.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(128, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(112, 27);
            txt_name.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Salary";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
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
            groupBox2.Location = new Point(0, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 152);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить департамент";
            // 
            // button4
            // 
            button4.Location = new Point(6, 120);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 64);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 1;
            label9.Text = "Location";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 32);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 0;
            label10.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(261, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(317, 142);
            dataGridView2.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(584, 5);
            button5.Name = "button5";
            button5.Size = new Size(146, 29);
            button5.TabIndex = 13;
            button5.Text = "Все департаменты";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btn_editSelectedAlbum
            // 
            btn_editSelectedAlbum.Location = new Point(736, 153);
            btn_editSelectedAlbum.Name = "btn_editSelectedAlbum";
            btn_editSelectedAlbum.Size = new Size(255, 29);
            btn_editSelectedAlbum.TabIndex = 14;
            btn_editSelectedAlbum.Text = "Редактровать данные сотрудника";
            btn_editSelectedAlbum.UseVisualStyleBackColor = true;
            btn_editSelectedAlbum.Click += btn_editSelectedAlbum_Click;
            // 
            // button7
            // 
            button7.Location = new Point(261, 390);
            button7.Name = "button7";
            button7.Size = new Size(138, 29);
            button7.TabIndex = 15;
            button7.Text = "Скорая помощь";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(405, 390);
            button8.Name = "button8";
            button8.Size = new Size(127, 29);
            button8.TabIndex = 16;
            button8.Text = "Врачи";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(538, 390);
            button9.Name = "button9";
            button9.Size = new Size(127, 29);
            button9.TabIndex = 17;
            button9.Text = "Персонал";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(671, 390);
            button10.Name = "button10";
            button10.Size = new Size(186, 29);
            button10.TabIndex = 18;
            button10.Text = "Младший мед персонал";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(863, 390);
            button11.Name = "button11";
            button11.Size = new Size(127, 29);
            button11.TabIndex = 19;
            button11.Text = "Пациенты";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 450);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(btn_editSelectedAlbum);
            Controls.Add(button5);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txt_salary;
        private TextBox txt_sex;
        private TextBox txt_phone_number;
        private TextBox txt_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox txt_department;
        private Label label5;
        private GroupBox groupBox2;
        private Button button4;
        private TextBox txt_staffnumber;
        private TextBox txt_location;
        private TextBox txt_depname;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView2;
        private Button button5;
        private Button button6;
        private CheckBox checkBox1;
        private Button btn_editSelectedAlbum;
        private Label lbl_empID;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}