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
            //2.yol
            Product product2 = new Product { Id = 2, CategoryId = 3,ProductName="Kalem",
                UnitPrice=35,UnitsInStock=4 };
            //Pascal case  //camel Case
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
