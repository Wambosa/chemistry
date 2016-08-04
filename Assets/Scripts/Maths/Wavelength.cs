using System;

namespace Chemistry.Maths {

    [Serializable]
    public class Wavelength : CustomUnit {

        protected readonly string unitOfMeasurement = "nm";

        public static explicit operator Wavelength(long m) {
            return new Wavelength(){
                prefix = ' ',
                value = (short)m
            };
        }
    }
}