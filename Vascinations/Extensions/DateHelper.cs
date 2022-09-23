using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascinations.Extensions
{
    public class DateHelper
    {
        private readonly static DateTime _minDateTime = new DateTime(1900, 1, 1);

        public static int DateToInt(DateTime data)
        {
            try
            {
                var start = new DateTime(1900, 1, 1);
                var dif = (data - start).TotalDays;
                dif = dif + 36163;
                return Convert.ToInt32(dif);
            }
            catch (Exception ex)
            {
                Logs.AddLogError(ex);
                return 0;
            }
        }

        internal static int DateToInt(object terminRealizacji)
        {
            throw new NotImplementedException();
        }

        public static DateTime IntToDate(int data)
        {
            DateTime d2;
            int d = data - 36163;

            if (d > 0)
            {
                d2 = _minDateTime;
                d2 = d2.AddDays(d);
            }
            else
                d2 = DateTime.MinValue;

            return d2;
        }
    }
}