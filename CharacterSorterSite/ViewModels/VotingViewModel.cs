using CharacterSorterSite.Models;

namespace CharacterSorterSite.ViewModels
{
    public class VotingViewModel
    {
        public List<Character> Characters { get; set; }

        //public Match Match { get; set; }

        public int FirstCharacterId { get; set; } //(the winner) foreign key property

        public int SecondCharacterId { get; set; } //foreign key property

        public string FranchiseIds { get; set; }  


    }
}
