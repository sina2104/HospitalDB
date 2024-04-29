using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSqlHospital
{
    public partial class patients : Form
    {
        BindingSource patientBindingSource = new BindingSource();
        BindingSource externalpatientBindingSource = new BindingSource();
        BindingSource inpatientBindingSource = new BindingSource();

        List<Patient> patient = new List<Patient>();
        List<Inpatient> inpatient = new List<Inpatient>();
        List<External_patient> external_patient = new List<External_patient>();

        public patients()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patient patients = new Patient
            {
                Full_name = txt_name.Text,
                Age = Int32.Parse(txt_age.Text),
                Passport = txt_passport.Text
            };

            PatientsDAO patientsDAO = new PatientsDAO();
            if (checkBox1.Checked)
            {
                int patientID = int.Parse(lbl_patientID.Text);
                int result = patientsDAO.updatePatient(patients, patientID);
                MessageBox.Show(result + " row(s) updated");
            }
            else
            {
                int result = patientsDAO.addOnePatient(patients);
                MessageBox.Show(result + " new row(s) inserted");
            }


            txt_name.Clear();
            txt_age.Clear();
            txt_passport.Clear();
            lbl_patientID.Text = "";
            checkBox1.Checked = false;

            patient = patientsDAO.getAllPatients();
            dataGridView1.DataSource = patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientsDAO patientsDAO = new PatientsDAO();

            patient = patientsDAO.getAllPatients();
            patientBindingSource.DataSource = patient;
            dataGridView1.DataSource = patientBindingSource;
        }

        private void btn_editSelectedAlbum_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            Patient editMe = patient[rowClicked];
            txt_name.Text = editMe.Full_name;
            txt_age.Text = editMe.Age.ToString();
            txt_passport.Text = editMe.Passport;

            checkBox1.Checked = true;
            lbl_patientID.Text = editMe.ID.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Externalpatient externalpatient = new Externalpatient
            {
                Address = txt_address.Text,
                PhoneNumber = txt_phonenumber.Text,
                PatientID = Int32.Parse(txt_patientid_1.Text)
            };

            PatientsDAO patientsDAO = new PatientsDAO();
            int result = patientsDAO.addOneExternalpatient(externalpatient);
            MessageBox.Show(result + " new row(s) added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientsDAO patientsDAO = new PatientsDAO();


            patientBindingSource.DataSource = patientsDAO.searchPatient(textBox1.Text);
            dataGridView1.DataSource = patientBindingSource;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
