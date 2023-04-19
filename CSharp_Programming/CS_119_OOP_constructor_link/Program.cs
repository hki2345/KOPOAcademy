using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_119_OOP_constructor_link
- Desc: 생성자 연계
---------- ---------- ---------- ---------- ---------- */
namespace CS_119_OOP_constructor_link {
    class Mammal {
        public string name;
        public int age;

        public Mammal(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public Mammal(string name) : this(name, 1) { }
        public Mammal(int age) : this("동물", age) { }
        public Mammal() : this("동물", 1) { }
    }

    class Dog : Mammal {
        public string breed;

        public Dog(string name, int age, string breed) : base(name, age) {
            this.breed = breed;
        }
    }

    class Program {
        static void Main(string[] args) {
            Mammal a = new Mammal("초코", 10);
            Mammal b = new Mammal("보리");
            Mammal c = new Mammal(11);
            Mammal d = new Mammal();

            Console.WriteLine("a: {0}, {1}", a.name, a.age);
            Console.WriteLine("b: {0}, {1}", b.name, b.age);
            Console.WriteLine("c: {0}, {1}", c.name, c.age);
            Console.WriteLine("d: {0}, {1}", d.name, d.age);

            Dog e = new Dog("모찌", 9, "푸들");

            Console.WriteLine("e: {0}, {1}, {2}", e.name, e.age, e.breed);
        }
    }
}
