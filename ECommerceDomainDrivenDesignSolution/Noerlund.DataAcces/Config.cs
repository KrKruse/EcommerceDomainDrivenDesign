using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noerlund.DataAcces
{
    internal static class Config
    {
        // connectionstring for db
        public static readonly string DbConnStr = "Server=tcp:kristofferkruse.database.windows.net,1433;Initial Catalog=NoerlundDB;Persist Security Info=False;User ID=krk;Password=Bil12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
