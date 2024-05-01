using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace UserManagement.ExtraCode
{
      public class CustomPasswordValidator : IPasswordValidator<IdentityUser>
        {
            public Task<IdentityResult> ValidateAsync(UserManager<IdentityUser> manager,
            IdentityUser user, string password)
            {
                List<IdentityError> errors = new List<IdentityError>();
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
                return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
            }
        }
    public class CustomUserValidator : IUserValidator<IdentityUser>
    {
        
        public Task<IdentityResult> ValidateAsync(UserManager<IdentityUser> manager,
        IdentityUser user)
        {
            if (user.Email.ToLower().EndsWith("@example.com"))
            {
                return Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only example.com email addresses are allowed"
                }));
            }
        }
    }

    //===Another Way Insted of Interface we can override method provided by class UserValidator
    public class CustomUserValidator1: UserValidator<IdentityUser> {
        public override async Task<IdentityResult> ValidateAsync(
        UserManager<IdentityUser> manager,
        IdentityUser user)
        {
            IdentityResult result = await base.ValidateAsync(manager, user);
            List<IdentityError> errors = result.Succeeded ?
            new List<IdentityError>() : result.Errors.ToList();
            if (!user.Email.ToLower().EndsWith("@example.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only example.com email addresses are allowed"
                });
            }
            return errors.Count == 0 ? IdentityResult.Success
            : IdentityResult.Failed(errors.ToArray());
        }
    }


    //******************* On Configure Services *******************
    //      services.AddTransient<IPasswordValidator<AppUser>,
    //      CustomPasswordValidator>();

    //USER
    //      services.AddTransient<IUserValidator<AppUser>,
    //      CustomUserValidator>();
}
