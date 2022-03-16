using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class ClientsContext : DbContext
    {
        public ClientsContext() : base("ZLOBINA_PP02Entities")
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
