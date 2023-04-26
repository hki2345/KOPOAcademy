using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_158_Generic_where
- Desc: 제네릭 형식 제약 조건 걸기
---------- ---------- ---------- ---------- ---------- */
namespace CS_158_Generic_where {
    class ValueBox<T> where T : struct {
        public T value;
    }

    class ReferenceBox<T> where T : class {
        public T reference;
    }

    class Animal { }

    class Dog : Animal { }

    class Cage<T> where T : Animal {
        public T animal;
    }

    interface ICar { }

    class Sedan : ICar { }

    class Garage<T> where T : ICar {
        public T car;
    }

    class Program {
        static void Main(string[] args) {
            ValueBox<int> valueBox = new ValueBox<int>();
            ReferenceBox<int[]> referenceBox = new ReferenceBox<int[]>();
            Cage<Dog> cage = new Cage<Dog>();
            Garage<Sedan> garage = new Garage<Sedan>();

            valueBox.value = 100;
            referenceBox.reference = new int[] { 100, 200, 300 };
            cage.animal = new Dog();
            garage.car = new Sedan();

            Console.WriteLine("value type: {0}", valueBox.value.GetType());
            Console.WriteLine("reference type: {0}", referenceBox.reference.GetType());
            Console.WriteLine("animal type: {0}", cage.animal.GetType());
            Console.WriteLine("car type: {0}", garage.car.GetType());
        }
    }
}
