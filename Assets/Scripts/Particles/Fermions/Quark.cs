using System;

namespace Chemistry.Particles.Fermions {

	[Serializable]
    public class Quark: Fermion {

		public enum TYPE {
			UP_TYPE = 0,
			DOWN_TYPE = 1
		}

		//todo: 4th generation
		public enum FLAVOR {
			UP,
			DOWN,
			CHARM,
			STRANGE,
			TOP,
			BOTTOM
		};

    }
}