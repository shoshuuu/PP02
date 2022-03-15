using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ZLOBINA_PP02Entities db = new ZLOBINA_PP02Entities())
            {
                CLIENT c = new CLIENT();
                c.EMAIL = "1";
                c.ADRESS = "1";
                c.FIRST_NAME = "!";
                c.LAST_NAME = "1";
                c.PHONE_NUMBER = "1";
                c.REGULAR = false;
                db.CLIENTS.Add(c);
                db.SaveChanges();
               
            }
            ;
        }
    }
}
