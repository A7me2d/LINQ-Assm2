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




        }
    }
}
