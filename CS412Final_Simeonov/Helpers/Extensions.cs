using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Simeonov.Helpers
{
    public static class Extensions
    {
        public static string GetNullString(this MySqlDataReader reader, string colName)
        {
            int colIndex = reader.GetOrdinal(colName);
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return null;
        }
    }
}