﻿namespace Alta.Utils
{
    public static class StringExtension
    {
        public static string LastChars(this string s, int last)
        {
            return s.Substring(s.Length - last, s.Length);
        }
    }
}