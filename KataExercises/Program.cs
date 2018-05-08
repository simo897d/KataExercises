using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(string.Join(",\n", Kata.TowerBuilder(15)));
            Console.ReadKey();
        }
    }
}
