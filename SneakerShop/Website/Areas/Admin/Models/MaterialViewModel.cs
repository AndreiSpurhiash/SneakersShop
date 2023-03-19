using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
{
    public class MaterialViewModel : Entity
    {
        [DisplayName("Material")]
        public string? Name { get; set; }
    }
}
