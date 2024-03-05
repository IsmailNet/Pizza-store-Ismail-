using System;
using PizzaStore_Iso;

public class Store
{
    public void Start()
    {
        // Opretter pizzaer
        Pizza pizza1 = new Pizza("Margherita", 39);
        Pizza pizza2 = new Pizza("Pepperoni", 59);
        Pizza pizza3 = new Pizza("Hawaiian", 79);
        Pizza Pizza4 = new Pizza("Zealand pizza", 69);

        // Opretter kunder
        Customer customer1 = new Customer("Ismail");
        Customer customer2 = new Customer("Miki");
        Customer customer3 = new Customer("CEO-Oliver");
        Customer customer4 = new Customer("Jacob");


        // Opretter ordrer med angivelse af leveringsmulighed
        Order order1 = new Order(pizza1, customer1, true); // Takeaway
        Order order2 = new Order(pizza2, customer2, false); // Dinein
        Order order3 = new Order(pizza3, customer3, true); // Takeaway
        Order order4 = new Order(Pizza4, customer4, false);// Dinein

        // Ordreinformation
        Console.WriteLine(order1);
        Console.WriteLine(order2);
        Console.WriteLine(order3);
        Console.WriteLine(order4);
    }
}


