using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal static class Medot
    {
        public static bool PasswordChecker(this string value)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            bool HasLower = false;
            if (!string.IsNullOrEmpty(value) && value.Length>7)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i]))
                        HasUpper = true;
                    else if (char.IsLower(value[i]))
                        HasLower = true;
                    else if (char.IsDigit(value[i]))
                        HasDigit = true;
                }
                if (HasDigit && HasLower && HasUpper)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
