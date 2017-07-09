using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace j223nTools.Network
{
    public class NicSetting
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public int NetworkInterfaceType { get; set; }

        public bool IPv4IsDHCP { get; set; }

        public string IPv4Address { get; set; }

    }
}
