using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqlHospital
{
    internal class PatientsDAO
    {
        string connectionString =
            "datasource=localhost;port=3306;username=root;password=root;database=mydb;";

        internal int addOnePatient(Patient patient)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `patient`(`Full_name`, `Age`, `Passport`) VALUES (@name,@age,@passport)", connection);

            command.Parameters.AddWithValue("@name", patient.Full_name);
            command.Parameters.AddWithValue("@age", patient.Age);
            command.Parameters.AddWithValue("@passport", patient.Passport);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int updatePatient(Patient patient, int patientID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("UPDATE `patient` SET `Full_name` = @name, `Age` = @age, `Passport` = @passport WHERE `patient`.`ID` = @patientID;", connection);

            command.Parameters.AddWithValue("@name", patient.Full_name);
            command.Parameters.AddWithValue("@age", patient.Age);
            command.Parameters.AddWithValue("@passport", patient.Passport);
            command.Parameters.AddWithValue("@patientID", patientID);


            int updatedRows = command.ExecuteNonQuery();
            connection.Close();


            return updatedRows;
        }

        public List<Patient> getAllPatients()
        {
            List<Patient> returnThese = new List<Patient>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `patient`", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Patient patient = new Patient
                    {
                        ID = reader.GetInt32(0),
                        Full_name = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Passport = reader.GetString(3)
                    };
                    returnThese.Add(patient);
                }
            }
            connection.Close();

            return returnThese;
        }

        internal object searchPatient(string searchTerm)
        {
            List<Patient> returnThese = new List<Patient>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String searchPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM `patient` WHERE `Full_name` LIKE @search";
            command.Parameters.AddWithValue("@search", searchPhrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Patient patient = new Patient
                    {
                        ID = reader.GetInt32(0),
                        Full_name = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Passport = reader.GetString(3)
                    };
                    returnThese.Add(patient);
                }
            }
            connection.Close();

            return returnThese;
        }

        internal int addOneExternalpatient(Externalpatient externalpatient)
        {
            throw new NotImplementedException();
        }
    }
}
