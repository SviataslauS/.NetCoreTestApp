using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Common
{
    public class AppSettings
    {
        public string JwtVerifySecret { get; set; }
        public double VAT { get; set; }
    }
}
