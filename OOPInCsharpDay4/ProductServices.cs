using System;
using System.Collections.Generic;
using System.Text;

namespace OOPInCsharpDay4
{
    class ProductServices
    {
        //void:  
        public void Add(Product product)
        {

            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " Added. ");
            
        }
        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + " Updated. ");
        }
        
        
        }
    }

