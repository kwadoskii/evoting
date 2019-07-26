using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    public class GlobalClass
    {
        public string GetConnectionString()
        {
            string connectionString = "data source=.\\sqlexpress;initial catalog=testdb;user id=VotingSecurity;password=chikwado;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            return connectionString;
        }
    }
}
