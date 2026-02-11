using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial05.Q5_05
{
    public class JsonRpcRequest
    {
        public string jsonrpc { get; set; } = "2.0";
        public int id { get; set; }
        public string method { get; set; } = "";
        public object[] @params { get; set; } = Array.Empty<object>();
    }
}
