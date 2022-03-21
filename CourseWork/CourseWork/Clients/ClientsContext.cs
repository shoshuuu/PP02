using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Clients
{
    class ClientsContext : DbContext
    {
        public ClientsContext() : base("")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
