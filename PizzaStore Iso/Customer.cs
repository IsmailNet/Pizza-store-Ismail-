﻿using System;
public class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

