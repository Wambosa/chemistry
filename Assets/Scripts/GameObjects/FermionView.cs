using UnityEngine;
using Vectrosity;
using System.Collections.Generic;
using Chemistry.Particles.Fermions;

namespace Chemistry.GameObjects {

	public sealed class FermionView : ParticleView {

		public Fermion particle;

		public void Start(){
			var test = new Lepton();
			test.flavor = Lepton.FLAVOR.MUON_NEUTRINO;
			Debug.Log(test.Flavor());

			center.lineWidth = particle.mass.value * .001f;

			//we want to compute the maximum number of waves and spawn them all at the center. then move them out a certain distance depending on mass, once lmiit is reached, reset movement to center

			for(var i=0;i<10;++i){
				var newWaver = new VectorLine(
						string.Format("{0}_ripple_{1}", gameObject.name, waves.Count),
						new List<Vector3>(defaultPoints),
						particle.mass.value * .001f, //need to account for M, G and T
						LineType.Continuous
				);

				newWaver.collider = true;
				newWaver.trigger = false;

				//newWaver.rectTransform.gameObject

				newWaver.MakeArc(
						transform.position,
						1f,
						1f,
						angle - Mathf.Clamp(180 - particle.energy.value, 1, 180),
						angle + Mathf.Clamp(180 - particle.energy.value, 0, 180)
				);

				newWaver.Draw3DAuto();

				waves.Add(newWaver);
			}


		}

		public int sequence = 1;

		public void LateUpdate() {

			for(var i=0; i < sequence; ++i) {

				waves[i].rectTransform.gameObject.transform.localScale = new Vector3(
						waves[i].rectTransform.localScale.x+ Time.deltaTime * .5f,
						waves[i].rectTransform.localScale.y+ Time.deltaTime * .5f,
						1f
				);

				waves[i].rectTransform.position =  new Vector3(waves[i].rectTransform.gameObject.transform.localScale.x * 10 * -1, waves[i].rectTransform.gameObject.transform.localScale.x * 10 * -1, 1f);


				if(waves[i].rectTransform.localScale.x-1 > particle.wavelength.value * .1f){
					sequence = sequence == waves.Count ? 1 : sequence;
				}

				if(waves[i].rectTransform.localScale.x-1 > particle.mass.value * 0.001f){
					waves[i].rectTransform.localScale.Set(1f,1f,1f);
				}
			}
		}

		protected override float angle { get {
			return (180f - Mathf.Atan2(particle.velocity.x, particle.velocity.y) * 180f / Mathf.PI);
		}}
	}
}