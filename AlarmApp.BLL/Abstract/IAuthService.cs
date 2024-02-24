using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.BLL.Abstract
{
    public interface IAuthService
    {
        Task<bool> Login(string username, string password);
        Task<bool> Register(string username, string password);
    }
}
