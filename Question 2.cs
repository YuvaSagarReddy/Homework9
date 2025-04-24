using System;
namespace HomeWork9
{
    public class Solution2
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char first = s[i];
                s[i] = s[j];
                s[j] = first;
                i++;
                j--;
            }
        }
    }

}

