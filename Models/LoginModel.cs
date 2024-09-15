using System.ComponentModel.DataAnnotations;

namespace MVC_Tasks.Models
{
    public class LoginModel
    {
       public bool RememberMe { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Id { get; set; } 

    }
}
