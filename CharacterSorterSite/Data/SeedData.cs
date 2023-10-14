using CharacterSorterSite.Models;
using System.Globalization;

namespace CharacterSorterSite.Data
{
    public static class SeedData
    {

        public static IEnumerable<Franchise> GetFranchiseData()
        {
            List<Franchise> franchises = new List<Franchise>()
            {
                new Franchise
                {
                    Id = 1,
                    Creator = "Masashi Kishimoto",
                    DateofCreation = new DateTime(1999,9,21),
                    Name = "Naruto"
                },
                 new Franchise
                {
                    Id = 2,
                    Creator = "Key",
                    DateofCreation = new DateTime(2004,04,28),
                    Name = "Clannad"
                },
                  new Franchise
                {
                    Id = 3,
                    Creator = "5pb",
                    DateofCreation = new DateTime(2009,10,15),
                    Name = "Steins; Gate"
                },
                    new Franchise
                {
                    Id = 4,
                    Creator = "07th Expansion",
                    DateofCreation = new DateTime(2007,08,17),
                    Name = "Umineko"
                },
                    new Franchise
                {
                    Id = 5,
                    Creator = "Gainax",
                    DateofCreation = new DateTime(2007,04,1),
                    Name = "Gurren Lagann"
                },
                    new Franchise
                {
                    Id = 6,
                    Creator = "Studio Gokumi",
                    DateofCreation = new DateTime(2014,10,17),
                    Name = "Yuuki Yuuna's a Hero"
                }
            };

            return franchises;
        }




        public static IEnumerable<Character> GetDragonballCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            using (var read = new StreamReader("Dragon_Ball_Data_Set.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                }
            }

            List<Character> dragonballCharacters = new List<Character>();

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    var character = new Character();
                    character.Id = i;
                    character.Name = column1[i];
                    character.FranchiseId = 1;
                    character.VoteCount = 1;

                    dragonballCharacters.Add(character);

                }
            }

            return dragonballCharacters;
        }


        public static IEnumerable<Character> GetNarutoCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Naruto.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> narutoCharacters = new List<Character>();

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    var character = new Character();
                    character.Id = i;
                    character.Name = column2[i];
                    character.FranchiseId = 1;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    narutoCharacters.Add(character);

                }
            }

            return narutoCharacters;
        }

        public static IEnumerable<Character> GetClannadCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Clannad.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> clannadCharacters = new List<Character>();
            int count = 215;

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    count++;
                    var character = new Character();
                    character.Id = count;
                    character.Name = column2[i];
                    character.FranchiseId = 2;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    clannadCharacters.Add(character);

                }
            }

            return clannadCharacters;
        }

        public static IEnumerable<Character> GetSteinsGateCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Steins Gate.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> steinGateCharacters = new List<Character>();
            int count = 225;

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    count++;
                    var character = new Character();
                    character.Id = count;
                    character.Name = column2[i];
                    character.FranchiseId = 3;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    steinGateCharacters.Add(character);

                }
            }

            return steinGateCharacters;
        }

        public static IEnumerable<Character> GetUminekoCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Umineko.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> UminekoCharacters = new List<Character>();
            int count = 235;

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    count++;
                    var character = new Character();
                    character.Id = count;
                    character.Name = column2[i];
                    character.FranchiseId = 4;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    UminekoCharacters.Add(character);

                }
            }

            return UminekoCharacters;
        }

        public static IEnumerable<Character> GetGurrenLagannCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Gurren Lagann.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> GurrenLagannCharacters = new List<Character>();
            int count = 297;

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    count++;
                    var character = new Character();
                    character.Id = count;
                    character.Name = column2[i];
                    character.FranchiseId = 5;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    GurrenLagannCharacters.Add(character);

                }
            }

            return GurrenLagannCharacters;
        }

        public static IEnumerable<Character> GetYuukiYuunaCharactersData()
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            using (var read = new StreamReader("Yuuki Yuuna.csv"))
            {
                while (!read.EndOfStream)
                {
                    var splits = read.ReadLine().Split(',');
                    column1.Add(splits[0].Replace("\"", string.Empty));
                    column2.Add(splits[1].Replace("\"", string.Empty));
                    column3.Add(splits[2].Replace("\"", string.Empty));
                    column4.Add(splits[3].Replace("\"", string.Empty));
                    column5.Add(splits[4].Replace("\"", string.Empty));
                }
            }

            List<Character> YuukiYuunaCharacters = new List<Character>();
            int count = 335;

            for (int i = 0; i < column1.Count; i++)
            {
                if (i != 0)
                {
                    count++;
                    var character = new Character();
                    character.Id = count;
                    character.Name = column2[i];
                    character.FranchiseId = 6;
                    character.VoteCount = 0;
                    character.CharacterImage = column5[i];

                    YuukiYuunaCharacters.Add(character);

                }
            }

            return YuukiYuunaCharacters;
        }







    }


}
