
namespace project_26_11_24.Classes
{
    public class Shop
    {
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public float Area { get; set; }
        public static float operator +(Shop shop1, float area)
        {
            return shop1.Area + area;
        }
        public static float operator -(Shop shop1, float area)
        {
            return shop1.Area - area;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }
        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Area != shop2.Area;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Shop otherShop)
            {
                return this.Area == otherShop.Area;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
        public void PrintInfo()
        {
            Console.WriteLine("Shop Info:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
