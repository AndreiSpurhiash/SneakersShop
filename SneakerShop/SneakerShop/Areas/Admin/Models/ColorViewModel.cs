using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SneakersShop.Web.Areas.Admin.Models
{
    public class ColorViewModel : Entity
    {
        [DisplayName("Color")]
        [ValidateNever] public string? Name { get; set; }
    }
}
