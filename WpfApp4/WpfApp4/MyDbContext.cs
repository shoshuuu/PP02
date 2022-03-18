using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("Server=DESKTOP-B4V8TQN;Database=УП02;Integrated Security=Yes;")
        { }

    }
}
