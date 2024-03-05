using System;
using PizzaStore_Iso;
public class Order
{
    public Pizza Pizza { get; set; }
    public Customer Customer { get; set; }
    public bool IsTakeaway { get; set; }

    // 25% skat/moms
    private decimal TaxRate = 1.25M;
    private decimal DeliveryCost = 40M;

    public Order(Pizza pizza, Customer customer, bool isTakeaway)
    {
        Pizza = pizza;
        Customer = customer;
        IsTakeaway = isTakeaway;
    }

    public decimal CalculateTotalPrice()
    {
        decimal basePrice = Pizza.Price;
        decimal taxAmount = basePrice * TaxRate;
        decimal deliveryCharge = IsTakeaway ? DeliveryCost : 0;

        return basePrice + taxAmount + deliveryCharge;
    }

    public override string ToString()
    {
        string deliveryOption = IsTakeaway ? "Takeaway" : "Dine-in";
        return $"Order Info: Pizza: {Pizza.Name}, Customer: {Customer.Name}, Delivery Option: {deliveryOption}, Total Price: {CalculateTotalPrice()}";
    }
}
