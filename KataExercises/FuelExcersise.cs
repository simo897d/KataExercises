using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExercises {
    public class FuelExcersise {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) {

            if (mpg * fuelLeft == distanceToPump) {
                return true;
            }
            return false;
        }
    
}
}
