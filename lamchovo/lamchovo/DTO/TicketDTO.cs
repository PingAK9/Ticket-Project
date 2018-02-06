using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamchovo.DTO
{
    class TicketDTO
    {
        public int ID { get; set; }
        public DateTime day { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public int client { get; set; }
        public int file { get; set; }
        public int type { get; set; }
        public bool tsn { get; set; }
        public DateTime dayon { get; set; }
    }
}
