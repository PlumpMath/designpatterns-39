using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Common
{
    public class Cargo
    {
        private int id;
        private string customerName;
        private string customerPhone;
        private string customerAdress;
        private string customerIDNumber;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public string CustomerAdress
        {
            get { return customerAdress; }
            set { customerAdress = value; }
        }
        public string CustomerIDNumber
        {
            get { return customerIDNumber; }
            set { customerIDNumber = value; }
        }
    }
}
