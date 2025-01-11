using project_26_11_24.Classes;

namespace project_26_11_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Shop shop1 = new Shop
                {
                    Title = "Shop1",
                    Address = "Address1",
                    Description = "Description1",
                    Phone = "Phone1",
                    Email = "Email1",
                    Area = 100
                };
                Shop shop2 = new Shop
                {
                    Title = "Shop2",
                    Address = "Address2",
                    Description = "Description2",
                    Phone = "Phone2",
                    Email = "Email2",
                    Area = 200
                };
                Console.WriteLine(shop1 + 50);
                Console.WriteLine(shop1 - 50);
                Console.WriteLine(shop1 == shop2);
                Console.WriteLine(shop1 > shop2);
                Console.WriteLine(shop1 < shop2);
                Console.WriteLine(shop1 != shop2);
                Console.WriteLine(shop1.Equals(shop2));
                Console.WriteLine(shop1.GetHashCode());
                shop1.PrintInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
