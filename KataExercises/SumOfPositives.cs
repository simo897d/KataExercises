using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises {
    class SumOfPositives {
        public static int PositiveSum(int[] arr) {
            return arr.Sum(x=> x >0 ? x : x = 0);
        }
    }
}
