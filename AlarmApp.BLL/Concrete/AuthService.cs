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

        public async Task<bool> Login(string mail, string password)
        {
            return await _authRepository.Login(mail, password);
        }

        public async Task<bool> Register(string username, string password)
        {
            return await _authRepository.Register("root@root.com", "root");
         
           
            
        }
    }
}
