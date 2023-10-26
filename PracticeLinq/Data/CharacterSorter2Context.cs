using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PracticeLinq.Models;

namespace PracticeLinq.Data;

public partial class CharacterSorter2Context : DbContext
{
    public CharacterSorter2Context()
    {
    }

    public CharacterSorter2Context(DbContextOptions<CharacterSorter2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<Franchise> Franchises { get; set; }

    public virtual DbSet<Match> Matches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=IMPERIAL-LIBERA;Initial Catalog=CharacterSorter2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasIndex(e => e.FranchiseId, "IX_Characters_FranchiseId");

            entity.HasOne(d => d.Franchise).WithMany(p => p.Characters).HasForeignKey(d => d.FranchiseId);
        });

        modelBuilder.Entity<Match>(entity =>
        {
            entity.HasIndex(e => e.CharacterId, "IX_Matches_CharacterId");

            entity.HasOne(d => d.Character).WithMany(p => p.Matches).HasForeignKey(d => d.CharacterId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
