using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sonavia
{
    internal class Utils
    {
        public static class Color
        {
            public static System.Drawing.Color orange = ColorTranslator.FromHtml("#E78A20");
            public static System.Drawing.Color lightGray = ColorTranslator.FromHtml("#706767");
            public static System.Drawing.Color darkGray = ColorTranslator.FromHtml("#272424");
            public static System.Drawing.Color fullBlack = ColorTranslator.FromHtml("#161616");
        }

        public static string ConvertStringArrayToOneString(string[] array)
        {
            string oneString = "";

            foreach (string entry in array)
            {
                oneString += entry;
                if (entry != array.Last())
                {
                    oneString += ", ";
                }
            }

            return oneString;
        }
    }
}
