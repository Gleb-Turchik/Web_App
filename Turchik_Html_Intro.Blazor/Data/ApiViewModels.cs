using System.Text.Json.Serialization;

namespace Turchik_Html_Intro.Blazor.Data
{
    public class ListViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class DetailsViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}