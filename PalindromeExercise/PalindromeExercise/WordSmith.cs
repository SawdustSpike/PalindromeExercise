using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string pal)
        {
            bool isTrue = true;
            int i = pal.Length - 1;
            foreach (var item in pal)
            {
                 if (pal[i] != item)
                    {
                        isTrue = false;
                    }
                i--;
            }
            return isTrue;
        }

    }
}
