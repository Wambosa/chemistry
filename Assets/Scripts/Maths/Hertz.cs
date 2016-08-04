using System;

namespace Chemistry.Maths {

    [Serializable]
    public class Hertz : CustomUnit {

        protected readonly string unitOfMeasurement = "Hz";

        public static explicit operator Hertz(long m) {

            var simplified = SI.Simplify(m);

            return new Hertz(){
                prefix = simplified.Key,
                value = simplified.Value
            };
        }
    }
}