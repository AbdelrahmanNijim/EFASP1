using EFASP.Context;
using EFASP.Models;

namespace EFASP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

             Product e = new Product() { Name = "PS5" , Price= 2200 , Description="Console"};

             db.products.Add(e);
             db.SaveChanges();

             Console.WriteLine("don for products");

             Order O = new Order() {adress ="Yafa - Nblus 2 St -A2NU" , createdAt ="2023:12:10-13:06:10"};


             db.Orders.Add(O);
             db.SaveChanges();



             Console.WriteLine("don for orders");

            
            var products = db.products.ToList();

            foreach (var producto in products) {
            
              Console.WriteLine(producto.Id);
                Console.WriteLine(producto.Price);
                Console.WriteLine(producto.Description);


            }
            Console.WriteLine("--------------------");

            var orders= db.Orders.ToList();

            foreach (var orderos in orders)
            {
                Console.WriteLine(orderos.OrderId);
                Console.WriteLine(orderos.adress);
                Console.WriteLine(orderos.createdAt);

            }
            
              var product =db.products.First(prod =>prod.Name =="PS5");
             product.Name = "Xbox X";
             db.SaveChanges();

           var order = db.Orders.First(ord => ord.createdAt == "2023:12:10-13:06:10");
           order.createdAt = "1750:07:29";
           db.SaveChanges();
             

             var producte = db.products.First(prod => prod.Id == 2 );
            db.products.Remove(producte);
            db.SaveChanges();

            var ordere = db.Orders.First(ord => ord.OrderId == 3);
            db.Orders.Remove(ordere);
            db.SaveChanges();

             




        }
    }
}
