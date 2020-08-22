using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Models
{
    public class Game
    {
        public string Name {get;set;}
        [Key]
        public string Key { get; set; }

    }
}
