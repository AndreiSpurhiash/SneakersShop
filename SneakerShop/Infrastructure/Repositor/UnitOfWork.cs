using Infrastructure.Data;
using SneakersShop.ApplicationCore.Entities;
using SneakersShop.ApplicationCore.Interfaces;

namespace Infrastructure.Repository
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly CatalogContext _db;
        public IRepository<Category> Category { get; }
        public IRepository<Brand> Brand { get; }
        public IRepository<Product> Product { get; }
        public IRepository<Color> Color { get; }
        public IRepository<Gender> Gender { get; }
        public IRepository<Material> Material { get; }

        public CatalogContext Db => _db;

        public UnitOfWork(CatalogContext db)
        {
            _db = db;
            Category = new Repository<Category>(_db);
            Brand = new Repository<Brand>(_db);
            Product = new Repository<Product>(_db);
            Color = new Repository<Color>(_db);
            Gender = new Repository<Gender>(_db);
            Color = new Repository<Color>(_db);
            Material = new Repository<Material>(_db);
        }
    }
}
