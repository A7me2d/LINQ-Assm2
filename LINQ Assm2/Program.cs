
using ASSLINQ;
using static ASSLINQ.ListGenerator;

namespace LINQ_Assm2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operators

            #region 1. Find all products that are out of stock
            //var Result = ProductList.Where(P => P.UnitsInStock == 0)
            //                        .ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit
            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M)
            //                        .ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3.  Returns digits whose name is shorter than their value
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Select((name, index) => new { Name = name, Value = index })
            //                .Where(x => x.Name.Length < x.Value)
            //                .ToList();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #endregion

            #region Element Operators
            #region 1. Get first Product out of Stock
            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //if (Result != null)
            //{
            //    Console.WriteLine(Result.ProductName);
            //}
            //else
            //{
            //    Console.WriteLine("No out-of-stack products found");
            //}
            #endregion

            #region 2. Return the first product
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            //if (Result == null) { Console.WriteLine(Result.ProductName); }
            //else { Console.WriteLine("No products with price greater than 1000 found."); }

            #endregion

            #region Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr
            //                      .Where(n => n > 5)
            //                      .Skip(1)
            //                      .FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion
            #endregion

            #region Aggregate Operators
            #region 1. Count the number of odd numbers in the array:

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddCount = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine($"Number of odd numbers: {oddCount}");

            #endregion

            #region 2. Return a list of customers and how many orders each has:
            //var customerOrderCounts = CustomerList
            //              .Select(c => new
            //              {
            //                  CustomerName = c.CustomerName,
            //                  OrderCount = c.Orders.Count()
            //              })
            //              .ToList();

            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"{customer.CustomerName} has {customer.OrderCount} orders.");
            //}


            #endregion

            #region 3. Return a list of categories and how many products each has

            //var categoryProductCounts = ProductList
            //                .GroupBy(p => p.Category)
            //                .Select(g => new
            //                {
            //                    CategoryName = g.Key,
            //                    ProductCount = g.Count()
            //                })
            //                .ToList();

            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"{category.CategoryName} has {category.ProductCount} products.");
            //}


            #endregion

            #region 4. Get the total of the numbers in an array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int totalSum = Arr.Sum();

            //Console.WriteLine($"Total sum: {totalSum}");


            #endregion

            #region 5. Get the total number of characters
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");

            //int totalCharacters = dictionaryWords.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters: {totalCharacters}");

            #endregion

            #region 6. Get the length of the shortest
            //int shortestWordLength = dictionaryWords.Min(word => word.Length);

            //Console.WriteLine($"Length of the shortest word: {shortestWordLength}");

            #endregion

            #region 7. Get the length of the longest word 

            //int longestWordLength = dictionaryWords.Max(word => word.Length);

            //Console.WriteLine($"Length of the longest word: {longestWordLength}");

            #endregion

            #region 8. Get the average length of the words
            //double averageWordLength = dictionaryWords.Average(word => word.Length);

            //Console.WriteLine($"Average word length: {averageWordLength}");

            #endregion

            #region 9. Get the total units in stock for each product category
            //var totalUnitsInStockByCategory = ProductList
            //                      .GroupBy(p => p.Category)
            //                      .Select(g => new
            //                      {
            //                          CategoryName = g.Key,
            //                          TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //                      })
            //                      .ToList();

            //foreach (var category in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName} has {category.TotalUnitsInStock} units in stock.");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products
            //var cheapestPriceByCategory = ProductList
            //                  .GroupBy(p => p.Category)
            //                  .Select(g => new
            //                  {
            //                      CategoryName = g.Key,
            //                      CheapestPrice = g.Min(p => p.UnitPrice)
            //                  })
            //                  .ToList();

            //foreach (var category in cheapestPriceByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName} has a minimum price of {category.CheapestPrice}");
            //}

            #endregion

            #region 11. Get the products with the cheapest price in each
            //var cheapestProductsByCategory = ProductList
            //                     .GroupBy(p => p.Category)
            //                     .Select(g => new
            //                     {
            //                         CategoryName = g.Key,
            //                         CheapestPrice = g.Min(p => p.UnitPrice),
            //                         Products = g.Where(p => p.UnitPrice == g.Min(p => p.UnitPrice)).ToList()
            //                     })
            //                     .ToList();

            //foreach (var category in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName}:");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($" - {product.ProductName} at {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products
            //var mostExpensivePriceByCategory = ProductList
            //                       .GroupBy(p => p.Category)
            //                       .Select(g => new
            //                       {
            //                           CategoryName = g.Key,
            //                           MostExpensivePrice = g.Max(p => p.UnitPrice)
            //                       })
            //                       .ToList();

            //foreach (var category in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName} has a maximum price of {category.MostExpensivePrice}");
            //}

            #endregion

            #region 13. Get the products with the most expensive
            //var mostExpensiveProductsByCategory = ProductList
            //                          .GroupBy(p => p.Category)
            //                          .Select(g => new
            //                          {
            //                              CategoryName = g.Key,
            //                              MostExpensivePrice = g.Max(p => p.UnitPrice),
            //                              Products = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice)).ToList()
            //                          })
            //                          .ToList();

            //foreach (var category in mostExpensiveProductsByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName}:");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($" - {product.ProductName} at {product.UnitPrice}");
            //    }
            //}

            #endregion

            #region 14. Get the average price of each category's products
            //var averagePriceByCategory = ProductList
            //                 .GroupBy(p => p.Category)
            //                 .Select(g => new
            //                 {
            //                     CategoryName = g.Key,
            //                     AveragePrice = g.Average(p => p.UnitPrice)
            //                 })
            //                 .ToList();

            //foreach (var category in averagePriceByCategory)
            //{
            //    Console.WriteLine($"{category.CategoryName} has an average price of {category.AveragePrice}");
            //}

            #endregion
            #endregion

            #region Ordering Operators

            #region 1. Sort a list of products by name
            //var productsSortedByName = ProductList
            //               .OrderBy(p => p.ProductName)
            //               .ToList();

            //foreach (var product in productsSortedByName)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            #endregion

            #region 2. Use a custom comparer to do a case-insensitive
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //                  .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
            //                  .ToList();

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 3. Sort a list of products by units in stock
            //var productsSortedByUnitsInStock = ProductList
            //                       .OrderByDescending(p => p.UnitsInStock)
            //                       .ToList();

            //foreach (var product in productsSortedByUnitsInStock)
            //{
            //    Console.WriteLine($"{product.ProductName} - Units in Stock: {product.UnitsInStock}");
            //}

            #endregion

            #region 4. Sort a list of digits, first by the length
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits = Arr
            //                   .OrderBy(digit => digit.Length)
            //                   .ThenBy(digit => digit)
            //                   .ToList();

            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region 5. Sort first by word length and then by a case-insensitive
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //                  .OrderBy(word => word.Length)
            //                  .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //                  .ToList();

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 6. Sort a list of products, first by category,
            //var productsSortedByCategoryAndPrice = ProductList
            //                           .OrderBy(p => p.Category)
            //                           .ThenByDescending(p => p.UnitPrice)
            //                           .ToList();

            //foreach (var product in productsSortedByCategoryAndPrice)
            //{
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - Price: {product.UnitPrice}");
            //}

            #endregion

            #region 7. Sort first by word length and then by a case-insensitive
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //                  .OrderBy(word => word.Length)
            //                  .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //                  .ToList();

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 8. Create a list of all digits in the array whose second letter
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var filteredAndReversedDigits = Arr
            //                                .Where(digit => digit.Length > 1 && digit[1] == 'i')
            //                                .Reverse()
            //                                .ToList();

            //foreach (var digit in filteredAndReversedDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #endregion

            #region Transformation Operators
            #region 1. Return a sequence of just the names of

            //var productNames = ProductList
            //       .Select(p => p.ProductName)
            //       .ToList();

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region 2. Produce a sequence of the uppercase
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordCases = words
            //                .Select(word => new
            //                {
            //                    UpperCase = word.ToUpper(),
            //                    LowerCase = word.ToLower()
            //                })
            //                .ToList();

            //foreach (var word in wordCases)
            //{
            //    Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}");
            //}

            #endregion

            #region 3. Produce a sequence containing some properties
            //var productDetails = ProductList
            //         .Select(p => new
            //         {
            //             p.ProductName,
            //             Price = p.UnitPrice,
            //             p.Category
            //         })
            //         .ToList();

            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            //}

            #endregion

            #region 4. Determine if the value of int in an array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var valuePositionMatch = Arr
            //                         .Select((value, index) => new
            //                         {
            //                             Value = value,
            //                             MatchesPosition = value == index
            //                         })
            //                         .ToList();

            //foreach (var item in valuePositionMatch)
            //{
            //    Console.WriteLine($"Value: {item.Value}, Matches Position: {item.MatchesPosition}");
            //}

            #endregion

            #region 5. Return all pairs of numbers from both arrays such that the number
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA
            //            .SelectMany(a => numbersB
            //                            .Where(b => a < b)
            //                            .Select(b => new { NumberA = a, NumberB = b }))
            //            .ToList();

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"NumberA: {pair.NumberA}, NumberB: {pair.NumberB}");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00:

            //var ordersBelow500 = CustomerList
            //         .SelectMany(c => c.Orders)
            //         .Where(o => o.Total < 500.00M)
            //         .ToList();

            //foreach (var order in ordersBelow500)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
            //}

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later:

            //var ordersFrom1998OrLater = CustomerList
            //                .SelectMany(c => c.Orders)
            //                .Where(o => o.OrderDate.Year >= 1998)
            //                .ToList();

            //foreach (var order in ordersFrom1998OrLater)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate.ToShortDateString()}");
            //}


            #endregion

            #endregion

            #region Set

            #region 1. Find the unique Category names from the Product List:
            //var uniqueCategories = ProductList
            //           .Select(p => p.Category)
            //           .Distinct()
            //           .ToList();

            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}


            #endregion

            #region 2. Produce a sequence containing the unique first
            //var uniqueFirstLetters = ProductList
            //             .Select(p => p.ProductName[0])
            //             .Union(CustomerList.Select(c => c.CustomerName[0]))
            //             .Distinct()
            //             .ToList();

            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region 3. Create one sequence that contains
            var commonFirstLetters = ProductList
                         .Select(p => p.ProductName[0])
                         .Intersect(CustomerList.Select(c => c.CustomerName[0]))
                         .ToList();

            foreach (var letter in commonFirstLetters)
            {
                Console.WriteLine(letter);
            }

            #endregion

            #region 4. Create one sequence that contains
            //var productUniqueFirstLetters = ProductList
            //                    .Select(p => p.ProductName[0])
            //                    .Except(CustomerList.Select(c => c.CustomerName[0]))
            //                    .ToList();

            //foreach (var letter in productUniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region 5. Create one sequence that contains the last three
            //var lastThreeChars = ProductList
            //                     .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //                     .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName))
            //                     .ToList();

            //foreach (var chars in lastThreeChars)
            //{
            //    Console.WriteLine(chars);
            //}

            #endregion
            #endregion

            #region Partitioning 

            #region 1. Get the first 3 orders from customers in Washington:
            //var firstThreeOrdersFromWA = CustomerList
            //                 .Where(c => c.Region == "WA")
            //                 .SelectMany(c => c.Orders)
            //                 .Take(3)
            //                 .ToList();

            //foreach (var order in firstThreeOrdersFromWA)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington:
            //var allButFirstTwoOrdersFromWA = CustomerList
            //                     .Where(c => c.Region == "WA")
            //                     .SelectMany(c => c.Orders)
            //                     .Skip(2)
            //                     .ToList();

            //foreach (var order in allButFirstTwoOrdersFromWA)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}


            #endregion

            #region 3. Return elements starting from the beginning of the array 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers
            //             .TakeWhile((num, index) => num >= index)
            //             .ToList();

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3:
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var resultFromDivisibleBy3 = numbers
            //                             .SkipWhile(num => num % 3 != 0)
            //                             .ToList();

            //foreach (var number in resultFromDivisibleBy3)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position:

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var resultFromLessThanPosition = numbers
            //                                 .SkipWhile((num, index) => num >= index)
            //                                 .ToList();

            //foreach (var number in resultFromLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion

            #endregion

            #region Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei':

            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = dictionaryWords
            //                 .Any(word => word.Contains("ei"));

            //Console.WriteLine($"Any word contains 'ei': {containsEi}");

            #endregion

            #region 2. Return a grouped list of products only for categories that have at least one product that is out of stock:
            //var categoriesWithOutOfStockProducts = ProductList
            //                           .Where(p => p.UnitsInStock == 0)
            //                           .GroupBy(p => p.Category)
            //                           .ToList();

            //foreach (var categoryGroup in categoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion

            #region 3. Return a grouped list of products only for categories that have all of their products in stock:

            //var categoriesWithAllProductsInStock = ProductList
            //                           .GroupBy(p => p.Category)
            //                           .Where(g => g.All(p => p.UnitsInStock > 0))
            //                           .ToList();

            //foreach (var categoryGroup in categoriesWithAllProductsInStock)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"   Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

            #endregion

            #region Grouping 

            #region 1. Group numbers by their remainder when divided by 5:
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedByRemainder = numbers
            //                         .GroupBy(n => n % 5)
            //                         .ToList();

            //foreach (var group in groupedByRemainder)
            //{
            //    Console.WriteLine($"Remainder: {group.Key}");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine($"   Number: {number}");
            //    }
            //}


            #endregion

            #region 2. Group a list of words by their first letter using dictionary_english.txt:

            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");

            //var groupedByFirstLetter = dictionaryWords
            //                           .GroupBy(word => word[0])
            //                           .ToList();

            //foreach (var group in groupedByFirstLetter)
            //{
            //    Console.WriteLine($"First Letter: {group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"   Word: {word}");
            //    }
            //}


            #endregion

            #region 3. Group words that consist of the same characters together using a custom comparer:

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var groupedByAnagram = Arr
            //                       .GroupBy(word => new string(word.OrderBy(c => c).ToArray()))
            //                       .ToList();

            //foreach (var group in groupedByAnagram)
            //{
            //    Console.WriteLine($"Anagram Group: {group.Key}");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"   Word: {word}");
            //    }
            //}


            #endregion

            #endregion
        }
    }
}
