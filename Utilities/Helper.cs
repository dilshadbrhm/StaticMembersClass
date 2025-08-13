using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StaticMembersClassTask.Utilities
{
    internal static class Helper
    {


        public static string Capitalize(this string name)
        { 
            return  char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
        public static bool ChechName(this string name)
        {
           
            if (name.Length >= 3 && name.Length <= 25)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
    }
}
