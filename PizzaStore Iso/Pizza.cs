using System;
public class Pizza
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    

    public Pizza(string name, decimal price)
    {
        Name = name;
        Price = price;
         
    }

    public override string ToString()
    {
        return $"{Name} {Price:C}"; 
    }
}




