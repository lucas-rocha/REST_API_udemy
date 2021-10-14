using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest_api_udemy.Hypermedia.Constants
{
    public sealed class ResponseTypeFormat
    {
        public const string DefaultGet = "application/json";
        public const string DefaultPost = "application/json";
        public const string DefaultPut = "application/json";
        public const string DefaultPatch = "application/json";
        // delete não retorna nada portanto não precisa adicionar
    }
}
