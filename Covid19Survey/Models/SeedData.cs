using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.ResponseCollection.Any())
            {
                context.ResponseCollection.AddRange(
                new UserResponse { Name = "James", Email = "james@somemail.com", Phone = "123213123", WearMask = true, PublicTransportation = false, Work = false },
                new UserResponse { Name = "Jacob", Email = "jacob@somemail.com", Phone = "123123123", WearMask = true, PublicTransportation = false, Work = false },
                new UserResponse { Name = "John", Email = "john@somemail.com", Phone = "123123123", WearMask = true, PublicTransportation = false, Work = false },
                new UserResponse { Name = "Tony", Email = "tony@somemail.com", Phone = "123123123", WearMask = true, PublicTransportation = false, Work = false }
                );
                context.SaveChanges();
            }
        }
    }
}




