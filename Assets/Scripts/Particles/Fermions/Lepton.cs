using System;

namespace Chemistry.Particles.Fermions {

	[Serializable]
    public class Lepton: Fermion {

		public enum TYPE {
			ELECTRON = 0,
			NEUTRINO = 1
		}

		public enum FLAVOR {
			ELECTRON,
			NEUTRINO,
			MUON,
			MUON_NEUTRINO,
			TAU,
			TAU_NEUTRINO
		};

    }
}