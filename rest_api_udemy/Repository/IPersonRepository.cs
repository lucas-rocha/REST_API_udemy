using rest_api_udemy.Model;

namespace rest_api_udemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
