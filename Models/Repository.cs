using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class Repository
    {
        private static List<Response> responses =new List<Response>();
        public static IEnumerable<Response> Responses => responses;
        public static void AddResponse(Response response)
        {
            responses.Add(response);
        }
    }
}
