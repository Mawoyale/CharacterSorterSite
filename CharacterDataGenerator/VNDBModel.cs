using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataGenerator
{
    public class VNDBModel
    {
        public List<VNDBCharacter> Results { get; set; }
        public bool More { get; set; }
        //public string Normalized_Filters { get; set; }
    }

    public class VNDBCharacter
    {
        public string Id { get; set; }

        public Image Image { get; set; }

        public string Name { get; set; }

    }

    public class Image
    {
        public string Url { get; set; }
    }
}
