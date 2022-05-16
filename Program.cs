using System;

namespace ClassMetotDemo

{

  internal  class MusteriPortfoy

    {


        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[]
                 {
                new Customer() { Name = "Oguzcan", Surname ="Akyuz", Id = 36},
                new Customer() { Name = "Ahmet", Surname = "Kral", Id = 34 },
                new Customer() { Name = "Mehmet", Surname ="Pala", Id = 23 }
            };
                 customerManager.AddCustomer(customers[0]);
            customerManager.DeleteCustomer(customers[1]);

            Customer customer1 = new Customer() { Name = "Oguzcan", Id = 36, Surname="Akyuz" };
            Customer customer2 = new Customer() { Name = "Ahmet", Id = 24, Surname="Kral" };
            Customer customer3 = new Customer() { Name = "Mehmet", Id = 23, Surname="Pala" };
            Customer[] customers2 = new Customer[] { customer1, customer2, customer3 };

            customerManager.AddCustomer(customer1);
            Console.WriteLine("*******************");

            customerManager.DeleteCustomer(customer2);
            Console.WriteLine("*******************");

            customerManager.ListCustomers(customers);

            Console.WriteLine("*******************");

            customerManager.ListCustomers(customers2);
        }



        }
    }
