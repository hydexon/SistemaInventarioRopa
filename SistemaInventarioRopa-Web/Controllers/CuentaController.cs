using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SistemaInventarioRopa_Web.Models;

namespace SistemaInventarioRopa_Web.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        public CuentaController()
            : this(new UserManager<Usuario>(new UserStore()))
        {

        }

        public CuentaController(UserManager<Usuario> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<Usuario> UserManager { get; private set; }

        // GET: Cuenta/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUri)
        {
            ViewBag.ReturnUrl = returnUri;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string obj, string returnUrl)
        {
            var datos = Request.Form;
            return View();
        }
        // GET: Cuenta
        public ActionResult Index()
        {
            return View();
        }
    }
}