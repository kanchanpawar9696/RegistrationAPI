using ClassAPI.MODEL;

namespace RegistrationAPI.IREPO
{
    public interface IRepoLoginModel
    {

        Task<IEnumerable<LoginModel>> LoginAll();
        Task<LoginModel> GetLogin(int id);
        Task<LoginModel> AddLogin(LoginModel login);
        Task<LoginModel> UpdateLogin(int id, LoginModel login);
        Task<LoginModel> DeleteLogin(int id);
    }
}
