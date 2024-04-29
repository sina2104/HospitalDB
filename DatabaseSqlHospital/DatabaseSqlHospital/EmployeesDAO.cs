using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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

        internal int addOneDepartment(Departments departments)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `department`(`Name`, `Location`, `Staff_number`) VALUES (@Dpname,@Dplocation,@staffnumber)", connection);

            command.Parameters.AddWithValue("@Dpname", departments.DpName);
            command.Parameters.AddWithValue("@Dplocation", departments.DpLocation);
            command.Parameters.AddWithValue("@staffnumber", departments.StaffNumber);


            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
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

        internal int deleteEmployee(int employeeID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("DELETE FROM `employees` WHERE `employees`.`ID` = @empID;", connection);

            command.Parameters.AddWithValue("@empID", employeeID);


            int result = command.ExecuteNonQuery();
            connection.Close();


            return result;
        }

        internal object getAllDepartments()
        {
            List<Departments> returnThese = new List<Departments>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM DEPARTMENT", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Departments departments = new Departments
                    {
                        ID = reader.GetInt32(0),
                        DpName = reader.GetString(1),
                        DpLocation = reader.GetString(2),
                        StaffNumber = reader.GetInt32(3)
                    };
                    returnThese.Add(departments);
                }
            }
            connection.Close();

            return returnThese;
        }

        internal int updateEmployee(Employees employees, int employeeID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("UPDATE EMPLOYEES SET `Name` = @name, `Phone_number` = @phonenumber, `Sex` = @sex, `Department_ID` = @departmentid, `Salary` = @salary WHERE `employees`.`ID` = @empID;", connection);

            command.Parameters.AddWithValue("@name", employees.Name);
            command.Parameters.AddWithValue("@phonenumber", employees.PhoneNumber);
            command.Parameters.AddWithValue("@sex", employees.Sex);
            command.Parameters.AddWithValue("@salary", employees.Salary);
            command.Parameters.AddWithValue("@departmentid", employees.DepartmentID);
            command.Parameters.AddWithValue("@empID", employeeID);


            int updatedRows = command.ExecuteNonQuery();
            connection.Close();


            return updatedRows;
        }
    }
}
