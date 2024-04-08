using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Entity
{
    public class Setting
    {

        public int id { get; set; }
        public required string key { get; set; }
        public required string text { get; set; }

    }
}