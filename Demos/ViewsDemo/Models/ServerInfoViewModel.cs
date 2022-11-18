using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsDemo.Models
{
    public class ServerInfoViewModel
    {
        public string MachineName { get; set; }
        public string OperatingSystem { get; set; }
        public string CLRVersion { get; set; }
        public int Cores { get; set; }
    }
}