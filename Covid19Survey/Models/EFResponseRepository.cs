using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Models
{
    public class EFResponseRepository : IResponseRepository
    {
        private ApplicationDbContext context;

        public EFResponseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<UserResponse> ResponseCollection => context.ResponseCollection;
        public void AddResponse(UserResponse response)
        {
            context.ResponseCollection.Add(response);
            context.SaveChanges();
        }

    }
}
