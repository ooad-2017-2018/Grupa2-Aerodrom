using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodrom.DB
{
   public class ConnectionString
   {
        private String s;
        public ConnectionString()
        {
            s = "Server=tcp:aerodromserver.database.windows.net,1433;Initial Catalog=AerodromBaza;Persist Security Info=False;User ID=nejra_imsirovic;Password=oTohthieNgah1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public String GetString() { return s; }
    }
}
