using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using (PubContext context=new PubContext())
{
    context.Database.EnsureCreated();
}
namespace PublisherConsole
{
    public class PublisherHelper
    {
        //GetAuthors();
        //AddAuthor();
        //GetAuthors();
        //AddAuthorWithBook();
        //GetAuthorsWithBooks();

        void AddAuthorWithBook()
        {
            var author = new Author { FirstName = "Julie", LastName = "Lerman" };
            author.Books.Add(new Book { Title = "Programming Entity Framework",
                                        PublishDate = new DateOnly(2009, 1, 1)
            });
            author.Books.Add(new Book { Title = "Programming Entity Framework 2nd Ed",
                                        PublishDate = new DateOnly(2010,8,1) });
            using var context = new PubContext();
            context.Authors.Add(author);
            context.SaveChanges();
        }
        void GetAuthorsWithBooks()
        {
            using var context = new PubContext();
            var authors = context.Authors.Include(a => a.Books).ToList();
            foreach (var author in authors)
            {
                Console.WriteLine(author.FirstName + " " + author.LastName);
                foreach (var book in author.Books)
                {
                    Console.WriteLine("        " + book.Title);
                }
            }
        }

        public void AddAuthor(string firstName, string lastName)
        {
            //var author = new Author { FirstName = "Julie", LastName = "Lerman" };
            //var author = new Author { FirstName = "Josie", LastName = "Newf" };
            //var author = new Author { FirstName = "Simon", LastName = "Heilebutt" };
            //var author = new Author { FirstName = "Sebastian", LastName = "Ølbutt" };
            //var author = new Author { FirstName = "Adolf", LastName = "H" };
            var author = new Author { FirstName = firstName, LastName = lastName };
            using var context = new PubContext();
            context.Authors.Add(author);
            context.SaveChanges();
        }

        public List<Author> GetAuthors() 
        {
            using var context = new PubContext();
            var authors = context.Authors.ToList();
            return authors;
        }

        public void MakeDataBase()
        {
            using (PubContext context = new PubContext())
            {
                context.Database.EnsureCreated();
            }

        }
    }

}
