using CharacterSorterSite;

using Microsoft.EntityFrameworkCore;

namespace CharacterSorterSite.Models
{
    public class Character
    {
        public int Id { get; set; } //primary key property

        public string Name { get; set; }

        public int FranchiseId { get; set; } // foreign key property

        public int VoteCount { get; set; }

        public string CharacterImage { get; set; }


        public Franchise Franchise { get; set; } // navigation property


        public ICollection<Match>? Matches { get; set; } // navigation property
    }

}
