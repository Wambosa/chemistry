using System;

namespace Chemistry.Maths {

    [Serializable]
    public class ElectronVolt: CustomUnit, IComparable {

        protected readonly string unitOfMeasurement = "eV";

        public static explicit operator ElectronVolt(long m) {

            var simplified = SI.Simplify(m);

            return new ElectronVolt(){
                prefix = simplified.Key,
                value = simplified.Value
            };
        }

        public int CompareTo(object obj){
            return CompareTo((ElectronVolt)obj);
        }

        public int CompareTo(ElectronVolt obj) {
            return value*SI.MetricPrefix[prefix] > obj.value*SI.MetricPrefix[obj.prefix] ? 1 : 0;
        }
    }
}