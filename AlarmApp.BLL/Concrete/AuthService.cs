using AlarmApp.BLL.Abstract;
using AlarmApp.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.BLL.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public Task<bool> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(string username, string password)
        {
            //await _authRepository.Register("admin@admin.com", "admin");

            //await _authRepository.Login("admin@admin.com", "admin");
            throw new NotImplementedException();
        }
    }
}
