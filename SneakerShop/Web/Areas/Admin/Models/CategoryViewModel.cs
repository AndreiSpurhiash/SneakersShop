using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SneakersShop.Web.Areas.Admin.Models
{
    public class CategoryViewModel : Entity
    {
        [DisplayName("Category")]
        [ValidateNever] public string? Name { get; set; }
    }
}
