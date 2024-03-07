namespace GolfTour.Web.Middlewares
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Azure.Core;
    using GolfTour.Common;
    using GolfTour.Data.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;

    public class AdminMiddleware
    {
        private readonly RequestDelegate next;

        public AdminMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, UserManager<GolfTourUser> userManager)
        {
            await this.SeedUserInRoles(userManager);
            await this.next(context);
        }

        private async Task SeedUserInRoles(UserManager<GolfTourUser> userManager)
        {
            var user = new GolfTourUser
            {
                UserName = GlobalConstants.AdministratorUserName,
                Email = GlobalConstants.AdministratorEmail,
                FullName = GlobalConstants.AdministratorFullName,
            };
            var result = await userManager.CreateAsync(user, GlobalConstants.AdministratorPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
            }
            else
            {
                throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
            }
        }
    }
}
