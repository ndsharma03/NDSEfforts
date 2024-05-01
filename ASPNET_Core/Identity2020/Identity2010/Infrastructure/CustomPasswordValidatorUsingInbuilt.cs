using Identity2010.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity2010.Infrastructure
{
    /// <summary>
    /// This class will implement core password policy provided by Identity as well implements two new rule.
    /// </summary>
    public class CustomPasswordValidatorUsingInbuilt:PasswordValidator<AppUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)

        {
            IdentityResult result = await base.ValidateAsync(manager,
            user, password);
            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();

            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsUserName",
                    Description = "Password cannot contain username"
                });
            }
            if (password.Contains("12345"))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsSequence",
                    Description = "Password cannot contain numeric sequence"
                });
            }
            return errors.Count == 0 ? IdentityResult.Success
            : IdentityResult.Failed(errors.ToArray());
        }
    }
}

