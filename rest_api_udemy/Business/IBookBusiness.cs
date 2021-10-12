using rest_api_udemy.Data.VO;
using rest_api_udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api_udemy.Business.Implementations
{
    public interface IBookBusiness
    {
        List<BookVO> FindAll();
        BookVO FindById(long id);
        BookVO Create(BookVO BookVO);
        BookVO Update(BookVO BookVO);
        void Delete(long id);
    }
}
