using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string val)
        {
            val = val.ToLower();

            char[] charArray = val.ToCharArray();

            Array.Reverse(charArray);

            string reversed = new string(charArray);

            if(reversed == val)
            {
                return true;
            }
            return false;
        }
    }
}
