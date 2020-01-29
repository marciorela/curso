using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MRsoft.Store.Data.EF;
using MRsoft.Store.Domain.Contracts.Data;
using MRsoft.Store.Domain.Contracts.Repositories;
using MRsoft.Store.Domain.Helpers;
using MRsoft.Store.Domain.ViewModels;
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
        private IUsuarioRepository _usuarioRepo;
        private IUnitOfWork _uow;

        public AuthController(IUsuarioRepository usuarioRepo, IUnitOfWork uow)
        {
            _usuarioRepo = usuarioRepo;
            _uow = uow;
        }

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string returnUrl, SignInVM model)
        {
            if (!ModelState.IsValid) {
                return View(model);
            }

            var usuario = await _usuarioRepo.AuthenticateAsync(model.Email, model.Senha);
            if (usuario == null)
            {
                ModelState.AddModelError("", "E-mail ou senha inválidos.");
                return View(model);
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
