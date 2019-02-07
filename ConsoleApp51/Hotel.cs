using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    [Serializable]
    public class Hotel
    {
        public string Name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public int Rating
        {
            get;
            set;
        }
        public Hotel(string Name, int Price, int Rating)
        {
            this.Name = Name;
            this.Price = Price;
            this.Rating = Rating;
        }
        public Hotel()
        {
        }
    }

}

