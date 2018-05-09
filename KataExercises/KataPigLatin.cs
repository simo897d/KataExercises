using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises {
    public class KataPigLatin {
        public static string PigIt(string str) {
            string[] result = str.Split(' ');
            List<string> a = new List<string>();
            foreach (var item in result) {
            char first = item[0];
            string rest = item.Substring(1, item.Length - 1);
                string returnStr = rest + first + "ay";
                a.Add(returnStr);
            }

            return String.Join(" ", a);
        }
    }
}
