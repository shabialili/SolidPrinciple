using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface IClothes
    {
        int id { get; set; }
        string gender { get; set; }   
        string price { get; set; } 
        string color { get; set; }
        char size { get; set; }
        string brand { get; set; }

    }
    public class Shirt : IClothes
    {
        public int id { get; set; }
        public string gender { get; set; }
        public string price { get; set; }
        public string color { get; set; }
        public char size { get; set; }
        public string brand { get; set; }
        public string fabric { get; set; }
    }
    public class Trousers: IClothes
    {
        public int id { get; set; }
        public string gender { get; set; }
        public string price { get; set; }
        public string color { get; set; }
        public char size { get; set; }
        public string brand { get; set; }
        public string length { get; set; }
    }
    public class Shoe : IClothes
    {
        public int id { get; set; }
        public string gender { get; set; }
        public string price { get; set; }
        public string color { get; set; }
        public char size { get; set; }
        public string brand { get; set; }
        public string leather { get; set; }
    }

}

