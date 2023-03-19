using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
{
    public class ColorViewModel : Entity
    {
        [DisplayName("Color")]
        [ValidateNever] public string? Name { get; set; }
    }
}
