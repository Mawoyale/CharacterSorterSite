using System;
using System.Collections.Generic;

namespace PracticeLinq.Models;

public partial class Match
{
    public int Id { get; set; }

    public int CharacterThatWonId { get; set; }

    public int CharacterThatLostId { get; set; }

    public int? CharacterId { get; set; }

    public virtual Character? Character { get; set; }
}
