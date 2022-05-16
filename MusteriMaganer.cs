using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("New Customer Added : Name: " + customer.Name + " id: " + customer.Id + " age :" + customer.Surname);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer Deleted : Name: " + customer.Name + " id: " + customer.Id + " age :" + customer.Surname);

        }
        public void ListCustomers(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Listing Customer : " + "Name : " + customer.Name + " Id :" + customer.Id + " Age : " + customer.Surname);
            }

        }
    }
}
