using Microsoft.EntityFrameworkCore;
using CharacterSorterSite.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Hosting;


namespace CharacterSorterSite.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext()
        {
        }

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; } = default!;
        public DbSet<Franchise> Franchises { get; set; } = default!;
        public DbSet<Match> Matches { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Franchise>().HasData(SeedData.GetFranchiseData());

            //modelBuilder.Entity<Character>().HasData(SeedData.GetDragonballCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetNarutoCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetClannadCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetSteinsGateCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetUminekoCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetGurrenLagannCharactersData());
            modelBuilder.Entity<Character>().HasData(SeedData.GetYuukiYuunaCharactersData());




            modelBuilder.Entity<Character>()
              .Property(f => f.Id)
              .ValueGeneratedOnAdd();

            modelBuilder.Entity<Character>()
               .HasOne(c => c.Franchise)
               .WithMany(a => a.Characters)
               .HasForeignKey(c => c.FranchiseId);
            //.OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Matches);
            //.OnDelete(DeleteBehavior.Cascade);




            modelBuilder.Entity<Franchise>()
            .HasMany(f => f.Characters)
            .WithOne(c => c.Franchise);
            //.OnDelete(DeleteBehavior.Cascade);

        }


    }
}
