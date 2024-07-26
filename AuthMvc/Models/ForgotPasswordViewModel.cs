using System.ComponentModel.DataAnnotations;

namespace AuthMvc.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
