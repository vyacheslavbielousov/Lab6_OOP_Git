using System;

public class Product
{
    public string Name { get; set; }
    public DateTime ExpiryDate { get; set; }  

    public Product(string name, DateTime expiryDate)
    {
        Name = name;
        ExpiryDate = expiryDate;
    }
    public bool IsExpired()
    {
        return DateTime.Now > ExpiryDate;
    }
}