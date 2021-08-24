using MainMusicStore.DataAccess.IMainRepository;
using MainMusicStore.Models.DbModels;
using MainMusicStore.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Linq;

namespace MainMusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
       
        private readonly IUnitOfWork _uow;
        private readonly IWebHostEnvironment _hostEnvironment;
    

 
        public ProductController(IUnitOfWork uow, IWebHostEnvironment hostEnvironment)
        {
            _uow = uow;
            _hostEnvironment = hostEnvironment;
        }
  

       
        public IActionResult Index()
        {
            return View();
        }
     

     
        public IActionResult GetAll()
        {
            var allObj = _uow.product.GetAll(includeProperties: "Brand,Category");
            return Json(new { data = allObj });
        }
  

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var deleteData = _uow.product.Get(id);
            if (deleteData == null)
            {
                return Json(new { success = false, message = "Data Not Found!" });
            }

            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, deleteData.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }

            _uow.product.Remove(deleteData);
            _uow.Save();
            return Json(new { success = true, message = "Silme İşlemi Başarıyla Gerçekleşti." });
        }


        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new ProductVM()
            {
                product = new Product(),
                CategoryList = _uow.category.GetAll().Select(i => new SelectListItem {
                    Text = i.CategoryName,
                    Value = i.Id.ToString()
                }),
                BrandList = _uow.brand.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            if (id == null)
                return View(productVM);

            productVM.product = _uow.product.Get(id.GetValueOrDefault());
            if (productVM.product == null)
                return NotFound();
            return View(productVM); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\products");
                    var extenstion = Path.GetExtension(files[0].FileName);

                    if (productVM.product.ImageUrl != null)
                    {
                        var imagePath = Path.Combine(webRootPath, productVM.product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var fileStreams  = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);
                    }
                    productVM.product.ImageUrl = @"\images\products\" + fileName + extenstion;
                }
                else
                {
                    if (productVM.product.Id != 0)
                    {
                        var productData = _uow.product.Get(productVM.product.Id);
                        productVM.product.ImageUrl = productData.ImageUrl;
                    }
                }

                if (productVM.product.Id == 0)
                {
                    //create
                    _uow.product.Add(productVM.product);
                }
                else
                {
                    //update
                    _uow.product.Update(productVM.product);
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            else
            {
                productVM.CategoryList = _uow.category.GetAll().Select(a => new SelectListItem 
                { 
                      Text = a.CategoryName,
                      Value = a.Id.ToString()
                });

                productVM.BrandList = _uow.brand.GetAll().Select(a => new SelectListItem
                {
                    Text = a.Name,
                    Value = a.Id.ToString()
                });

                if (productVM.product.Id != 0)
                {
                    productVM.product = _uow.product.Get(productVM.product.Id);
                }
            }
            return View(productVM.product);
        }
    }
}


//