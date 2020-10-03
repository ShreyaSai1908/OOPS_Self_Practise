using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Practise
{
    class Cafe
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        private string owner = "";
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                this.owner = value;
            }
        }
        private string address = "";
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }
        private int cafeId;
        public int CafeId
        {
            get
            {
                return cafeId;
            }
            set
            {
                this.cafeId = value;
            }
        }

        public Cafe()
        {

        }

        public Cafe(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        public Cafe(string name, string owner, string address)
        {
            this.Name = name;
            this.Owner = owner;
            this.Address = address;
        }

        public Cafe(string name, string owner, string address, int cafeId)
        {
            this.Name = name;
            this.Owner = owner;
            this.Address = address;
            this.CafeId = cafeId;
        }


    }
}