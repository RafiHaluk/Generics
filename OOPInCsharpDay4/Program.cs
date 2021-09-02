using System;

namespace OOPInCsharpDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServices methods = new ProductServices();

            
            Product product1 = new Product();

            product1.ID = 85412;
            product1.CategoryID = 156;
            product1.ProductName = "Cansel's_Lipstick";
            product1.PricePerUnitI = 99999;
            product1.StockLeft = 1;

            Product product2 = new Product();

            product2.ID = 85999;
            product2.CategoryID = 157;
            product2.ProductName = "Haluk's_Stupid_Behaviors";
            product2.PricePerUnitI = 0.1;
            product2.StockLeft = 999999;

            ProductServices productServices = new ProductServices();
            productServices.Add(product1);
            //Console.WriteLine(product1.ProductName);//Kamera yapan line
            
            //line 30dan itibaren artık product1 Name kısmı Kamera Oldu.. ancak bu giden
            //bir int,double,bool gibi değer tip olsaydı değrimiz fonksiyondan sonra 
            //değişmeyecekti, öünkü o an sadece sayı değişkeninin içindeki değer fonksiyona gönderilir 
            //sayı değerinde değişme olmaz. Ancak "kamera" değeri bir referans tip olduğundan,
            //(diziler, classlar,abstract classlar,interface classlar,stringler)
            //herhangi bir fonksiyon içine giren bu referans tip değişkenleri değişime uprar ve öyle kalır...



        }
    }
}
