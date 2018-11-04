using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Line lineOne = new Line
            {
                NameLine = "Line One",
                Size = 20,
                Color = ConsoleColor.Cyan
            };
            Line lineTwo= new Line
            {
                NameLine = "Line Two",
                Size = 10,
                Color = ConsoleColor.Red
            };

            Person personOne = new Person
            {
                Name = "KakYgodno",
                Age = 24,
                Height = 20,
                Weight = 20
            };
            Person personTwo = new Person
            {
                Name = "KakYgodnoTwo",
                Age = 25,
                Height = 25,
                Weight = 25
            };

            Dagger daggerOne = new Dagger
            {
                Price = 2250,
                Range = 850,
                Size = 200
            };
            Dagger daggerTwo = new Dagger
            {
                Price = 2251,
                Range = 950,
                Size = 150
            };
        }
    }
}
