using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class vmProductsList
    {
        public IEnumerable<Product> Products { get; set; }
        public vmPagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}