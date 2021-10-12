using rest_api_udemy.Data.Converter.Contract;
using rest_api_udemy.Data.VO;
using rest_api_udemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace rest_api_udemy.Data.Converter.Implementations
{
    public class BookConverter : IParse<BookVO, Book>, IParse<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Price = origin.Price,
                Author = origin.Author,
                LauncheDate = origin.LauncheDate
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Price = origin.Price,
                Author = origin.Author,
                LauncheDate = origin.LauncheDate
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
