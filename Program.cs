using System;

namespace OOPS_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
             Restaurant rs = new Restaurant();
             rs.Name = "Resturant Name";
             rs.Owner = "Test Owner 1";

             Restaurant rs2 = new Restaurant("Resturant 2 Name"," Test Owner 2");

            Hotel h = new Hotel();
            h.Name = " ";
            h.Owner = " ";
            h.Address = " ";

            Hotel i = new Hotel("Ramada", "Owner1");     
            

            Hotel j = new Hotel("Ramada", "Owner2", "Delhi" );



            Cafe a = new Cafe();
            a.Name = " ";
            a.Owner = " ";
            a.Address = " ";

            Cafe b = new Cafe("Ramada", "Owner1");

            Cafe c = new Cafe("Ramada", "Owner2", "Delhi");

            Cafe d = new Cafe("Ramada", "Owner2", "Delhi", 12345);
        }
    }
}
