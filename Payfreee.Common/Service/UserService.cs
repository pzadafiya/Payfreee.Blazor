using Payfreee.Common.Service.Contracts;
using Payfreee.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Payfreee.Common.Service
{
   
    public class UserService : IUserService
    {
        private IHttpService _httpService;

        public UserService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _httpService.Get<IEnumerable<User>>("/users");
        }
    }
}