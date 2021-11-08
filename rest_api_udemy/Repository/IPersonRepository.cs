using rest_api_udemy.Model;
using System.Collections.Generic;

namespace rest_api_udemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string lastName);
    }
}
