using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp
{
    public static class StaticDetails
    {
        public static string DrugAPIBase { get; set; }
        public enum APIType
        {
        GET,
        POST,
        PUT,
        DELETE
        }
    }
}
