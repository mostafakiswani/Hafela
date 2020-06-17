using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public class ConverterServices
    {
        public static string ConvertGuid(Guid id)
        {
            return id.ToString();
        }
    }
}
