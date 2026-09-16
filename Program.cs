using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumerDisneyIdApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://api.disneyapi.dev/character/423";

            using (HttpClient disney = new HttpClient())
            {
                try
                {
                    string response = await disney.GetStringAsync(url);

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    DisneyResponse disneydata = JsonSerializer.Deserialize<DisneyResponse>(response, options);

                    Console.WriteLine("Nome:");
                    Console.WriteLine(disneydata.Data.Name);

                    Console.WriteLine("Imagem:");
                    Console.WriteLine(disneydata.Data.ImageUrl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao consultar a API: {ex.Message}");
                }
            }
        }
    }

    public class DisneyResponse
    {
        [JsonPropertyName("data")]
        public CharacterData Data { get; set; }
    }

    public class CharacterData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
    }
}