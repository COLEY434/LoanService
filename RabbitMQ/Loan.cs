using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ
{
    internal class Loan
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime RequestDate { get; set; }

    }
}
