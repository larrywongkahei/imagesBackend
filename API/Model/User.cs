using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace API.Model
{
	public class User
	{
        [JsonPropertyName("First Name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("Last Name")]
        public string? LastName { get; set; }

        [JsonPropertyName("Middle Name")]
        public string? MiddleName { get; set; }

        [JsonPropertyName("Salary")]
        public double? Salary { get; set; }

        [JsonPropertyName("Career")]
        public string? Career { get; set; }

        [JsonPropertyName("Birthdate")]
        public string? Birthdate { get; set; }

        [JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonPropertyName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("Address")]
        public string? Address { get; set; }

        public string getAll()
        {
            return  File.ReadAllText("./user.json");
        }

        public string? getNumbersOfUsers(int number)
        {
            if (number > 30)
            {
                return "Number could not be more than 30";
            }
            else
            {
                string jsonData = File.ReadAllText("./User.json");
                var users = JsonSerializer.Deserialize<User[]>(jsonData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return JsonSerializer.Serialize(users?.Take(number), new JsonSerializerOptions { WriteIndented = true });
            }
        }

    }
}

