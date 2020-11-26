using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleShop.ProductManagement.Api.Extensions
{
    public class PoliciesExtensions
    {
        public const string Admin = "Admin";
        public const string User = "User";
        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireRole(Admin).Build();
        }

        public static AuthorizationPolicy UserPolicy()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireRole(User).Build();
        }
    }
}
