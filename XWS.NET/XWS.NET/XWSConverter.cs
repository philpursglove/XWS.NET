using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace XWS.NET
{
    public class XWSConverter
    {
        public Squadron FromJson(string xwsJson)
        {
            return JsonSerializer.Deserialize<Squadron>(xwsJson);
        }
    }
}
