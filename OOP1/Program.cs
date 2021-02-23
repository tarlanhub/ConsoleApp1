﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product() { Id = 2, CategoryId = 5, ProductName = "kalam", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Add(product2);
            Console.WriteLine(product2.ProductName);
        }
    }
}
