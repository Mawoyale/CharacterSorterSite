using CharacterSorterSite.Models;
using System.ComponentModel.DataAnnotations;

namespace CharacterSorterSite.ViewModels
{
    public class FranchiseViewModel
    {
        [Display(Name = "Naruto")]
        public bool NarutoFranchiseID { get; set; }

        [Display(Name = "Yuuki Yuuna")]
        public bool YuukiYuunaFranchiseID { get; set; }

        [Display(Name = "Gurren Lagann")]
        public bool GurrenLagannFranchiseID { get; set; }

        [Display(Name = "Clannad")]
        public bool ClannadFranchiseID { get; set; }

        [Display(Name = "Umineko")]
        public bool UminekoFranchiseID { get; set; }

        [Display(Name = "Steins Gate")]
        public bool SteinsGateFranchiseID { get; set; }
    }
}
