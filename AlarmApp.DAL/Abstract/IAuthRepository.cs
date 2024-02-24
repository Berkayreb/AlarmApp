
using AlarmApp.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.DAL.Abstract
{
    public interface IAuthRepository
    {
        Task<bool> Register(string mail,string password);
        Task<bool> Login(string mail,string password);
    }
}
