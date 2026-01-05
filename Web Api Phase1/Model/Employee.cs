using System.Text.Json.Serialization;

namespace Web_Api_Phase1.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Gender { get; set; }
    }

    public class ApiResponseCode
    {
        public int responseCode { get; set; }
        public string data { get; set; }
    }

    public class EmployeeDetails
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }


}
