using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqlHospital
{
    internal class EmployeesDAO
    {
        string connectionString = 
            "datasource=localhost;port=3306;username=root;password=root;database=mydb;";
        public List<Employees> getAllEmployees()
        {
            List<Employees> returnThese = new List<Employees>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM EMPLOYEES", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employees employees = new Employees
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Salary = reader.GetString(4),
                        DepartmentID = reader.GetInt32(5),
                    };
                    returnThese.Add(employees);
                }
            }
            connection.Close();

            return returnThese;

        }
        public List<Employees> searchEmployee(string searchTerm)
        {
            List<Employees> returnThese = new List<Employees>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String searchPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM EMPLOYEES WHERE NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employees employees = new Employees
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Salary = reader.GetString(4),
                        DepartmentID = reader.GetInt32(5),
                    };
                    returnThese.Add(employees);
                }
            }
            connection.Close();

            return returnThese;

        }

        internal int addOneEmployee(Employees employees)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `employees`(`Name`, `Phone_number`, `Sex`, `Salary`, `Department_ID`) VALUES (@name,@phonenumber,@sex,@salary,@departmentid)", connection);

            command.Parameters.AddWithValue("@name", employees.Name);
            command.Parameters.AddWithValue("@phonenumber", employees.PhoneNumber);
            command.Parameters.AddWithValue("@sex", employees.Sex);
            command.Parameters.AddWithValue("@salary", employees.Salary);
            command.Parameters.AddWithValue("@departmentid", employees.DepartmentID);

            
            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }
    }
}
