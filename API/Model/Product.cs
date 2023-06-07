using System;
using System.Text.Json.Serialization;

namespace API.Model
{
	public class Product
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }

        [JsonPropertyName("Brand")]
        public string Brand { get; set; }

        [JsonPropertyName("Price")]
        public double Price { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("Rating")]
        public double Rating { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

		public Product()
		{
		}
	}
}

