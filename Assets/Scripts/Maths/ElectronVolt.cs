using System;

namespace Chemistry.Maths {

    [Serializable]
    public struct ElectronVolt : IComparable {

        public const string unitOfMeasurement = "eV";

        public char prefix;
        public short value;

        public static explicit operator ElectronVolt(long m) {

            var simplified = SI.Simplify(m);

            return new ElectronVolt(){
                prefix = simplified.Key,
                value = simplified.Value
            };
        }

        public override string ToString() {
            return string.Format("{0} {1}{2}",
                    value,
					prefix,
					unitOfMeasurement
            );
        }

        public int CompareTo(object obj){
            return CompareTo((ElectronVolt)obj);
        }

        public int CompareTo(ElectronVolt obj) {
            return value*SI.MetricPrefix[prefix] > obj.value*SI.MetricPrefix[obj.prefix] ? 1 : 0;
        }
    }
}