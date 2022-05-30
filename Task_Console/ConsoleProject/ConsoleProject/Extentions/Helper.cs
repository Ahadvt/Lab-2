using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Extentions
{
   static class Helper
    {

        public static bool Lock(this bool d)
        {
            return false;
        }
        public static bool Unlock(this bool d)
        {
            return true;
        }
    }
}
