using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;


namespace Day5_Practical_Task
{
    public class JsonReadWrite
    {
     
        public override string ToString()
        {
            if(File.Exists("person.json"))
            {
                string jsonString = File.ReadAllText("person.json");
                person person1 = JsonConvert.DeserializeObject<person>(jsonString);
                return $"Person Name: {person1.Name} , Person Age : {person1.Age}, Person City : {person1.City.CityName}, Person City Population : {person1.City.Population}";
            }

            else
            {
                Console.WriteLine("File Does Not Exist");
                return "";
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            var Name = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter City Name");
            var CityName = Console.ReadLine();

            Console.WriteLine("Enter Population");
            int population = Convert.ToInt32(Console.ReadLine());

            var person = new person
            {
                Name = Name,
                Age = age,
                City = new City { CityName = CityName, Population = population }

            };

            string fileName = "person.json";
            string jsoncovert = JsonConvert.SerializeObject(person);
            File.WriteAllText(fileName, jsoncovert);

            JsonReadWrite jsonReadWrite = new JsonReadWrite();
            Console.WriteLine(jsonReadWrite.ToString());

            var serializer = new XmlSerializer(typeof(person));
            using (var writer = new StreamWriter("person.xml"))
            { serializer.Serialize(writer, person); }
        }
    }

    public class City
    {
        public string CityName { get; set; }
        public int Population { get; set; }
    }
    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public City City { get; set; }
    }

}
