using System.Xml.Linq;

namespace DatabaseSqlHospital
{
    public partial class Form1 : Form
    {
        BindingSource employeesBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        List<Employees> employee = new List<Employees>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();

            employee = employeesDAO.getAllEmployees();
            employeesBindingSource.DataSource = employee;
            dataGridView1.DataSource = employeesBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();


            employeesBindingSource.DataSource = employeesDAO.searchEmployee(textBox1.Text);
            dataGridView1.DataSource = employeesBindingSource;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees
            {
                Name = txt_name.Text,
                PhoneNumber = txt_phone_number.Text,
                Salary = txt_salary.Text,
                Sex = txt_sex.Text,
                DepartmentID = Int32.Parse(txt_department.Text)
            };

            EmployeesDAO employeesDAO = new EmployeesDAO();
            if (checkBox1.Checked)
            {
                int employeeID = int.Parse(lbl_empID.Text);
                int result = employeesDAO.updateEmployee(employees, employeeID);
                MessageBox.Show(result + " row(s) updated");
            }
            else
            {
                int result = employeesDAO.addOneEmployee(employees);
                MessageBox.Show(result + " new row(s) inserted");
            }


            txt_name.Clear();
            txt_phone_number.Clear();
            txt_sex.Clear();
            txt_salary.Clear();
            txt_department.Clear();
            lbl_empID.Text = "";
            checkBox1.Checked = false;

            employee = employeesDAO.getAllEmployees();
            dataGridView1.DataSource = employee;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departments departments = new Departments
            {
                DpName = txt_depname.Text,
                DpLocation = txt_location.Text,
                StaffNumber = Int32.Parse(txt_staffnumber.Text)
            };

            EmployeesDAO employeesDAO = new EmployeesDAO();
            int result = employeesDAO.addOneDepartment(departments);
            MessageBox.Show(result + " new row(s) added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeesDAO employeesDAO = new EmployeesDAO();


            departmentBindingSource.DataSource = employeesDAO.getAllDepartments();
            dataGridView2.DataSource = departmentBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            MessageBox.Show("You clicked row " + rowClicked);
            int employeeID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track " + employeeID);

            EmployeesDAO employeesDAO = new EmployeesDAO();

            int result = employeesDAO.deleteEmployee(employeeID);

            MessageBox.Show("Result " + result);

            employee = employeesDAO.getAllEmployees();
        }

        private void btn_editSelectedAlbum_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            Employees editMe = employee[rowClicked];
            txt_name.Text = editMe.Name;
            txt_phone_number.Text = editMe.PhoneNumber;
            txt_sex.Text = editMe.Sex;
            txt_salary.Text = editMe.Salary;
            txt_department.Text = editMe.DepartmentID.ToString();

            checkBox1.Checked = true;
            lbl_empID.Text = editMe.ID.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new doctors();
            newForm.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            var newForm = new patients();
            newForm.Show();

        }
    }
}