using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SchoolManagement.Models;
using System;

[assembly: OwinStartupAttribute(typeof(SchoolManagement.Startup))]
namespace SchoolManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        public void CreateRolesAndUsers()
        {
            var context = new ApplicationDbContext();

            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //var user = new ApplicationUser
            //{
            //    UserName = "admin",
            //    Email = "admin@umer.com",
            //    BirthDate = DateTime.Now
            //};

            //var password = "password";

            //var usr = UserManager.Create(user, password);

            //if (usr.Succeeded)
            //{
            //    var result = UserManager.AddToRole(user.Id, "Admin");
            //}
            if (!RoleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                RoleManager.Create(role);
                
               
            }


            if (!RoleManager.RoleExists("Teacher"))
            {
                var role = new IdentityRole();
                role.Name = "Teacher";
                RoleManager.Create(role);
            }


            if (!RoleManager.RoleExists("Supervisor"))
            {
                var role = new IdentityRole();
                role.Name = "Supervisor";
                RoleManager.Create(role);
            }
        }
    }
}
