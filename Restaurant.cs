using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Practise
{
    public class Restaurant
    {
        //fields
        private readonly int restaurantId;
        private string name = "";
        private string address = "";
        private string owner = "";

        //properties
        public int RestaurantId 
        { 
            get 
            { 
                return restaurantId; 
            } 
        }

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

        //constructor
        public  Restaurant(string name , string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }

        //overloaded constructure
        public Restaurant()
        {
            
        }

    }
}
