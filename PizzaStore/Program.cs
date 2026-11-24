
using System;

namespace PizzaStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Margherita", 75m);
            Pizza pizza2 = new Pizza("Pepperoni", 95m);
            Pizza pizza3 = new Pizza("Hawaii", 110m);

            Customer customer1 = new Customer("Peter", "12345678");
            Customer customer2 = new Customer("Maria", "87654321");
            Customer customer3 = new Customer("Anders", "11223344");

            Order order1 = new Order(1, pizza1, customer1);
            Order order2 = new Order(2, pizza2, customer2);
            Order order3 = new Order(3, pizza3, customer3);

            Console.WriteLine("BIG MAMMA PIZZERIA");
            Console.WriteLine("==========================");

            Console.WriteLine();

            Console.WriteLine("ORDER 1");
            Console.WriteLine("Pizza: " + order1.Pizza.Name);
            Console.WriteLine("Customer: " + order1.Customer.Name);
            Console.WriteLine("Total price: " +
                order1.CalculateTotalPrice() + " kr.");

            Console.WriteLine();

            Console.WriteLine("ORDER 2");
            Console.WriteLine("Pizza: " + order2.Pizza.Name);
            Console.WriteLine("Customer: " + order2.Customer.Name);
            Console.WriteLine("Total price: " +
                order2.CalculateTotalPrice() + " kr.");

            Console.WriteLine();

            Console.WriteLine("ORDER 3");
            Console.WriteLine("Pizza: " + order3.Pizza.Name);
            Console.WriteLine("Customer: " + order3.Customer.Name);
            Console.WriteLine("Total price: " +
                order3.CalculateTotalPrice() + " kr.");

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Thank you for ordering!");
        }
    }
}