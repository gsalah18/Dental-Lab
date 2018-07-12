using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Lab.Classes
{
    public class Warrnity_Class
    {
        public Warrnity_Class(string patient,string doctor,string doc_type,string bill,string peroid,string start_date) { 
            Period = peroid;
            StartDate = start_date;
            Patient = patient;
            Doctor = doctor;
            DocType = doc_type;
            Bill = bill;
        }
        public string Patient
        {
            set;
            get;
        }
        public string Doctor
        {
            set;
            get;
        }
        public string DocType
        {
            get;
            set;
        }
        public string Bill
        {
            set;
            get;
        }

        public string Period
        {
            set;
            get;
        }
        public string StartDate
        {
            set;
            get;
        }
        
    }
}
