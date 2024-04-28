using System.Xml.Linq;

namespace DatabaseSqlHospital
{
    public partial class Form1 : Form
    {
        BindingSource employeesBindingSource = new BindingSource();
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


            employeesBindingSource.DataSource = employeesDAO.getAllEmployees();
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
            int result = employeesDAO.addOneEmployee(employees);
            MessageBox.Show(result + " new row(s) added");
        }
    }
}