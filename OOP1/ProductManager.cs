using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int number1,int number2)
        {
            return number1 + number2;
        }
        public void Topla2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }

    }
}
