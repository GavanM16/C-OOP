using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace EXoop
{

    
    internal class Program
    {

        public interface IAnimal
        {
            string name { get; set; }
            double weight { get; set; }

            double height { get; set; }
            void MakeSound();

            

            


        }

        public abstract class Animal : IAnimal
        {
            public string name { get; set; }
            public double weight { get; set; }

            public double height { get; set; }
            public abstract void MakeSound();

            

        }

        public interface IHuman:IAnimal
        {
            string gender { get; set; }
        }

        public abstract class Human:IHuman
        {
            public string name { get; set; }
            public double weight { get; set; }
                
            public double height { get; set; }

            public string gender { get; set; }
            public abstract void MakeSound();

            

        }

        public class Man:Human
        {
            public override void MakeSound()
            {
                Console.WriteLine("I'm a boss");
            }

            

        }

        public class Woman:Human
        {
            public override void MakeSound()
            {
                Console.WriteLine("I'm gorgeous");
            }

           
        }

        public abstract class Pet:Animal
        {
            public abstract void Eat();
        }

        public class Cat:Pet
        {
            public override void MakeSound()
            {
                Console.WriteLine("meaw");
            }

           

            public  override void Eat()
            {
                Console.WriteLine("I eat Jerry");
            }

            
        }

        public class Dog:Pet
        {
            public override void MakeSound()
            {
                Console.WriteLine("Ham");
            }

            

            public override void Eat()
            {
                Console.WriteLine("I eat Tom");
            }
        }

        



        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
            animal.name = "Rex";
            animal.weight = 1.0;
            animal.height = 1.0;
            animal.MakeSound();
            
            

            Console.WriteLine("Our dog" + " "+ animal.name+ " " + "has " + " " +animal.weight + " " + animal.weight);


            Human human = new Man();
            human.name = "Dan";
            human.weight = 1.0;
            human.height = 1.0;
            human.MakeSound();
            human.gender = "male";
            

          

            Pet pet = new Cat();
            pet.Eat();
            
        }
    }
}
