using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Web_Api_Phase1.Model;

namespace Web_Api_Phase1.Services
{
    public class EmployeeService
    {
        private readonly string file = "Data/demoData.json";
       public string GetUserData()
        {
            string firstName = "Baskar";
            string lastName = "Raj";
            string fullName = firstName + ' ' + lastName;
            return fullName;
        }


        public List<EmployeeDetails> getUserDataJson()
        {
            var json = File.ReadAllText(file);
            Console.WriteLine(json);
            var userData = JsonSerializer.Deserialize<List<EmployeeDetails>>(json);
            return userData;
        }
    }


}
