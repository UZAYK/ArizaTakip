using ArizaTakip.Business.Interfaces;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ArizaTakip.Web.Controllers
{
   
    public class LoginController : Controller
    {
        private readonly ArizaTakipContext _contex;
        public LoginController(ArizaTakipContext context)
        {
            _contex = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View ();
        }
       
        public IActionResult Login(string users, string password)
        {

            var user = _contex.Personels.FirstOrDefault(x => x.PerUser.Equals(users) && x.Password.Equals(password));
            if (user != null)
            {
                HttpContext.Session.SetInt32("id", user.Id);
                HttpContext.Session.SetString("fullname", user.PerUser + "" + user.Password);

            
               
                return Redirect("/Home/Index");
            }
            else
            {
                ModelState.AddModelError("", "EMail veya şifre hatalı!");
               
            }
            return View();
        }
    }
}
