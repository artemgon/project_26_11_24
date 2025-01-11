
namespace project_26_11_24.Classes
{
    internal class Books
    {
        private readonly string?[] books = new string?[10];
        public string? this[int index]
        {
            get
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return books[index];
            }
            set
            {
                if (index < 0 || index >= books.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                if (value == null || value == string.Empty)
                {
                    books[index] = null;
                }
                else
                {
                    books[index] = value;
                }
            }
        }
        public string TenthBook
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Book name cannot be null or empty.");
                }
                books[9] = value;
            }
        }
        public bool IsAvailable(string book)
        {
            foreach (var item in books)
            {
                if (item == book)
                {
                    return true;
                }
            }
            return false;
        }
        public static Books operator +(Books books, string book)
        {
            for (int i = 0; i < books.books.Length; i++)
            {
                if (books.books[i] == null)
                {
                    books.books[i] = book;
                    return books;
                }
            }
            return books;
        }
        public static Books operator -(Books books, string book)
        {
            for (int i = 0; i < books.books.Length; i++)
            {
                if (books.books[i] == book)
                {
                    books.books[i] = null;
                    return books;
                }
            }
            return books;
        }
    }
}
