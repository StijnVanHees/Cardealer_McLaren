using McLaren_Cardealer.Areas.Identity.Data;
using McLaren_Cardealer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Threading.Tasks;

namespace McLaren_Cardealer.Controllers
{
    //[Authorize(Roles ="admin")]
    public class GebruikerController : Controller
    {
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public GebruikerController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            GebruikerListViewModel glvm = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList()
            };
        return View(glvm);
            
        }

        public IActionResult Edit(string id)
        {
            CustomUser gebruiker = _userManager.Users.Where(k => k.Id == id).FirstOrDefault();
            if (gebruiker != null)
            {
                GebruikerEditViewModel gevm = new GebruikerEditViewModel()
                {
                    Naam = gebruiker.Naam,
                    Email = gebruiker.Email,
                    GebruikerId = id
                };
                return View(gevm);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GebruikerEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser gebruiker = await _userManager.FindByIdAsync(viewModel.GebruikerId);

                gebruiker.Naam = viewModel.Naam;
                gebruiker.Email = viewModel.Email;

                IdentityResult result = await _userManager.UpdateAsync(gebruiker);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }

        public IActionResult Create()
        {

            return View();   
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGebruikerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                CustomUser gebruiker = new CustomUser
                {
                    Naam = viewModel.Naam,
                    Email = viewModel.Email
                };

                IdentityResult result = await _userManager.CreateAsync(gebruiker, viewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User nor found");
            }
            return View("Index", _userManager.Users.ToList());
        }


        public IActionResult GrantPermission()
        {
            GrantPermissionViewModel viewModel = new GrantPermissionViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(), "id", "UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> GrantPermission(GrantPermissionViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User or role not found");
                }


            }
            return View(viewModel);
        }
    }
}
