using MainMusicStore.Data;
using MainMusicStore.DataAccess.IMainRepository;
using MainMusicStore.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMusicStore.DataAccess.MainRepository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _db;

        public BrandRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public void Update(Brand brand)
        {
            var data = _db.Brands.FirstOrDefault(x => x.Id == brand.Id);
            if (data != null)
            {
                data.Name = brand.Name;
            }
            
        }
    }
}
