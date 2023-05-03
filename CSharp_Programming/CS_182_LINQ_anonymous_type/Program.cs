using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ---------- ---------- ---------- ---------- ----------
- Proj: CS_182_LINQ_anonymous_type
- Desc: 익명 형식
---------- ---------- ---------- ---------- ---------- */
namespace CS_182_LINQ_anonymous_type {
    class Program {
        static void Main(string[] args) {
            var student1 = new { Name = "철수", Age = 10, Grade = 3 };
            var student2 = new { Name = "영희", Age = 11, Grade = 4 };
            var student3 = new { Name = "민수", Age =  9, Grade = 2 };

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);
            Console.WriteLine(student1.Grade);

            Console.WriteLine();

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.WriteLine();

            var studentArr1 = new[] { student1, student2, student3 };

            foreach (var item in studentArr1) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var studentArr2 = new[] {
                new { Name = "철수", Age = 10, Grade = 3 },
                new { Name = "영희", Age = 11, Grade = 4 },
                new { Name = "민수", Age =  9, Grade = 2 }
            };

            foreach (var item in studentArr2) {
                Console.WriteLine(item);
            }
        }
    }
}
