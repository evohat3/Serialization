
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Unicode;

namespace Serialization
{
    
    public class Program
    {
        
        static void Main()
        {

            // $$$$$$$$$$$$$$$$$ Objects to Serialize $$$$$$$$$$$$$$$$$
            // ### individual 
            Person personOne = new Person {UserName = "JimmyNeutron", UserAge = 12};

            // ### group
            var people = new List<Person>
            {
              new Person {UserName = "Billy Madison", UserAge = 28},
              new Person {UserName = "Jim Carey", UserAge = 35}  
            };

            // $$$$$$$$$$$$$$$$$ Objects to Serialize $$$$$$$$$$$$$$$$$

            //*** Serialize to Binary ***
            using (FileStream fs = new FileStream("Person.dat", FileMode.Create))
            {
                BinaryWriter writer = new BinaryWriter(fs);
                writer.Write(personOne.UserName);
                writer.Write(personOne.UserAge);
            }

            Console.WriteLine("Binary Serialization Complete");

            // *** Serialize XML ***
            XmlSerializer xml = new XmlSerializer(typeof(Person));
            using (StreamWriter writer = new StreamWriter("person.xml"))
            {
                xml.Serialize(writer,personOne);
            }
            Console.WriteLine("XML Serialization Completed");

            // *** Serialize Json ***
                  // ### Individual 
            string jsonString = JsonSerializer.Serialize(personOne);
            File.WriteAllText("person.json", jsonString);
                   // ### Group
                                   // $$$ Json Serializer Options
        //    string jsonString = JsonSerializer.Serialize(people, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText("People.json",jsonString);
            Console.WriteLine($"Serilization Complete\n{jsonString}");
          

            //StreamReader reader = new StreamReader("./People.json");
            //Console.WriteLine($"Deserialized JSON:\n{reader.ReadToEnd()}");

        }


    }

}