using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //Kimlik numarası gibi düşünülebilir ID.
        public int Id { get; set; }
        //Hangi kategoriye ait.
        public int CategoryId { get; set; }
        //Ürün isimi.
        public string ProductName { get; set; }
        //Ürün birim fiyatı.
        public double UnitPrice { get; set; }
        //Ürün stok adedi.
        public int UnitsInStock { get; set; }
    }
}
