using CharacterDataGenerator;
using CsvHelper;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;


//List<Character> characters = new List<Character>()
//{
//    new Character
//    {
//        Id = 1,
//        Name = "Naruto",
//        FranchiseId = 1,
//        VoteCount = 0,
//        CharacterImage = "https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABYxJFBDckfZw1YUEIPwyuIg43Kw_HUBLvnCcgdOlvvf5Nc90SF3HSAi5L8uLyBqjziKBY-kGD2wu2JAqVsdHVR0frb6qG26I_U5v.jpg?r=77f"
//    },
//        new Character
//    {
//        Id = 1,
//        Name = "Naruto",
//        FranchiseId = 1,
//        VoteCount = 0,
//        CharacterImage = "https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABYxJFBDckfZw1YUEIPwyuIg43Kw_HUBLvnCcgdOlvvf5Nc90SF3HSAi5L8uLyBqjziKBY-kGD2wu2JAqVsdHVR0frb6qG26I_U5v.jpg?r=77f"
//    }

//};




using (var httpClient = new HttpClient())
{

    string url = "https://beta.vndb.org/api/kana/character";
    //httpClient.DefaultRequestHeaders.Authorization =
    //new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6ImUwNTc4MjhmMDEyZTFkMGVlNzljZDUzOWFkYjYwYTI0ZTJhZDIyM2U5Mjg4MzYzODY4ZGZlNzgwZDllMDY0ZWJmM2M3OTljN2FhMWUwM2RmIn0.eyJhdWQiOiI4NDUwNmY4NmRkNDRmNWY0YzZhNDBkYTc4ZGI2ZDM4YSIsImp0aSI6ImUwNTc4MjhmMDEyZTFkMGVlNzljZDUzOWFkYjYwYTI0ZTJhZDIyM2U5Mjg4MzYzODY4ZGZlNzgwZDllMDY0ZWJmM2M3OTljN2FhMWUwM2RmIiwiaWF0IjoxNjk2MDEzODQ0LCJuYmYiOjE2OTYwMTM4NDQsImV4cCI6MTY5ODYwNTg0NCwic3ViIjoiNDY0NTU4MSIsInNjb3BlcyI6W119.FPFoH25t-qVJNNO0vCilbVN_XuLqpeJnRQ9xOI1KO5WWxTYSUNZCNaz2wpwJ4L5W-z1i6aVicwOPyGr0fQ1OJkh2ju0jTDD0KCp0Wm9ng0D2ZzT7wZ5w2asb2FbgdPyjVkSvOq3_lsIiaZIXAha4ABmUdEwPTjAmhDVBTRJyaPyZEUyrS0b2z6Jo_qEfI7ozFOqySgYnBWAQN8uGnSOAk26xYE92jrGPSRq6n23hHBcm3teZvsf8XCUta_px5AFPFagjjzqN7OTHxciTovQN3BkPu4527Tg0Kd-9TJp6w-rAWPnLRJcamRBDX5JamK4N8xaUvwumzGQcoCPMa1BV9w");
    //var result = await httpClient.GetAsync("https://api.myanimelist.net/v2/anime/20/characters?fields=id,first_name,last_name,role,main_picture,anime&limit=500");
    //var response = await result.Content.ReadAsStringAsync();
    //Console.WriteLine(response);

    //var options = new JsonSerializerOptions
    //{
    //    PropertyNameCaseInsensitive = true
    //};

    //MALModel mALModel = JsonSerializer.Deserialize<MALModel>(response, options);

    //using StreamWriter writer = new StreamWriter("Character.csv");
    //using CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

    //List<Character> characters = new List<Character>();

    //foreach (var character in mALModel.Data)
    //{
    //    if (character.Node.Id == 234151) continue;

    //    characters.Add(
    //        new Character()
    //        {
    //            Name = character.Node.First_Name + " " + character.Node.Last_Name,
    //            FranchiseId = 1,
    //            CharacterImage = character.Node.Main_Picture.Medium
    //        });
    //}

    //    csv.WriteRecords(characters);

    //VNDBBody vNDBBody = new VNDBBody()
    //{
    //    Filters = new ArrayList()
    //    {
    //        "vn", "=", new List<string>{"id", "=", "v4"}
    //    },
    //    Fields = "name, image.url, id",
    //    Sort = "id",
    //    Reverse = false,
    //    Results = null,
    //    Page = 1,
    //    User = null,
    //    Count = false,
    //    Compact_filters = false,
    //    Normalized_filters = true
    //};

    //var options = new JsonSerializerOptions
    //{
    //    PropertyNameCaseInsensitive = true,
    //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    //};

    //var vNDBBodyJson = JsonSerializer.Serialize(vNDBBody, options);
    //var requestContent = new StringContent(vNDBBodyJson, Encoding.UTF8, "application/json");



    //httpClient.DefaultRequestHeaders.Add("x-vndb-apikey", "3gqy-y4n36-wuogp-tp6g-6gf1x-y86wf-rn5y");

    //var response = await httpClient.PostAsync(url, requestContent);
    //response.EnsureSuccessStatusCode();

    //var content = await response.Content.ReadAsStringAsync();

    //Console.WriteLine(content);

    //var vNDBModel = JsonSerializer.Deserialize<VNDBModel>(content, options);



    //using StreamWriter writer = new StreamWriter("Character.csv");
    //using CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

    //List<Character> characters = new List<Character>();

    //foreach (var character in vNDBModel.Results)
    //{
    //    Character currentCharacter = new Character()
    //    {
    //        Name = character.Name,
    //        FranchiseId = 2,
    //        CharacterImage = character.Image.Url
    //    };
    //    characters.Add(currentCharacter);
    //}

    //csv.WriteRecords(characters);




    //VNDBBody vNDBBody = new VNDBBody()
    //{
    //    Filters = new ArrayList()
    //    {
    //        "vn", "=", new List<string>{"id", "=", "v2002"} //Steins Gate
    //    },
    //    Fields = "name, image.url, id",
    //    Sort = "id",
    //    Reverse = false,
    //    Results = null,
    //    Page = 1,
    //    User = null,
    //    Count = false,
    //    Compact_filters = false,
    //    Normalized_filters = true
    //};

    //var options = new JsonSerializerOptions
    //{
    //    PropertyNameCaseInsensitive = true,
    //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    //};

    //var vNDBBodyJson = JsonSerializer.Serialize(vNDBBody, options);
    //var requestContent = new StringContent(vNDBBodyJson, Encoding.UTF8, "application/json");



    //httpClient.DefaultRequestHeaders.Add("x-vndb-apikey", "3gqy-y4n36-wuogp-tp6g-6gf1x-y86wf-rn5y");

    //var response = await httpClient.PostAsync(url, requestContent);
    //response.EnsureSuccessStatusCode();

    //var content = await response.Content.ReadAsStringAsync();

    //Console.WriteLine(content);

    //var vNDBModel = JsonSerializer.Deserialize<VNDBModel>(content, options);



    //using StreamWriter writer = new StreamWriter("Character.csv");
    //using CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

    //List<Character> characters = new List<Character>();

    //foreach (var character in vNDBModel.Results)
    //{
    //    Character currentCharacter = new Character()
    //    {
    //        Name = character.Name,
    //        FranchiseId = 3,
    //        CharacterImage = character.Image.Url
    //    };
    //    characters.Add(currentCharacter);
    //}

    //csv.WriteRecords(characters);


    //VNDBBody vNDBBody = new VNDBBody()
    //{
    //    Filters = new ArrayList()
    //    {
    //        "vn", "=", new List<string>{"id", "=", "v2153" } //Umineko
    //    },
    //    Fields = "name, image.url, id",
    //    Sort = "id",
    //    Reverse = false,
    //    Results = 100,
    //    Page = 1,
    //    User = null,
    //    Count = false,
    //    Compact_filters = false,
    //    Normalized_filters = true
    //};

    //var options = new JsonSerializerOptions
    //{
    //    PropertyNameCaseInsensitive = true,
    //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    //};

    //var vNDBBodyJson = JsonSerializer.Serialize(vNDBBody, options);
    //var requestContent = new StringContent(vNDBBodyJson, Encoding.UTF8, "application/json");



    //httpClient.DefaultRequestHeaders.Add("x-vndb-apikey", "3gqy-y4n36-wuogp-tp6g-6gf1x-y86wf-rn5y");

    //var response = await httpClient.PostAsync(url, requestContent);
    //response.EnsureSuccessStatusCode();

    //var content = await response.Content.ReadAsStringAsync();

    //Console.WriteLine(content);

    //var vNDBModel = JsonSerializer.Deserialize<VNDBModel>(content, options);



    //using StreamWriter writer = new StreamWriter("Character.csv");
    //using CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

    //List<Character> characters = new List<Character>();

    //foreach (var character in vNDBModel.Results)
    //{
    //    if (character.Image is null) continue;
    //    Character currentCharacter = new Character()
    //    {
    //        Name = character.Name,
    //        FranchiseId = 4,
    //        CharacterImage = character.Image.Url
    //    };
    //    characters.Add(currentCharacter);
    //}

    //csv.WriteRecords(characters);

    httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6ImUwNTc4MjhmMDEyZTFkMGVlNzljZDUzOWFkYjYwYTI0ZTJhZDIyM2U5Mjg4MzYzODY4ZGZlNzgwZDllMDY0ZWJmM2M3OTljN2FhMWUwM2RmIn0.eyJhdWQiOiI4NDUwNmY4NmRkNDRmNWY0YzZhNDBkYTc4ZGI2ZDM4YSIsImp0aSI6ImUwNTc4MjhmMDEyZTFkMGVlNzljZDUzOWFkYjYwYTI0ZTJhZDIyM2U5Mjg4MzYzODY4ZGZlNzgwZDllMDY0ZWJmM2M3OTljN2FhMWUwM2RmIiwiaWF0IjoxNjk2MDEzODQ0LCJuYmYiOjE2OTYwMTM4NDQsImV4cCI6MTY5ODYwNTg0NCwic3ViIjoiNDY0NTU4MSIsInNjb3BlcyI6W119.FPFoH25t-qVJNNO0vCilbVN_XuLqpeJnRQ9xOI1KO5WWxTYSUNZCNaz2wpwJ4L5W-z1i6aVicwOPyGr0fQ1OJkh2ju0jTDD0KCp0Wm9ng0D2ZzT7wZ5w2asb2FbgdPyjVkSvOq3_lsIiaZIXAha4ABmUdEwPTjAmhDVBTRJyaPyZEUyrS0b2z6Jo_qEfI7ozFOqySgYnBWAQN8uGnSOAk26xYE92jrGPSRq6n23hHBcm3teZvsf8XCUta_px5AFPFagjjzqN7OTHxciTovQN3BkPu4527Tg0Kd-9TJp6w-rAWPnLRJcamRBDX5JamK4N8xaUvwumzGQcoCPMa1BV9w");
    var result = await httpClient.GetAsync("https://api.myanimelist.net/v2/anime/25519/characters?fields=id,first_name,last_name,main_picture,anime&limit=500");
    var response = await result.Content.ReadAsStringAsync();
    Console.WriteLine(response);

    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    MALModel mALModel = JsonSerializer.Deserialize<MALModel>(response, options);

    using StreamWriter writer = new StreamWriter("Character.csv");
    using CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

    List<Character> characters = new List<Character>();

    foreach (var character in mALModel.Data)
    {
        if (character.Node.Main_Picture is null ) continue;

        characters.Add(
            new Character()
            {
                Name = character.Node.First_Name + " " + character.Node.Last_Name,
                FranchiseId = 6,
                CharacterImage = character.Node.Main_Picture.Medium
            });
    }

    csv.WriteRecords(characters);


}