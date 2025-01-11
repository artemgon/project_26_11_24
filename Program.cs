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
                Magazine magazine = new()
                {
                    Title = "Magazine Title",
                    Description = "Magazine Description",
                    ContactPhone = "123456789",
                    Email = "magazineemail.com",
                    CreationYear = 2020,
                    StaffCount = 5
                };
                magazine.PrintInfo();
                magazine += 5;
                magazine.PrintInfo();
                magazine -= 2;
                magazine.PrintInfo();
                Magazine magazine2 = new()
                {
                    Title = "Magazine Title 2",
                    Description = "Magazine Description 2",
                    ContactPhone = "987654321",
                    Email = "magazineemail2.com",
                    CreationYear = 2021,
                    StaffCount = 8
                };
                magazine2.PrintInfo();
                Console.WriteLine("magazine == magazine2: " + (magazine == magazine2));
                Console.WriteLine("magazine > magazine2: " + (magazine > magazine2));
                Console.WriteLine("magazine < magazine2: " + (magazine < magazine2));
                Console.WriteLine("magazine != magazine2: " + (magazine != magazine2));
                Console.WriteLine("magazine.GetHashCode(): " + magazine.GetHashCode());
                Console.WriteLine("magazine2.GetHashCode(): " + magazine2.GetHashCode());
                Console.WriteLine("magazine.Equals(magazine2): " + magazine.Equals(magazine2));
                Console.WriteLine("magazine.Equals(magazine): " + magazine.Equals(magazine));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
