using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Lab.Classes
{
    public class Bill_Class
    {
        private string id;
        private string customer;
        private string rec_date;
        private string delv_date;
        private string teethes;
        private string type;
        private string delv_state;
        private string color;
        private string price;
        private string notes;
        private string today;


        public Bill_Class( string id,
         string customer,
         string rec_date,
         string delv_date,
         string teethes,
         string type,
         string delv_state,
         string color,
         string price,
         string notes,
         string today) {
            this.id = id;
            this.customer = customer;
            this.rec_date = rec_date;
            this.delv_date = delv_date;
            this.teethes = teethes;
            this.type = type;
            this.delv_state = delv_state;
            this.color = color;
            this.price = price;
            this.notes = notes;
            this.today = today;

        } 
        public string Id {
            get { return id; }
        }
        public string Customer
        {
            get { return customer; }
        }
        public string RecDate
        {
            get
            {
                return rec_date;
            }
        }
        public string DelvDate
        {
            get
            {
                return delv_date;
            }
        }
        public string Teethes
        {
            get
            {
                return teethes;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string DelvState
        {
            get { return delv_state; }
        }
        public string Color
        {
            get
            {
                return color;
            }
        }
        public string Price
        {
            get
            {
                return delv_date;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }
        }
        public string Today
        {
            get
            {
                return today;
            }
        }
    }
}
