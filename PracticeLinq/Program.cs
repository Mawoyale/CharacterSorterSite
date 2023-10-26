using PracticeLinq.Data;
using PracticeLinq.Models;

using CharacterSorter2Context _context = new CharacterSorter2Context();


List<Franchise> franchises = _context.Franchises.ToList();


foreach (Franchise franchise in franchises)
{
    Console.WriteLine(franchise.Name);
}



Character character = _context.Characters.FirstOrDefault(c => c.Name == "Naruto Uzumaki");
Console.WriteLine(character.Name);

List<Character> characters = _context.Characters.ToList();
List<Character> narutoCharacters = characters.Where(c => c.FranchiseId == 1).ToList();

//foreach (Character narutoCharacter in narutoCharacters)
//{
//    Console.WriteLine(narutoCharacter.Name);
//}

Character uminekoCharacter = _context.Characters.FirstOrDefault(u => u.Name.Contains("Battler"));
Console.WriteLine(uminekoCharacter.Name);

List<string> gurrenLagannCharacters = _context.Characters.Where(gl => gl.Name.StartsWith("K") && gl.FranchiseId == 5).Select(c => c.Name).ToList();

//gurrenLagannCharacters.ForEach(c => Console.WriteLine(c));

//foreach (string gurrenLagannCharacter in gurrenLagannCharacters)
//{
//    Console.WriteLine(gurrenLagannCharacter);
//}

Character clannadCharacter = _context.Characters.Where(cl => cl.FranchiseId == 2).FirstOrDefault();
Console.WriteLine(clannadCharacter.Name);

List<string> yuukiYuunaCharacters = _context.Characters
    .Where(yy => yy.FranchiseId ==6 )
    .Select(c => c.Name)
    .ToList();

yuukiYuunaCharacters.ForEach(yy => Console.WriteLine(yy));
Console.WriteLine(yuukiYuunaCharacters.Count);

//Character me = new Character()
//{
//    FranchiseId = 6,
//    CharacterImage ="",
//    Name = "John Awoyale"
//};

Character michael = _context.Characters.FirstOrDefault(m => m.Name == "Michael Awoyale");

//_context.Characters.Remove(michael);
//_context.SaveChanges();

List<string> yuukiYuunaCharacters2 = _context.Characters
    .Where(yy => yy.FranchiseId == 6)
    .Select(c => c.Name)
    .ToList();

yuukiYuunaCharacters2.ForEach(yy => Console.WriteLine(yy));
Console.WriteLine(yuukiYuunaCharacters2.Count);

//Character boruto = new Character()
//{
//    FranchiseId = 1,
//    Name = "Boruto Uzumaki",
//    CharacterImage =  ""
//};

//_context.Characters.Add(boruto);
//_context.SaveChanges();


Character boruto = _context.Characters.FirstOrDefault(b => b.Name.Contains("Boruto"));
Console.WriteLine(boruto.Name);