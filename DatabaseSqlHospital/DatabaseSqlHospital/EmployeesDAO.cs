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
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=mydb;";
        public List<Employees> getAllEmployees()
        {
            List<Employees> returnThese = new List<Employees>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            
            connection.Open();

            return returnThese;

        }
    }
}
