using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Console.WriteLine("**** Order #1 *****");
        Address address1 = new Address("123 Maple St.", "Denver", "CO", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Organic Bananas", "4011", 0.30, 5);
        Product order1Product2 = new Product("Almond Milk", "7890", 3.50, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel();
        order1.DisplayPackingLabel();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);
        Console.WriteLine("---------------------------------------------\n");

        // Second Order
        Console.WriteLine("**** Order #2 *****");
        Address address2 = new Address("456 Oak Rd.", "Seattle", "WA", "USA");
        Customer customer2 = new Customer("Bob Smith", address2);
        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Whole Wheat Bread", "0012", 2.50, 2);
        Product order2Product2 = new Product("Cheddar Cheese", "0025", 5.00, 1);
        Product order2Product3 = new Product("Green Tea", "0301", 4.50, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();

        order2.DisplayShippingLabel();
        order2.DisplayPackingLabel();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");
    }
}