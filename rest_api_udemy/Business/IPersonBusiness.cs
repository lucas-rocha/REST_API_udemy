using rest_api_udemy.Data.VO;
using System.Collections.Generic;

namespace rest_api_udemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO PersonVO);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO personVO);
        void Delete(long id);
    }
}
