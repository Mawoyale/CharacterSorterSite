using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataGenerator
{
    public class MALModel
    {
        public List<MalObject> Data { get; set; }
    }
    public class MalObject
    {
        public Node Node { get; set; }
    }

    public class Node
    {
        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }


        public Main_Picture Main_Picture { get; set; }


    }

    public class Main_Picture
    {
        public string Medium { get; set; }
    }
}
