using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel Mariya = new Hotel("Mariya", 2000, 3);
            Hotel Bykovuna = new Hotel("Bykvuna", 5000, 5);
            Hotel Kavkaz = new Hotel("Kavkaz", 4000, 4);
            Hotel Laxivka = new Hotel("Laxivka", 500, 1);
            Hotel[] arr = new Hotel[] { Mariya, Bykovuna, Kavkaz, Laxivka };
            //Serialization
            XmlSerializer Serializer = new XmlSerializer(typeof(Hotel[]));
            using (FileStream fs = new FileStream("Hotel.xml", FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, arr);
                Console.WriteLine("Ми сериализнули 4 готели");
            }
            //Deserialization
            using (FileStream fs = new FileStream("Hotel.xml", FileMode.OpenOrCreate))
            {
                Hotel[] array = (Hotel[])Serializer.Deserialize(fs);
                foreach (var hotelchik in array)
                {
                    Console.WriteLine(hotelchik.Name + hotelchik.Price + hotelchik.Rating);
                }
            }
        }
    }
}
