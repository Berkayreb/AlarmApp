using AlarmApp.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.DAL.Abstract
{
    public interface IAuthRepository
    {
        void Register(CreateUserDto userDto);
        void Login(UserLoginDto userDto);
    }
}
