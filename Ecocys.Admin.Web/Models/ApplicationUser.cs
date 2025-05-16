﻿using Microsoft.AspNetCore.Identity;

namespace Ecocys.Admin.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string FullName { get; set; }
    }
}
