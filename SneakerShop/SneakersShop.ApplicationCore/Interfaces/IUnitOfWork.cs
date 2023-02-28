using SneakersShop.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersShop.ApplicationCore.Interfaces
{
    internal interface IUnitOfWork
    {
        public IRepository<Category> Category { get; }
        public IRepository<Brand> Brand { get; }
        public IRepository<Product> Product { get; }
        public IRepository<Color> Color { get; }
        public IRepository<Gender> Gender { get; }
        public IRepository<Material> Material { get; }
    }
}
