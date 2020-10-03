using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OOPS_Practise
{
    class Hotel
    {
        private string name = "";
        private string address = "";
        private string owner = "";

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {

            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {

            }
        }

        //constructor
        public Hotel ()
        {

        }

        //overloaded constructor

        public Hotel(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public Hotel(string name, string address, string owner)
        {
            this.Name = name;
            this.Address = address;
            this.Owner = owner;
        }
    }
}
