using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Client
    {
        public int ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string PATRONYMIC { get; set; }
        public string ADRESS { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string EMAIL { get; set; }
        public bool REGULAR { get; set; }
        public int? DISCOUNT_ID { get; set; }
    }
}
