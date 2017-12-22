using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class vmCartIndex
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}