using Vectrosity;
using UnityEngine;
using Chemistry.Particles.Fermions;

namespace Chemistry.GameObjects {

	public sealed class FermionView : ParticleView {

		public Fermion particle;

		public void Start(){

			var test = new Lepton();

			test.flavor = Lepton.FLAVOR.MUON_NEUTRINO;

			Debug.Log(test.Flavor());

			view.MakeArc(
				transform.position,
				transform.localScale.x,
				transform.localScale.y,
				0f,
				0f
			);
		}

		public void LateUpdate(){

			Debug.Log(angle);

			view.MakeArc(
				transform.position,
				transform.localScale.x,
				transform.localScale.y,
				angle - 45, //the width of the angle is dependant on momentum. the more momentum, the tighter the wave
				angle + 45
			);
		}

		protected override float angle { get {
			return (180f - Mathf.Atan2(particle.velocity.x, particle.velocity.y) * 180f / Mathf.PI);
		}}
	}
}