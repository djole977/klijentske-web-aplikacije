using KWA_Djole.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWA_Djole.Business.Dtos
{
    public class ShoppingItemDto : BaseDto
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Size { get; set; }
        public string? Manufacturer { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public List<CustomerReviewDto>? CustomerReviews { get; set; }
    }
}