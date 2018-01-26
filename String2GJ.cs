using System;
using System.Collections.Generic;
using System.Text;

namespace Tools2GJ
{
    public class String2GJ
    {
        public String ConvBase64UTF8ToString(String InStr)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(InStr));
        }

        public String ConvStringToBase64UTF8(String InStr)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(InStr));
        }
    }
}
