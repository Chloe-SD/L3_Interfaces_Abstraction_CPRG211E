using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace L3_Interfaces_Abstraction_CPRG211E
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Height {  get; set; }
        string Colour { get; set; }
        int Age { get; set; }
        void Eat();
        void Cry();
        public string ToString();
        //public Animal(string name, string colour, int age)
        //{
        //    this.Name = name;
        //    this.Colour = colour;
        //    this.Age = age;
        //}
        //public void ChangeName(string name)
        //{
        //    this.Name = name;
        //}
        //public override string ToString()
        //{
        //    return $"Error: Animal type not specified";
        //}
    }
}
