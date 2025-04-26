using System.Text.Json;

namespace Binary_Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Ulvi", Age = 24 };

            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", jsonString);

            string readJson = File.ReadAllText("person.json");

            Person? deserialize = JsonSerializer.Deserialize<Person>(readJson);
            Console.WriteLine($"Name: {deserialize?.Name} Age: {deserialize?.Age}");
        }
    }
}