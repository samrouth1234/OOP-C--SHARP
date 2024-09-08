
using System;

public class Product
{

    // create file 
    int product_id;
    string product_name;
    string product_description;
    decimal price;

    // construtor

    //public Product(int product_id, string product_name , string product_description , decimal price)
    //{
    //    this.product_id = product_id;
    //    this.product_name = product_name;
    //    this.product_description = product_description;
    //    this.price = price;
    //}

    // create get set
    public int ProductID // property
    {
        get { return product_id; }
        set { product_id = value; }
    }

    public string ProductName  // property
    {
        get { return product_name; }
        set { product_name = value; }
    }

    public string ProductDescription // property
    {
        get { return product_description; }
        set { product_description = value; }
    }

    public decimal Price // property
    {
        get { return price; }
        set { price = value; }
    }

    // Input Prodcut

    public void InputProduct()
    {
        Console.Write("Enter Product ID :");
        product_id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Product Name :");
        product_name = Console.ReadLine();
        Console.Write("Enter Product Description :");
        product_description = Console.ReadLine();
        Console.Write("Enter Product Price :");
        price = Convert.ToDecimal(Console.ReadLine());
    }

    // show product 
    public void ShowProduct()
    {
        Console.WriteLine($"ID: {product_id,5}");
        Console.WriteLine($"ProductName: {product_name,-20}");
        Console.WriteLine($"ProductDescription: {product_description,-30}");
        Console.WriteLine($"Price: {price,10:C}"); // :C = $
    }
}
