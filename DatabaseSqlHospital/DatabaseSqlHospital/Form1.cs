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
    }
}