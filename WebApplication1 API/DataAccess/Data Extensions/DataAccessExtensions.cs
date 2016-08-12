using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtensions
{
    public static class DataAccessExtensions
    {
        public static T GetValue<T>(this IDataReader reader, int fieldIndex)
        {
            var tType = typeof(T);
            var val = reader[fieldIndex];
            if (val != DBNull.Value)
            {
                if (tType == typeof(string))
                {
                    return (T)Convert.ChangeType(val, typeof(string));
                }

                if (tType == typeof(int))
                {
                    return (T)Convert.ChangeType(val, typeof(int));
                }

                if (tType == typeof(bool))
                {
                    return (T)Convert.ChangeType(val, typeof(bool));
                }

                if (tType == typeof(DateTime))
                {
                    return (T)Convert.ChangeType(val, typeof(DateTime));
                }
                if (tType == typeof(string[]))
                {
                    return (T)Convert.ChangeType(val, typeof(string[]));
                }
                return (T)val;
            }
            return default(T);
        }


    }
}


