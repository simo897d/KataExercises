//using System;
//using System.Linq;
//public class Kata {
//    public static string[] TowerBuilder(int nFloors) {
//        string[] builder = new string[nFloors];
//        string use = null;
//        int counter = 0;
//        double minusFloors = nFloors + nFloors - 1;
//        for (int i = nFloors; i > 0; i--) {
//            string a = new string(' ', counter);
//            string b = new string('*', (int)minusFloors);
//            counter++;
            
//            minusFloors = minusFloors-2;
//            use = a + b + a;
//            builder[i-1] = use;
//        }
//        return builder;
//    }
//}