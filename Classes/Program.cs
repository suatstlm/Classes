using System;

namespace Classes
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();

            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Update();

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FristName = "Saut";
            customer2.LastName = "Satilmis";
            customer2.City = "Sivas";

            Customer customer1 = new Customer()
            {
                Id = 1,
                FristName = "Umut",
                LastName = "Cay",
                City = "Istanbul"
            };

            Customer[] customers = new Customer[2] {customer1 , customer2};

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FristName +" "+ customer.LastName);
            }

        }

    }
}
