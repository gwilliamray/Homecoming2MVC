using System;
using HomeComingMVCFall18.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeComingMVCFall18.Startup))]
namespace HomeComingMVCFall18
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if(!roleManager.RoleExists("Admin"))
            {
                // first create the role
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();

                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();

                user.UserName = "SuperUser";
                user.Email = "Scc@12345.com";

                string userPWD = "Scc@12345";

                var chkUser = UserManager.Create(user, userPWD);

                if(chkUser.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, "Admin");
                   
                }





            }

        }
    }
}
