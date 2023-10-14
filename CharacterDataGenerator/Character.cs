using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace CharacterDataGenerator
{
    public class Character
    {
        public int Id { get; set; } //primary key property

        public string Name { get; set; }

        public int FranchiseId { get; set; } // foreign key property

        public int VoteCount { get; set; }

        public string CharacterImage { get; set; }
    }
}
