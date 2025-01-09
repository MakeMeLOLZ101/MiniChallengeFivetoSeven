using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFivetoSeven.Services
{
    public class ReverseItAlphaServices
    {
        public string ReverseItAlpha(string inputString)
        {
            string result = "";
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }
            return result;
        }
    }
}