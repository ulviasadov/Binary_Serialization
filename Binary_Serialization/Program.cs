namespace Binary_Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Ulvi", Age = 24 };

            using (var stream = new FileStream("person.bin", FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(person.Name);
                writer.Write(person.Age);
            }

            using (var stream = new FileStream("person.bin", FileMode.Open))
            using (var reader = new BinaryReader(stream))
            {
                string name = reader.ReadString();
                int age = reader.ReadInt32();

                Console.WriteLine($"Name: {name} Age: {age}");
            }
        }
    }
}