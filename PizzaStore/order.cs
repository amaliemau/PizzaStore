using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Order
    {

        private int orderId;
        private Pizza pizza;
        private Customer customer;
        private decimal deliveryCost;
        private decimal vatRate;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public Pizza Pizza
        {
            get { return pizza; }
            set { pizza = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public decimal DeliveryCost
        {
            get { return deliveryCost; }
            set { deliveryCost = value; }
        }

        public decimal VatRate
        {
            get { return vatRate; }
            set { vatRate = value; }
        }

        public Order(int orderId, Pizza pizza, Customer customer)
        {
            this.orderId = orderId;
            this.pizza = pizza;
            this.customer = customer;

            deliveryCost = 40m;
            vatRate = 0.25m;
        }

        public decimal CalculateTotalPrice()
        {
            decimal priceWithVAT = pizza.Price * (1 + vatRate);

            decimal totalPrice = priceWithVAT + deliveryCost;

            return totalPrice;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderId}, " +
                   $"Pizza: {Pizza.Name}, " +
                   $"Customer: {Customer.Name}, " +
                   $"Total price: {CalculateTotalPrice():0.00} kr.";
        }
    }
}
