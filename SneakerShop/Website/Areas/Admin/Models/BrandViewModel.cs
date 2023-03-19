using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
{
    public class BrandViewModel : Entity
    {
        [DisplayName("Brand")]
        public string? Name { get; set; }
    }
}
