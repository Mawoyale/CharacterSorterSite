namespace CharacterSorterSite.Models
{
    public class Match
    {
        public int Id { get; set; } //primary key property

        public int CharacterThatWonId { get; set; } //(the winner) foreign key property

        public int CharacterThatLostId { get; set; } //foreign key property
    }
}
