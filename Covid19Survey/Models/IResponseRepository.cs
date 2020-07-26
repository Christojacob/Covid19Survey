using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Models
{
    public interface IResponseRepository
    {
        IQueryable<UserResponse> ResponseCollection { get; }

        void AddResponse(UserResponse response);
    }
}
