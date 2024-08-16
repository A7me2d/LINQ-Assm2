using ASSLINQ;
using System.Collections;
using static ASSLINQ.ListGenerator;


namespace LINQ_Assm2
{
    internal class Program
    {
        static void Main()
        {

            #region Filteration Operarors
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            //var Result = ProductList.Where(P => { return P.Category == "Meat/Poultry" && P.UnitsInStock > 0; });

            //Result = from p in ProductList
            //         where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //         select p;

            //var Result = ProductList.Where((P, I) => P.UnitsInStock == 0 && I < 10);

            //var Result = ProductList.Where((P, I) => I < 5 & P.UnitsInStock > 0);

            //ArrayList list = new ArrayList() { "Ahmed" , 1 , "Hany" , 12 , "Makram" , 1.5 , 23 , 'A' };

            //var Result = list.OfType<double>(); 


            //foreach (var item in Result) 
            //{ 
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Transformation
            //var Result = ProductList.Select(P => { return P.ProductName; });

            //var Result = CustomerList.Select(C => { return C.CustomerName; });


            //var Result = ProductList.Select(P => { return new {Id = P.ProductID, Name = P.ProductName}; });

            //var Result = from P in ProductList
            //             select new
            //             {
            //                 P.ProductID,
            //                 P.ProductName
            //             };

            //var Result = CustomerList.Select(C => C.Orders);

            //var Result = CustomerList.SelectMany(C => C.Orders);

            //var Result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Select(P =>
            //new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //});

            //var Result = ProductList.Select((P, I) => new { I, P.ProductName });


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Ordering
            //var Result = ProductList.OrderBy(P => P.UnitPrice);
            //var Result = ProductList.OrderByDescending(P => P.UnitPrice);

            //var Result = from P in ProductList
            //             orderby P.UnitPrice ascending
            //             select P;

            //var Result = ProductList.Select(P => new { P.ProductName, P.UnitsInStock, P.UnitPrice })
            //                        .OrderBy(P => P.UnitsInStock)
            //                        .ThenByDescending(P => P.UnitPrice);

            //var Result = from P in ProductList
            //             orderby P.UnitsInStock, P.UnitPrice descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitsInStock,
            //                 P.UnitPrice
            //             };

            //var Result = ProductList.Reverse<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Element Operators
            //ProductsList = new List<Product>();

            //var Result = ProductList.First();

            //var Result = ProductList.Last();


            //var Result = ProductList.FirstOrDefault();


            //var Result = ProductList.LastOrDefault();

            //var Result = ProductList.First(P => P.UnitsInStock == 1000);

            //var Result = ProductList.Last(P => P.UnitsInStock == 1000);

            //var Result = ProductList.FirstOrDefault();

            //var Result = ProductList.FirstOrDefault(new Product() { ProductName = "Dafualt Product"});

            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000 , new Product() { ProductName = "Dafualt Product" });

            //ProductList.LastOrDefault();

            //var Result = ProductList.ElementAt(1000); 

            //var Result = ProductList.ElementAtOrDefault(1000); 

            //ProductList = new List<Product> () { new Product() { ProductName = " Only One Product"} };

            //ProductList = new List<Product>();

            //var Result = ProductList.Single();

            //var Result = ProductList.Single(P => P.ProductID == 1);

            //var Result = ProductList.SingleOrDefault();

            //var Result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Product"});

            //var Result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000);

            //var Result = ProductList.SingleOrDefault(P => P.UnitsInStock == 1000 , new Product() {  ProductName = "Default Product" });

            //ProductList = new List<Product>();

            //var Result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default Value if The List is Emply" });

            //foreach (var item in Result) 
            //{
            //    Console.WriteLine(item);
            //}


            #endregion



        }
    }
}
