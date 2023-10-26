using System;
using System.Collections.Generic;

namespace PracticeLinq.Models;

public partial class Franchise
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Creator { get; set; } = null!;

    public DateTime DateofCreation { get; set; }

    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();
}
