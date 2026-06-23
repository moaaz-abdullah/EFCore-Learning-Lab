using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    internal static class Connections
    {
        public const string SqlConnectionString = """
           
            Server=MOAAZ;
            Database=dbEF;
            Trusted_Connection=True;
            TrustServerCertificate=True;
                    
            """;
    }
}
