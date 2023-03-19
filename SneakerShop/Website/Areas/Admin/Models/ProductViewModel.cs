using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SneakersShop.ApplicationCore.Entities;
using System.ComponentModel;

namespace Website.Areas.Admin.Models
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
        public int MaterialId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int GenderId { get; set; }
        public int ColorID { get; set; }

    }
}
