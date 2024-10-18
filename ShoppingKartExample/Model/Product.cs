﻿public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double DiscountPercent { get; set; }

    public Product(int id, string name, double price, double discountPercent)
    {
        Id = id;
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }

    public double CalculateDiscountedPrice()
    {
        return Price - (Price * DiscountPercent / 100);
    }
}