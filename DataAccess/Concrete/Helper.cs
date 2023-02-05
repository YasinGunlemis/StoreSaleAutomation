using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public static class Helper
    {
        public static int ConInt(this object param)
        {
            return Convert.ToInt32(param);
        }

        public static bool ConBool(this object param)
        {
            return Convert.ToBoolean(param);
        }

        public static decimal ConDec(this object param)
        {
            return Convert.ToDecimal(param);
        }

        public static DateTime ConDate(this object param)
        {
            return Convert.ToDateTime(param);
        }

        public static MemoryStream ConMemoryStream(this object param)
        {
            byte[] img = (byte[])param;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        public static string InnerTrim(this string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }
    }
}
