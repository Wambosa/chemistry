using System;

namespace Chemistry.Particles.Fermions {

	[Serializable]
	public struct Flavor {

		public int value;

		public static implicit operator Flavor(Quark.FLAVOR flavor) {
			return new Flavor(){
				value = (int)flavor
			};
		}

		public static implicit operator Flavor(Lepton.FLAVOR flavor) {
			return new Flavor(){
				value = (int)flavor
			};
		}
	}
}