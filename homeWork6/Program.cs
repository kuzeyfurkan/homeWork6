using System;

namespace homeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunAdi = new string[]
                {"Elma","Armut","Karpuz","Mandalina","Portakal"
                ,"Çilek","Şeftali","Muz","Kavun","Muşmula"  };
            for (int i = 0; i < urunAdi.Length; i++)
            {
                Console.WriteLine(urunAdi[i]);
            }
            Console.WriteLine("For Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);

            foreach (var urun in urunAdi)
            {
                Console.WriteLine(urun);
            }
            Console.WriteLine("Foreach Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);
            
            int a = 0;
            while (a<urunAdi.Length)
            {
                Console.WriteLine(urunAdi[a]);
                a++;
            }
            Console.WriteLine("While Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);
            
            
            // Arrayler buraya kadardı./////////////////////////////////////////////////////////////////////////


            Product product1 = new Product();
            product1.urunId = "Salata";
            product1.urunTuru = "Sebze";
            product1.urunAdet = 350;
            product1.birimTuru = "Kilogram";

            Product product2 = new Product();
            product2.urunId = "Domates";
            product2.urunTuru = "Sebze";
            product2.urunAdet = 455;
            product2.birimTuru = "Kilogram";

            Product product3 = new Product();
            product3.urunId = "Domestos";
            product3.urunTuru = "Hijyen";
            product3.urunAdet = 80;
            product3.birimTuru = "Adet";
            
            Product[] products = new Product[] {product1,product2,product3 };
            for (int b = 0; b < products.Length; b++)
            {
                Console.Write(products[b].urunId + " ");
                Console.Write(products[b].urunTuru +" ");
                Console.Write(products[b].urunAdet +" ");
                Console.Write(products[b].birimTuru + Environment.NewLine);
            
            }
            
            Console.WriteLine("For Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);

            foreach (var product in products)
            {
                Console.WriteLine(product.urunId+" " + product.urunTuru+" " + product.urunAdet+" " + product.birimTuru);
                
            }
            Console.WriteLine("Foreach Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);

            int m = 0;
            while (m < products.Length)
            {
                Console.Write(products[m].urunId + " ");
                Console.Write(products[m].urunTuru + " ");
                Console.Write(products[m].urunAdet + " ");
                Console.Write(products[m].birimTuru + Environment.NewLine);
                m++;
            }
            Console.WriteLine("While Döngüsü İle Örnek Tamamlandı." + Environment.NewLine);
        }
        class Product
        {
            public string urunId { get; set; }
            public int urunAdet { get; set; }
            public string urunTuru { get; set; }
            public string birimTuru { get; set; }
        }
    }
}
