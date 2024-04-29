using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSqlHospital
{
    internal class Inpatient
    {
        public int ID { get; set; }
        public string Bloodtype { get; set; }
        public int Roomnumber { get; set; }
        public int CanteenID { get; set; }
        public int PatientID { get; set; }

    }
}
