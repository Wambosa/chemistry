using System;
using System.Collections.Generic;

namespace Chemistry.Maths {
    public static class SI {

	    public static readonly int lightSpeed = 299792458;

        public static readonly Dictionary<char, long> MetricPrefix = new Dictionary<char, long>(){
            {'E', 1000000000000000000},
            {'P', 1000000000000000},
            {'T', 1000000000000},
            {'G', 1000000000},
            {'M', 1000000},
            {'K', 1000},
        };


		public static KeyValuePair<char, short> Simplify(long number){

			foreach (var size in SI.MetricPrefix) {
				var simple = (float)number / size.Value;

				if(Math.Floor(simple) > 0)
					return new KeyValuePair<char, short>(size.Key, (short)simple);
			}

			return new KeyValuePair<char, short>(' ', (short)number);
		}

    }
}