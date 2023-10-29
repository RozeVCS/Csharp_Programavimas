using System;

namespace Uzduotis38
{

    // // Sukurkite bazinę klasę Gyvunas su protected kintamaisiais
    // ir paveldinčia klasę Gyvate. 
    // Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės  kintamuosius į ekraną.
    // Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
    // Išveskite paveldinčios klasės kintamuosius į ekraną.

    class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Snake : Animal
    {
        private string species;

        public Snake(string name, int age, string species) : base(name, age)
        {
            this.species = species;
        }

        public void DisplaySnakeInfo()
        {
            Console.WriteLine("Snake Information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Species: " + species);
        }
    }

    class Program
    {
        static void Main()
        {
            Snake snake = new Snake("Slytherin", 5, "Python");
            snake.DisplaySnakeInfo();
        }
    }
}

