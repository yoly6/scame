﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCAME.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "i-rol")]
    public class RolUsersTH : TagHelper
    {
        private UserManager<IdentityUser> userManager;
        private RoleManager<IdentityRole> rolManager;

        public RolUsersTH(UserManager<IdentityUser> usermgr, RoleManager<IdentityRole> rolemgr)
        {
            userManager = usermgr;
            rolManager = rolemgr;
        }

        [HtmlAttributeName("i-rol")]
        public string Rol { get; set; }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            IdentityRole rol = await rolManager.FindByIdAsync(Rol);
            if (rol != null)
            {
                foreach (var user in userManager.Users)
                {
                    if (user != null && await userManager.IsInRoleAsync(user, rol.Name))
                        names.Add(user.UserName);
                }
            }
            output.Content.SetContent(names.Count == 0 ? "No Users" : string.Join(", ", names));
        }
    }
}