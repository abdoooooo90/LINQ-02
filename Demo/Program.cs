using System.Collections;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            #region First - Last
            //var Result = ProductList.First();
            //// Get First Element At Sequence
            //var Result = ProductList.Last();
            //// Get First Element At Sequence
            //Console.WriteLine(Result);
            //-------------------------------
            //List<Product> products = new List<Product>();
            //var Result = products.First(); //Unhandled exception. System.InvalidOperationException
            //Console.WriteLine(Result);
            //var Result = products.Last(); //Unhandled exception. System.InvalidOperationException
            //First And Last May Throw Exception => If The Sequence Is Empty
            //------------------------------------------
            //var Result = ProductList.First(P => P.UnitsInStock == 0); //Get First Element At Sequence That Match The Condition 
            //var Result = ProductList.Last(P => P.UnitsInStock == 999);
            //Console.WriteLine(Result);
            #endregion

            #region FirstOrDefault - LastOrDefault            
            //List<Product> TestProduct = new List<Product>();
            //var Result = TestProduct.FirstOrDefault();
            // Get First Element In Sequence If Sequence Is Empty Will Retrun Null
            //var Result = TestProduct.LastOrDefault();
            // Get Last Element In Sequence If Sequence Is Empty Will Retrun Null
            //Console.WriteLine(Result?.ProductName?? "Not Found");
            #endregion

            #region ElementAt - ElementAtOrDefault            
            //var Result = ProductList.ElementAt(77);
            //Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range.
            //-------------------------------------------
            //var Result = ProductList.ElementAtOrDefault(77);
            //Console.WriteLine(Result?.ProductName?? "Not Found");

            #endregion

            #region Single - SingleOrDefault
            //var Result = ProductList.Single(P => P.UnitsInStock == 0);
            // Invalid OperationException : Sequence Contains More Then One Element Math Condition
            // Single Will Retrun It If  Sequence Contains Only One Element Math Condition 
            // If The Sequence Contains More Then One Element Math Condition Or The Sequence Is Empty Will Throw Excption
            //----------------------------------
            //var Result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result?.ProductName?? "Not Found");
            #endregion

            #endregion

            #region Aggregate Operators
            #region Count
            //var Result = ProductList.Count();
            //var Result = ProductList.Count(P => P.UnitPrice == 0);
            //Console.WriteLine(Result);
            #endregion

            #region Min - Max
            //var Result = ProductList.Min(); //Unhandled exception. System.ArgumentException:
            //var Result = ProductList.Max();
            //Console.WriteLine(Result);
            //--------------------------------
            //var Result = ProductList.Min(P => P.ProductName.Length);
            //Console.WriteLine(Result);
            #endregion

            #region Sum - Avg
            //var Result = ProductList.Sum(P => P.UnitPrice);
            //var Result = ProductList.Average(P => P.UnitPrice);
            //Console.WriteLine(Result);

            #endregion

            #region Aggregate
            //string[] name = { "Ali", "Omar", "Mohamed", "Ahmed" };
            //var Result = name.Aggregate((str01, str02) => $"{str01} {str02}");
            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region Casting Operators
            //List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] Result = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //-----------------------------
            // Dictionary<long, Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            //--------------------------
            //HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------
            //ArrayList obj = new ArrayList()
            //{
            //    "Ali",
            //    "Moohamed",
            //    "Abdo",
            //    1,2,3, 'A'
            //};
            //var Result = obj.OfType<string>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generation Operators - Deferred Execution
            //var Result = Enumerable.Range(0, 100); // 0-99
            //var Result = Enumerable.Repeat(2, 100);
            //---------------------
            //var Result = Enumerable.Empty<Product>().ToArray();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}                                     

            #endregion

            #region Set Operators
            var Seq01 = Enumerable.Range(0, 100);
            var Seq02 = Enumerable.Range(50, 100);
            #region Union
            //var Result = Seq01.Union(Seq02);
            //Console.WriteLine("Seq01");
            //foreach (var Seq in Seq01)
            //{
            //    Console.WriteLine(Seq);
            //}
            //Console.WriteLine("Seq02");
            //foreach (var Seq in Seq02)
            //{
            //    Console.WriteLine(Seq);
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Count
            //var Result = Seq01.Concat(Seq02);
            //Console.WriteLine("Seq01");
            //foreach (var Seq in Seq01)
            //{
            //    Console.WriteLine(Seq);
            //}
            //Console.WriteLine("Seq02");
            //foreach (var Seq in Seq02)
            //{
            //    Console.WriteLine(Seq);
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Intersect
            //var Result = Seq01.Intersect(Seq02);
            //Console.WriteLine("Seq01");
            //foreach (var Seq in Seq01)
            //{
            //    Console.WriteLine(Seq);
            //}
            //Console.WriteLine("Seq02");
            //foreach (var Seq in Seq02)
            //{
            //    Console.WriteLine(Seq);
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Except
            //var Result = Seq01.Except(Seq02);
            //Console.WriteLine("Seq01");
            //foreach (var Seq in Seq01)
            //{
            //    Console.WriteLine(Seq);
            //}
            //Console.WriteLine("Seq02");
            //foreach (var Seq in Seq02)
            //{
            //    Console.WriteLine(Seq);
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
        }
    }
}
