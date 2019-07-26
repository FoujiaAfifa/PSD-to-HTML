using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqPracticeWebApp
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; private set; }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customerlist = new List<Customer>();

            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "A",
                Email = "a@gmail.com",
                Gender="Male"
            };

            customerlist.Add(customer1);

            Customer customer2 = new Customer
            {
                ID = 204,
                Name = "B",
                Email = "a@gmail.com",
                Gender = "Male"
            };

            customerlist.Add(customer2);


            Customer customer3 = new Customer
            {
                ID = 308,
                Name = "C",
                Email = "a@gmail.com",
                Gender = "Female"
            };

            customerlist.Add(customer3);


            Customer customer4 = new Customer
            {
                ID = 408,
                Name = "ADS",
                Email = "a@gmail.com",
                Gender = "Female"
            };

            customerlist.Add(customer4);


            Customer customer5 = new Customer
            {
                ID = 501,
                Name = "AGT",
                Email = "a@gmail.com",
                Gender = "Male"
            };

            customerlist.Add(customer5);


            return customerlist;
        }



    }
}