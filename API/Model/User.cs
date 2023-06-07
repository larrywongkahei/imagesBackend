using System;
using System.Text.Json.Serialization;

namespace API.Model
{
	        "First Name": "John",
        "Last Name": "Doe",
        "Middle Name": "Robert",
        "Salary": 50000,
        "Career": "Software Engineer",
        "Birthdate": "1990-05-15",
        "Email": "johndoe@example.com",
        "Phone Number": "+1 (123) 456-7890",
        "Address": "123 Main St, Anytown, USA"
	public class User
	{
        [JsonPropertyName("First Name")]
        public string FirstName { get; set; }

        [JsonPropertyName("Last Name")]
        public string LastName { get; set; }

        [JsonPropertyName("Middle Name")]
        public string MiddleName { get; set; }

        [JsonPropertyName("Salary")]
        public double Salary { get; set; }

        [JsonPropertyName("Career")]
        public string Career { get; set; }

        [JsonPropertyName("Birthdate")]
        public string Birthdate { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Phone Number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("Address")]
        public string Address { get; set; }

        public User()
		{
		}
	}
}

