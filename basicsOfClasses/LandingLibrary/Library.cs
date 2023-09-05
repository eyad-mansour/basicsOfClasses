using System.Collections;
using static System.Reflection.Metadata.BlobBuilder;

namespace LandingLibrary
{
    public interface ILibrary : IReadOnlyCollection<Book>
    {
        void Add(string title, string firstName, string lastName, int numOfPages);

        Book Borrow(string title);

        void Return(Book book);
    }

    public class Library : ILibrary
    {
        private readonly Dictionary<string, Book> books = new Dictionary<string, Book>(StringComparer.CurrentCultureIgnoreCase);
        public int Count => books.Count;

        public void Add(string title, string firstName, string LastName, int numberOfPages)
        {
            Book book = new Book
            {
                Title = title,
                Author = new Author
                {
                    FirstName = firstName,
                    LastName = LastName
                },
                NumberOfPages = numberOfPages,

            };
            books.Add(title, book);

        }
        public Book Borrow(string title)
        {
            if (!books.ContainsKey(title))
            {
                return null;
            }
            Book book = books[title];
            books.Remove(title);
            return book;
            
        }

        public void Return(Book book)
        {
            books.Add(book.Title, book);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in books.Values)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

