using System;
namespace HomeWork9
{
    public class Solution3
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();

            string[] words = s.Split(' ');

            return words[^1].Length;

        }
    }

}

