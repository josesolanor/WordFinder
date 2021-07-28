using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Application
{
    public class Validations
    {
        public bool OnlyLettersOnString(string value)
        {
            return Regex.IsMatch(value.ToLower(), "^[a-z]+$");
        }

        public bool MaxSize(List<string> value)
        {
            if (value.Count > 64)
            {
                return false;
            }

            for (int i = 0; i < value.Count; i++)
            {
                if (value[i].Length > 64)
                {
                    return false;
                }
                
            }

            return true;
        }

    }
}
