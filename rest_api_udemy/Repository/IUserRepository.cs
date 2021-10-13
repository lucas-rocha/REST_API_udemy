using rest_api_udemy.Data.VO;
using rest_api_udemy.Model;

namespace rest_api_udemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string username);
        bool RevokeToken(string username);
        User RefreshUserInfo(User user);
    }
}
