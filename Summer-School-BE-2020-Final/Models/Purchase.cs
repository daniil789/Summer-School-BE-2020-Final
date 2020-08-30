using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Models
{
    public class Purchase
    {
        public string Id { get; set; }
        public string CardNumber { get; set; }
        public string CardCVM { get; set; }
        public DateTime CardDate { get; set; }
        public string Game { get; set; }
    }
}
