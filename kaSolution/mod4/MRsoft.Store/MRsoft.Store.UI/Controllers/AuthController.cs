using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Helpers;
using MRsoft.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Controllers
{
    public class AuthController : Controller
    {
        private StoreDataContext _ctx;

        public AuthController(StoreDataContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        public async Task<IActionResult> SignIn(string returnUrl, SignInVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(x => x.Email == model.Email && x.Senha == model.Senha.Encrypt());
            if (usuario == null)
            {
                return Unauthorized();
            }

            var claims = new List<Claim>()
            {
                new Claim("id", usuario.Id.ToString()),
                new Claim("nome", usuario.Nome),
                new Claim("email", usuario.Email),
                new Claim("roles", "admin,ti,estagiario")
            };
            var identity = new ClaimsIdentity(
                claims, 
                CookieAuthenticationDefaults.AuthenticationScheme,
                "nome", "roles" 
                );
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal, new AuthenticationProperties {
                IsPersistent = model.Lembrar,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(10)
            });

            return Redirect(returnUrl ?? "/");
        }

        [HttpGet]
        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
