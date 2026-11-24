using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{ }
public class Pizza
{
    private string name;
    private decimal price;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public Pizza(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public override string ToString()
    {
        return $"Pizza: {Name}, Price: {Price} kr.";
    }
}


