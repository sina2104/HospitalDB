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
            button3 = new Button();
            txt_salary = new TextBox();
            txt_sex = new TextBox();
            txt_phone_number = new TextBox();
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txt_department = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(260, 30);
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
            dataGridView1.Location = new Point(251, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(537, 188);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(404, 30);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 2;
            button2.Text = "Искать по ФИО сотрудника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(619, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(-1, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 231);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить сотрудника";
            // 
            // button3
            // 
            button3.Location = new Point(6, 196);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Добавить";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 164);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 9;
            label5.Text = "Department ID";
            // 
            // txt_department
            // 
            txt_department.Location = new Point(128, 164);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(112, 27);
            txt_department.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}