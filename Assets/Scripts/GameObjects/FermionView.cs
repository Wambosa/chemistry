using UnityEngine;
using Chemistry.Particles.Fermions;

namespace Chemistry.GameObjects {

	public sealed class FermionView : ParticleView {

		public Fermion particle;

		public void Start(){

			var test = new Lepton();

			test.flavor = Lepton.FLAVOR.MUON_NEUTRINO;

			Debug.Log(test.Flavor());
		}

	}
}