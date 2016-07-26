using System;

namespace Chemistry.Particles.Fermions {

	[Serializable]
	public class Fermion : Particle {

		public Flavor flavor;

		public string Flavor(){

			if(this is Quark)
				return ((Quark.FLAVOR)flavor.value).ToString();
			else
				return ((Lepton.FLAVOR)flavor.value).ToString();
		}
	}
}