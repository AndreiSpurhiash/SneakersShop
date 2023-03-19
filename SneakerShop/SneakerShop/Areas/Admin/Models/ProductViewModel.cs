using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SneakersShop.Web.Areas.Admin.Models
{
    public class ProductViewModel : Entity
    {
        [DisplayName("Product Name")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public double? Size { get; set; }
        [ValidateNever] public Brand? Brand { get; set; }
        [ValidateNever] public Category? Category { get; set; }
        [ValidateNever] public Material? Material { get; set; }
        [ValidateNever] public Gender? Gender { get; set; }
        [ValidateNever] public Color? Color { get; set; }
        public Guid MaterialId { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid GenderId { get; set; }
        public Guid ColorID { get; set; }

    }

 
}
