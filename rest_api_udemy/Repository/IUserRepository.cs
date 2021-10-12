using rest_api_udemy.Data.VO;
using rest_api_udemy.Model;

namespace rest_api_udemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User RefreshUserInfo(User user);
    }
}
