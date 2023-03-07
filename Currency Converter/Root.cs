using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class Root
    {
        public Rate rates { get; set; }
        public long timestamp;
        public string license;
    }
}
