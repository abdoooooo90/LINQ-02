using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using static LINQ_02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            #region 1. Get first Product out of Stock 
            //var Result01 = ProductList.First(P => P.UnitsInStock ==0);
            //Console.WriteLine(Result01);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result?.ProductName ?? "Not Found");
            #endregion

            #region 3. Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(A => A > 5).ElementAt(1);
            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(A => A % 2 == 1);
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomerList.Select(C => new
            //{
            //    CustomerName = C.CustomerName,
            //    OrderCount = C.Orders.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Result = ProductList.Select(P => new
            //{
            //    Category = P.Category,
            //    ProductCount = P.ProductName.Count()
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region Q5, Q6, Q7, Q8
            //string path = "C:/Users/abdos/OneDrive/Desktop/.net/C#/LINQ/LINQ 02/LINQ 02/bin/Debug/net8.0/dictionary_english.txt";
            //string[] content = File.ReadAllLines(path);
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result = content.Sum(x => x.Length);
            //Console.WriteLine(Result);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var Result = content.Min(x => x.Length);
            //Console.WriteLine(Result);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //var Result = content.Max(x => x.Length);
            //Console.WriteLine(Result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            //var Result = content.Average(A => A.Length);
            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region 9. Get the total units in stock for each product category.
            //var Total = ProductList.GroupBy(P => P.Category).Select(G => new
            //{ 
            //    Category = G.Key, Stock = G.Sum(P => P.UnitsInStock)
            //});
            //foreach (var item in Total)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(P => P.Category).Select(C => new
            //{
            //    Category = C.Key,
            //    CheapestPrice = C.Min(P => P.UnitPrice)
            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var Result = from P in ProductList
            //             let CheapestPrice = (
            //             from P2 in ProductList
            //             where P2.Category == P.Category
            //             select P2.UnitPrice
            //             ).Min()
            //             where P.UnitPrice == CheapestPrice
            //             select P;
            //foreach ( var P in Result )
            //{
            //    Console.WriteLine( P );
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var Result = ProductList.GroupBy(P => P.Category).Select(E => new
            //{
            //    Category = E.Key,
            //    ExpensivePrice = E.Max(U => U.UnitPrice)
            //});
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //var Result = ProductList.GroupBy(P => P.Category).Select(G => G.OrderByDescending(P => P.UnitPrice).First());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 14. Get the average price of each category's products.
            //var Result = ProductList.GroupBy(C => C.Category).Select(P => new
            //{
            //    Cateegory = P.Key,
            //    AvgPrice = P.Average(P => P.UnitPrice)
            //});
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Set Operators
            #region 1. Find the unique Category names from Product List
            //var Result = ProductList.Select(P => P.Category).Distinct();
            //foreach ( var item in Result ) 
            //    Console.WriteLine(item);
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Union(CustomerList.Select(C => C.CustomerName[0])).Distinct();
            //foreach(var item  in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Intersect(CustomerList.Select(C => C.CustomerName[0]));
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName).Concat(CustomerList.
            //    Select(C => C.CustomerName.Length >= 3? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName));
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var Result = CustomerList.Where(W => W.City == "Washington").Select(O => O.Orders).Take(3);
            //foreach(var Customer in Result)
            //{
            //    Console.WriteLine(Customer);
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList.Where(W => W.City == "Washington").SelectMany(O => O.Orders).Skip(2);
            //foreach (var Customer in Result)
            //{
            //    Console.WriteLine(Customer);
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((N, I) => N > I);
            //foreach ( var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(N => N % 3 != 0);
            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((N, I) => N > I);
            //foreach ( var i in Result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion

            #region Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string path = "C:/Users/abdos/OneDrive/Desktop/.net/C#/LINQ/LINQ 02/LINQ 02/bin/Debug/net8.0/dictionary_english.txt";
            //string[] content = File.ReadAllLines(path);
            //var Result = content.Any(W => W.Contains("ei"));
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result = ProductList.GroupBy(C => C.Category).Where(P => P.Any(S => S.UnitsInStock == 0));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductList.GroupBy(C => C.Category).Where(P => P.All(S => S.UnitsInStock > 0));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion

            #endregion

            #region Grouping Operators
            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(N => N % 5);
            //foreach(var item in Result)
            //{
            //    Console.WriteLine($"Number With Remainder Of {item.Key} When Divid By 5: ");
            //    foreach (var item2 in item)
            //        Console.WriteLine(item2);
            //}
            #endregion

            #region 2. Uses group by to partition a list of words by their first letter Use dictionary_english.txt for Input
            //string path = "C:/Users/abdos/OneDrive/Desktop/.net/C#/LINQ/LINQ 02/LINQ 02/bin/Debug/net8.0/dictionary_english.txt";
            //string[] content = File.ReadAllLines(path);
            //var Result = content.GroupBy(N => N[0]);
            //foreach ( var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Consider this Array as an Input
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var Result = Arr.GroupBy(W => new string(W.OrderBy(C => C).ToArray()).ToList());
            //foreach ( var item in Result)
            //{
            //    foreach(var i in item)
            //        Console.WriteLine(i);
            //    Console.WriteLine(".......");
            //}
            #endregion

            #endregion

        }
    }
}
