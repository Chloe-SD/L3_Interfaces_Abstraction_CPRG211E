using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace L3_Interfaces_Abstraction_CPRG211E
{
    public class Dog:IAnimal
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public Dog(string name, int height, string colour, int age)//base(name, colour, age)
        {
            this.Name = name;
            this.Height = height;
            this.Colour = colour;
            this.Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public void Cry()
        {
            Console.WriteLine("Woof!\n");
        }
        public override string ToString()
        {
            return $"{this.Name} is a {this.Colour} dog\n" +
                $"{this.Name} is {this.Age} years old and {this.Height} inches tall";
        }
    }
}
