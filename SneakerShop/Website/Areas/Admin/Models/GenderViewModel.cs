using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
{
    public class GenderViewModel : Entity
    {
        [DisplayName("Gender")]
        public string? Name { get; set; }
    }
}
