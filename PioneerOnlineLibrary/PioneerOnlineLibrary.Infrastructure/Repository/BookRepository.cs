using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly PioneerDbContext _context;
        public BookRepository(PioneerDbContext context)
        {
            _context = context;
        }
        public Domain.Model.Book CreateBook(Domain.Model.Book book)
        {

           _context.Books.Add(book).Context.SaveChanges();
            return book;
        }

        public void DeleteBook(Book ISBN)
        {
            _context.Books.Remove(ISBN);
            _context.SaveChanges();
        }

        public Book GetBookByAuthor(string author)
        {
            return _context.Books.FirstOrDefault(x => x.Author == author) ?? new Book();
        }

        public Book GetBookByDatePublished(string datePublished)
        {
            return _context.Books.FirstOrDefault(x => x.PublicationDate == datePublished) ?? new Book();
        }

        public Book GetBookByISBN(string ISBN)
        {
            return _context.Books.FirstOrDefault(x => x.ISBN == ISBN) ?? new Book();
        }

        public Book GetBookByPublisher(string publisher)
        {
            return _context.Books.FirstOrDefault(x => x.Publisher == publisher) ?? new Book();
        }

        public Book GetBookByTitle(string title)
        {
            return _context.Books.FirstOrDefault(x => x.Title == title) ?? new Book();
        }

        public Book UpdateBook(Domain.Model.Book book)
        {
            _context.Books.Add(book);
            return book;
        }
    }
}
