using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Survey.Models
{
    public static class Repository
    {
        public static List<UserResponse> ResponseCollection = new List<UserResponse>();
        public static IEnumerable<UserResponse> getAllRespose()
        {
            return ResponseCollection;
        }
        public static void AddResponse(UserResponse userResponse)
        {
            ResponseCollection.Add(userResponse);
        }
    }
}
