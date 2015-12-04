using System;
using System.Linq;

namespace TestApp
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                using (var context = new TestDataContext())
                {
                    //context.Table1.Add(new Table1 {TestCol = Guid.NewGuid().ToString()});
                    //context.SaveChanges();

                    foreach (var row in context.Table1.OrderBy(q => q.Id))
                        Console.WriteLine("{0}: {1}", row.Id, row.TestCol);
                }

                Console.WriteLine("OK.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.ReadKey();
        }
    }
}