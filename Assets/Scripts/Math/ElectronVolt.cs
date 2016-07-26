using System;

namespace Chemistry.Math {

    [Serializable]
    public struct ElectronVolt : IComparable {

        public const string symbol = "eV";

        public double value;

        public static implicit operator ElectronVolt(double m) {
            return new ElectronVolt(){
                value = m
            };
        }

        public override string ToString(){
            return string.Format("{0}{1}",
                value,
                symbol
            );
        }

        public int CompareTo(object obj){
            return CompareTo((ElectronVolt)obj);
        }

        public int CompareTo(ElectronVolt obj) {
            return value > obj.value ? 1 : 0;
        }
    }
}