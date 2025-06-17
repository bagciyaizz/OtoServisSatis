using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;

namespace OtoServisSatis.WebUI.Controllers
{
    public class CarServiceController : Controller
    {
        private readonly ICarService _serviceArac;
        private readonly IService<Musteri> _serviceMusteri;
        private readonly IUserService _serviceUser;
        private readonly IService<Servis> _serviceServis;

        public CarServiceController(ICarService serviceArac, IService<Musteri> serviceMusteri, IUserService serviceUser, IService<Servis> serviceServis)
        {
            _serviceArac = serviceArac;
            _serviceMusteri = serviceMusteri;
            _serviceUser = serviceUser;
            _serviceServis = serviceServis;
        }
        // GET: CarServiceController
        public ActionResult Index()
        {
            var model = new Servis();
            if (User.Identity.IsAuthenticated)
            {
                var email = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;
                var uguid = User.FindFirst(System.Security.Claims.ClaimTypes.UserData)?.Value;
                if (!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(uguid))
                {
                    var user = _serviceUser.Get(k => k.Email == email && k.UserGuid.ToString() == uguid);
                    if (user != null)
                    {
                        model.Notlar = $"Ad: {user.Adi}\nSoyad: {user.Soyadi}\nTelefon: {user.Telefon}";
                    }
                }
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Servis servis)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _serviceServis.AddAsync(servis);
                    await _serviceServis.SaveAsync();
                    TempData["Message"] = "<div class='alert alert-success'>Talebiniz Alınmıştır. En kısa sürede tarafınıza dönüş yapılacaktır. Teşekkürler..</div>";
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    TempData["Message"] = "<div class='alert alert-danger'>Bir Hata Oluştu!</div>";
                }
            }
            return View();
        }

        // GET: CarServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
