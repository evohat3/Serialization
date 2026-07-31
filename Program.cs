
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Serialization
{
    
    public class Program
    {
        
        static void Main()
        {
            Person personOne = new Person {UserName = "JimmyNeutron", UserAge = 12};

            // *** Serialize to Binary ***
            // using (FileStream fs = new FileStream("Person.dat", FileMode.Create))
            // {
            //     BinaryWriter writer = new BinaryWriter(fs);
            //     writer.Write(personOne.UserName);
            //     writer.Write(personOne.UserAge);
            // }

            // Console.WriteLine("Binary Serialization Complete");

            // *** Serialize XML ***
            // XmlSerializer xml = new XmlSerializer(typeof(Person));
            // using (StreamWriter writer = new StreamWriter("person.xml"))
            // {
            //     xml.Serialize(writer,personOne);
            // }
            // Console.WriteLine("XML Serialization Completed");

            // *** Serialize Json ***

            string jsonString = JsonSerializer.Serialize(personOne);

            File.WriteAllText("person.json", jsonString);

            Console.WriteLine("JSON Serialization Completed");
        
        }


    }

}