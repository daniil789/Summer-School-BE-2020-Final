using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Interfaces
{
   public interface IValidateService
    {
        bool LuhnAlgorithm(string number);
    }
}
