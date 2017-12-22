using System.ComponentModel.DataAnnotations;

namespace SportsStore.WebUI.Models
{
    public class vmLogin
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

    }
}