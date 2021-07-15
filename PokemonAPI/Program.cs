using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Linq;

namespace PokemonAPI
{
    class Program
    {       
        static void Main(string[] args)
        {
            var client = new HttpClient();
            string pokeURL = "https://pokeapi.co/api/v2/pokemon?limit=151&offset=0";
            var pokeResponse = client.GetStringAsync(pokeURL).Result;
			var pokeResult = JsonConvert.DeserializeObject<Root>(pokeResponse);

			//Console.WriteLine(pokeResponse);
			foreach (var item in pokeResult.results)
			{
				Console.WriteLine(item.name);
			}

			var squirtleClient = new HttpClient();
			string squirtleURL = "https://pokeapi.co/api/v2/pokemon/squirtle";
			var squirtleResponse = squirtleClient.GetStringAsync(squirtleURL).Result;
			var squirtleResult = JsonConvert.DeserializeObject<SquirtleRoot>(squirtleResponse);


			Console.WriteLine(squirtleResult);




			//TODO create a new instance of HttpClient called client.
			//TODO use your client instance to get a response from the poke URL.
			//TODO go to https://json2csharp.com and convert your json reponse to classes. Create a new class file in visual studio and paste the classes you created on the website.
			//TODO create a variable that = JsonConvert.DeserializeObject<YourRootClassGoesHere>(yourStringResponseGoesHere);
			//TODO print the results from your

			//TODO use the pokemon url above and change it to try and call your favorite pokemon.
			//TODO Use select token to try and grab a couple values from your pokemon and display them.
		}
    }
}
