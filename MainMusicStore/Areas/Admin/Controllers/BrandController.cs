using MainMusicStore.DataAccess.IMainRepository;
using MainMusicStore.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace MainMusicStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        #region Variables
        private readonly IUnitOfWork _uow;
        #endregion

        #region CTOR
        public BrandController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region API CALLS
        public IActionResult GetAll()
        {
            var allObj = _uow.brand.GetAll();
            return Json(new { data = allObj });
        }
        #endregion

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var deleteData = _uow.brand.Get(id);
            if (deleteData == null)
            {
                return Json(new { success = false, message = "Data Not Found!" });
            }
            _uow.brand.Remove(deleteData);
            _uow.Save();
            return Json(new { success = true, message = "Delete Operation Successfully." });
        }


        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            Brand bra = new Brand();
            if (id == null)
            {
                return View(bra);
            }

            bra = _uow.brand.Get((int)id);
            if (bra != null)
            {
                return View(bra);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Brand brand)
        {
            if (ModelState.IsValid)
            {
                if (brand.Id == 0)
                {
                    //create
                    _uow.brand.Add(brand);
                }
                else
                {
                    //update
                    _uow.brand.Update(brand);
                }
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View(brand);
        }
    }
}
