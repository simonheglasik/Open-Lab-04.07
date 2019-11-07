using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            string a = "";
            for(int i=original.Length-1; i >= 0; i--)
            {
                a = a + original[i];
            }
            return a;
        }
    }
}
