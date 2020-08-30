using Summer_School_BE_2020_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Services
{
    public class ValidateService : IValidateService
    {
        public bool LuhnAlgorithm(string number)
        {

            long numbercard = Convert.ToInt64(number);
            string str = numbercard.ToString();
            int[] numcard = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                numcard[i] = int.Parse(str[i].ToString());
            }

            for (int i = 0; i < numcard.Length; i += 2)
            {
                var a = numcard[i] * 2;
                numcard[i] = a;
                if (numcard[i] > 9)
                {
                    numcard[i] = numcard[i] - 9;
                }

            }
            int sumnumber = 0;
            for (int i = 0; i < numcard.Length; i++)
            {
                sumnumber = sumnumber + numcard[i];

            }
            if (sumnumber % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
