using System;
using System.Collections.Generic;

namespace PracticeLinq.Models;

public partial class Character
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int FranchiseId { get; set; }

    public int VoteCount { get; set; }

    public string CharacterImage { get; set; } = null!;

    public virtual Franchise Franchise { get; set; } = null!;

    public virtual ICollection<Match> Matches { get; set; } = new List<Match>();
}
