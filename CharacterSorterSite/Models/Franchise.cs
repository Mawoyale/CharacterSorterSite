

namespace CharacterSorterSite.Models
{
    public class Franchise
    {
        public int Id { get; set; } //primary key property

        public string Name { get; set; }

        public string Creator { get; set; }

        public DateTime DateofCreation { get; set; }


        public ICollection<Character> Characters { get; set; } // Navigation property


    }
}
