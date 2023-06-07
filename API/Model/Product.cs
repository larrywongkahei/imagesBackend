using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace API.Model
{
	public class Product
	{
		[JsonPropertyName("Name")]
		public string? Name { get; set; }

        [JsonPropertyName("Brand")]
        public string? Brand { get; set; }

        [JsonPropertyName("Price")]
        public double? Price { get; set; }

        [JsonPropertyName("Description")]
        public string? Description { get; set; }

        [JsonPropertyName("Category")]
        public string? Category { get; set; }

        [JsonPropertyName("Rating")]
        public double? Rating { get; set; }

        [JsonPropertyName("Image")]
        public string? Image { get; set; }

		public string getAll()
        {
           return File.ReadAllText("./product.json");
        }

        public string? getNumbersOfProduct(int number)
        {
            if (number > 15)
            {
                return "Number could not be more than 15";
            }
            else
            {
                string jsonData = File.ReadAllText("./product.json");
                var products = JsonSerializer.Deserialize<Product[]>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
                return JsonSerializer.Serialize(products?.Take(number), new JsonSerializerOptions { WriteIndented = true });
            }
        }
	}
}

