﻿using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola minimum {length} karakter olmalıdır."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola En az 1 büyük karakter içermelidir."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola En az 1 küçük karakter içermelidir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
                {
                return new IdentityError()
                {
                    Code = "PasswordRequiresNonAlphanumeric",
                    Description = "Parola En az 1 özel karakter içermelidir."
                };
            }
        }
    }
}

