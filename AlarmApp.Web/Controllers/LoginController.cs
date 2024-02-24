using AlarmApp.BLL.Abstract;
using AlarmApp.Entity.Model;
using AlarmApp.Web.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AlarmApp.Web.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            var loginStatus = await _authService.Login(loginDto.Mail, loginDto.Password);

            if (ModelState.IsValid)
            {
                if (loginStatus)
                {

                    var claims = new List<Claim>{new Claim(ClaimTypes.Name,loginDto.Mail)};

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Mail or password is wrong");
                  
                }
            }
            return View();
        }
    }
}
