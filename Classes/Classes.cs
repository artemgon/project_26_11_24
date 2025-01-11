
namespace project_26_11_24.Classes
{
    public class Magazine
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        public int CreationYear { get; set; }
        public int StaffCount { get; set; }
        public static Magazine operator +(Magazine magazine, int staffCount)
        {
            magazine.StaffCount += staffCount;
            return magazine;
        }
        public static Magazine operator -(Magazine magazine, int staffCount)
        {
            magazine.StaffCount -= staffCount;
            return magazine;
        }
        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.StaffCount == magazine2.StaffCount;
        }
        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.StaffCount > magazine2.StaffCount;
        }
        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.StaffCount < magazine2.StaffCount;
        }
        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.StaffCount != magazine2.StaffCount;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Magazine otherMagazine)
            {
                return this.StaffCount == otherMagazine.StaffCount;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return StaffCount.GetHashCode();
        }
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Magazine Info:");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Contact Phone: " + ContactPhone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Creation Year: " + CreationYear);
            Console.WriteLine("Staff Count: " + StaffCount);
            Console.WriteLine();
        }
    }
}
