using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
{
    public class CategoryViewModel : Entity
    {
        [DisplayName("Category")]
        public string? Name { get; set; }
    }
}
