using System.ComponentModel.DataAnnotations;

namespace AlarmApp.Web.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Mail is required.")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
    }
}
