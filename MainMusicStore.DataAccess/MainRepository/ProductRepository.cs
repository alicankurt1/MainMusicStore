using MainMusicStore.Data;
using MainMusicStore.DataAccess.IMainRepository;
using MainMusicStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMusicStore.DataAccess.MainRepository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var data = _db.Products.FirstOrDefault(x => x.Id == product.Id);
            if (data != null)
            {
                if (product.ImageUrl != null)
                {
                    data.ImageUrl = product.ImageUrl;
                }
                data.title = product.title;
                data.Description = product.Description;
                data.ProductNo = product.ProductNo;
                data.Price = product.Price;
                data.ListPrice = product.ListPrice;
                data.CategoryId = product.CategoryId;
                data.BrandId = product.BrandId;
                
            }
            
        }
    }
}
