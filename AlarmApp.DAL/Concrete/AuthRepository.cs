using AlarmApp.DAL.Abstract;
using AlarmApp.Entity.Dtos;
using AlarmApp.Entity.Model;
using BussinesLayer.Utilities.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.DAL.Concrete
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IDbService _dbService;

        public AuthRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Login(string mail, string password)
        {

            var user = await _dbService.GetAsync<User>("SELECT * FROM public.users where mail=@mail", new { mail });

            if (user == null)
            {
                return false;
            }
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                if(HashingHelper.VerifyPasswordHash(password,user.PasswordHash,user.PasswordSalt))
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> Register(string mail, string password)
        {
            byte[]  passwordHash, passwordSalt;

            HashingHelper.CreatePasswordHash( password,  out passwordHash, out passwordSalt);

            var user = new User
            {
                Mail = mail,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt

            };

            var result = await _dbService.EditData(
               "INSERT INTO public.users (mail,passwordhash,passwordsalt) VALUES (@Mail,@PasswordHash,@PasswordSalt) ",
               user);

            return true;


        }
    }
}
