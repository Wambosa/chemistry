using UnityEngine;
using Chemistry.Maths;

namespace Chemistry.Particles {

	public abstract class Particle {

		public ElectronVolt mass;

		[Range(-2f, 2f)]
		public float charge;

		[Range(-5f, 5f)]
		public float spin;

		public Vector2 velocity;
	}
}