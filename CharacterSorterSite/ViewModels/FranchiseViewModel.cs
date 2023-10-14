using CharacterSorterSite.Models;

namespace CharacterSorterSite.ViewModels
{
    public class FranchiseViewModel
    {
        public List<Franchise> Franchises { get; set; } 
        public bool SelectAll { get; set; }
        public bool DeselectAll { get; set; }
    
    }
}
