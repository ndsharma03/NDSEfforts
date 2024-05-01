using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity2010.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity2010.Controllers
{
    public class AdminController : Controller
    {
        UserManager<AppUser> userManager;
        private IUserValidator<AppUser> userValidator; // we need this 3 validator and hasher to validate user in Edit method
        private IPasswordValidator<AppUser> passwordValidator;// as we are not passing custome model and getting individual property in 
        private IPasswordHasher<AppUser> passwordHasher;// constructor so we need to validte manually.
        public AdminController(UserManager<AppUser> _userManager,
            IUserValidator<AppUser> userValid,
            IPasswordValidator<AppUser> passValid,
            IPasswordHasher<AppUser> passwordHash
            )
        {
            userManager = _userManager;
            userValidator = userValid;
            passwordValidator = passValid;
            passwordHasher = passwordHash;
        }
           
        
        #region CREATE METHOD  
         public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    Email = model.Email,
                    UserName = model.Name

                };
                var createResult=  await userManager.CreateAsync(user, model.Password);

                if (createResult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError err in createResult.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(model);

        }
        #endregion

        #region INDEX METHOD
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
        #endregion

        #region EDIT METHOD
        public async Task<IActionResult> Edit(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string password)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.Email = email;
                IdentityResult validEmail = await userValidator.ValidateAsync(userManager, user);
                if (!validEmail.Succeeded)
                {
                    AddErrorsFromResult(validEmail);
                }
                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager,
                    user, password);
                    if (validPass.Succeeded)
                    {
                        user.PasswordHash = passwordHasher.HashPassword(user, password);
                    }
                    else
                    {
                        AddErrorsFromResult(validPass);
                    }
                }
                if ((validEmail.Succeeded && validPass == null)
                || (validEmail.Succeeded && password != string.Empty && validPass.Succeeded))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        AddErrorsFromResult(result);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View(user);
        }
        #endregion


        #region DELETE METHOD
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            AppUser user=null;
            if (!string.IsNullOrEmpty(id))
            {
                 user = await userManager.FindByIdAsync(id);
            }
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", userManager.Users);
        }
        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
    #endregion
}
