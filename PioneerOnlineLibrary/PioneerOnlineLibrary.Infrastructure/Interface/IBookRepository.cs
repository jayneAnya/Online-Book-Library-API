using PioneerOnlineLibrary.Domain.DTO;
using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Interface
{
    public interface IBookRepository
    {
        void DeleteBook(Book ISBN);
        Book CreateBook(Book book);
        Book UpdateBook(Book book);
        Book GetBookByISBN(string ISBN);

        Book GetBookByTitle(string title);
        Book GetBookByAuthor(string author);
        Book GetBookByPublisher(string publisher);
        Book GetBookByDatePublished(string datePublished);
    }
}
