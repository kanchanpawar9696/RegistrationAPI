using ClassAPI.MODEL;
using Microsoft.EntityFrameworkCore;
using RegistrationAPI.DATA;

namespace RegistrationAPI.IREPO
{
    public class ILoginModel : IRepoLoginModel
    {
        private readonly LoginModelDBContext _dbcontext;
        public ILoginModel(LoginModelDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<LoginModel> AddLogin(LoginModel login)
        {
            // throw new NotImplementedException();
            await _dbcontext.UserInformation.AddAsync(login);
            await _dbcontext.SaveChangesAsync();
            return login;
        }

        public async Task<LoginModel> DeleteLogin(int id)
        {
            // throw new NotImplementedException();
            var delete = await _dbcontext.UserInformation.FirstOrDefaultAsync(x => x.srno == id);
            if(delete==null)
            {

                return delete;
            }

             _dbcontext.UserInformation.Remove(delete);
            await _dbcontext.SaveChangesAsync();
            return delete;
        }

        public async Task<LoginModel> GetLogin(int id)
        {
            //throw new NotImplementedException();
            return await _dbcontext.UserInformation.FirstOrDefaultAsync(x=>x.srno==id);
        }

        public async Task<IEnumerable<LoginModel>> LoginAll()
        {
            // throw new NotImplementedException();
            return await _dbcontext.UserInformation.ToListAsync();
        }

        public async Task<LoginModel> UpdateLogin(int id, LoginModel login)
        {
            // throw new NotImplementedException();
            var update = await _dbcontext.UserInformation.FirstOrDefaultAsync(x => x.srno == id);
            if(update ==null)
            {
                return update;
            }

            update.srno = login.srno;
            update.userid = login.userid;
            update.password = login.password;
            update.custname = login.custname;
            update.address = login.address;
            update.salary = login.salary;
            update.emailid = login.emailid;
            await _dbcontext.SaveChangesAsync();
            return update;
        }
    }
}
