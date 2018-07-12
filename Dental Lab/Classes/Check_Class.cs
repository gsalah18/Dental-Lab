using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Lab.Classes
{
    public class Check_Class
    {
        private string id;
        private string bank;
        private string owner;
        private DateTime delv_date;
        private double price;
        private string notes;
        private Image img;
        
        public Check_Class(string id,string bank,string owner,DateTime delv_date,double price,string notes,Image img)
        {
            this.id = id;
            this.bank = bank;
            this.owner = owner;
            this.delv_date = delv_date;
            this.price = price;
            this.notes = notes;
            this.img = img;
        }
        public Image IMG
        {
            set
            {
                this.img = value;
            }
            get { return this.img; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Bank
        {
            get { return this.bank; }
            set { this.bank = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public DateTime Delv_Date
        {
            get { return this.delv_date; }
            set { this.delv_date = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

    }
}
