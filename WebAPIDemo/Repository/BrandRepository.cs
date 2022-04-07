using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIDemo.Models;

namespace WebAPIDemo.Repository
{
    public class BrandRepository : GenericRepository<brand>
    {
        public IEnumerable<BrandModel> SelectAll()
        {
            List<brand> brands = tables.ToList();
            List<BrandModel> listBrandModel = new List<BrandModel>();
            foreach(brand brand in brands)
            {
                BrandModel brandModel = new BrandModel()
                {
                    Id = brand.brand_id,
                    Name = brand.brand_name,
                };
                listBrandModel.Add(brandModel);
            }
            return listBrandModel;
        }

        public BrandModel SelectById(int Id)
        {
            var brand = tables.Find(Id);
            BrandModel brandModel = new BrandModel()
            {
                Id = brand.brand_id,
                Name = brand.brand_name,
            };

            return brandModel;
        }
    }
}