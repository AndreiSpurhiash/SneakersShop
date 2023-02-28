using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersShop.ApplicationCore.Entities
{
    public class Product : Entity
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of the Name should be from 3 to 50 characters")]
        [RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "The Name is't correct!")]
        public string? Name { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "The length of the Description should be from 10 to 1000 characters")]
        public string? Description { get; set; }
        [Required]
        [Range(1, 5000, ErrorMessage = "The length of the Price should be from 1 to 5000 characters")]
        public double? Price { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "The length of the Size should be from 1 to 100 characters")]
        public double? Size { get; set; }
        [Required]
        public Guid BrandId { get; set; }
        [ForeignKey("BrandId")] public Brand? Brand { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")] public Category? Category { get; set; }
        [Required]
        public Guid GenderId { get; set; }
        [ForeignKey("GenderId")] public Gender? Gender { get; set; }
        [Required]
        public Guid ColorId { get; set; }
        [ForeignKey("ColorId")] public Color? Color { get; set; }
        [Required]
        public Guid MaterialId { get; set; }
        [ForeignKey("MaterialId")] public Material? Material { get; set; }
        public Product()
        {

        }

        public Product(string name, string description, double price, double size, Category 
            category, Brand brand, Gender gender, Color color, Material material)
        {
            Name = name;
            Description = description;
            Price = price;
            Size = size;
            Category = category;
            Brand = brand;
            Gender = gender;
            Color = color;
            Material = material;
        }

    }
}
