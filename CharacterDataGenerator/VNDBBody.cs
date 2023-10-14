using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataGenerator
{
    public class VNDBBody
    {
        public ArrayList Filters { get; set; }
        public string Fields { get; set; }
        public string Sort { get; set; }
        public bool Reverse { get; set; }
        public object Results { get; set; }
        public int Page { get; set; }
        public object User { get; set; }
        public bool Count { get; set; }
        public bool Compact_filters { get; set; }

        public bool Normalized_filters { get; set; }
    }
}


