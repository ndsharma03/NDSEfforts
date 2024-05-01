using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPattern
{
    // https://code-maze.com/adapter/
    // Let’s imagine that we have functionality in which we convert the list of car manufacturers into JSON format and write it to the screen.
    // But instead of a list, we have been provided with an API that provides us with all the manufacturers in the XML format.

    public class Manufacturer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
    }
    /// <summary>
    /// Generates list of Manufacturers.
    /// </summary>
    public static class ManufacturerDataProvider
    {
        public static List<Manufacturer> GetData() =>
           new List<Manufacturer>
           {
            new Manufacturer { City = "Italy", Name = "Alfa Romeo", Year = 2016 },
            new Manufacturer { City = "UK", Name = "Aston Martin", Year = 2018 },
            new Manufacturer { City = "USA", Name = "Dodge", Year = 2017 },
            new Manufacturer { City = "Japan", Name = "Subaru", Year = 2016 },
            new Manufacturer { City = "Germany", Name = "BMW", Year = 2015 }
           };
    }

    /// <summary>
    /// Converts list of Manufacturer to xml.
    /// </summary>
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = ManufacturerDataProvider.GetData()
                .Select(m => new XElement("Manufacturer",
                                    new XAttribute("City", m.City),
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
    /// <summary>
    /// Converts list of Manufacturers to JSON.
    /// </summary>
    public class JsonConverter
    {
        private IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
          
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }

    // Adapter to convert xml to JSON 
    public interface IXmlToJson
    {
        void ConvertXmlToJson();
    }
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXML()
                    .Element("Manufacturers")
                    .Elements("Manufacturer")
                    .Select(m => new Manufacturer
                    {
                        City = m.Attribute("City").Value,
                        Name = m.Attribute("Name").Value,
                        Year = Convert.ToInt32(m.Attribute("Year").Value)
                    });

            new JsonConverter(manufacturers).ConvertToJson();
            

        }
    }

   
    class AdapterPattern2ExampleTest
    {
        //static void Main(string[] args)
        //{
        //    var xmlConverter = new XmlConverter();
        //    var adapter = new XmlToJsonAdapter(xmlConverter);
        //    adapter.ConvertXmlToJson();
        //    Console.Read();
        //    Console.WriteLine("Good Bye!!");
        //}
    }
}
