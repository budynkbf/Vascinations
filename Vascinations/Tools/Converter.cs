using System;
using System.ComponentModel;
using System.Globalization;
using Vascinations.Extensions;

namespace Vascinations.Tools
{
    public class Converter
    {
        public static T ConvertGeneric<T>(object rowCell)

        {
            // zmiana separatora dziesiętnego z kropki na przecinek i odwrotnie dla systemu operacyjnego na en-us i na Pl-pl

            if (typeof(T) == typeof(decimal))
            {
                //    return (T)Convert.ChangeType(rowCell, typeof(T), CultureInfo.InvariantCulture);
                if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.Equals(",") && rowCell.ToString().Contains("."))
                    rowCell = rowCell.ToString().Replace(".", ",");

                if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.Equals(".") && rowCell.ToString().Contains(","))
                    rowCell = rowCell.ToString().Replace(",", ".");

                //var x = Convert.ToDecimal(rowCell, CultureInfo.InvariantCulture);
            }

            try
            {
                if (string.IsNullOrEmpty(rowCell?.ToString()))

                    return default(T);

                if (typeof(T).IsEnum)

                    return (T)Enum.Parse(typeof(T), rowCell.ToString());

                if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition().Equals(typeof(Nullable<>)))

                {
                    if (Nullable.GetUnderlyingType(typeof(T)) == typeof(Guid))

                        return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(rowCell.ToString());

                    if (Nullable.GetUnderlyingType(typeof(T)) == typeof(DateTime))

                        return default;
                    else
                        return (T)Convert.ChangeType(rowCell, Nullable.GetUnderlyingType(typeof(T)));
                }

                return (T)Convert.ChangeType(rowCell, typeof(T));
            }
            catch (Exception e)

            {
                Logs.AddLogError("ConvertGeneric " + Environment.NewLine + rowCell.ToString() + Environment.NewLine + e.Message);
                return default;
            }
        }
    }
}