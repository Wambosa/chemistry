using UnityEngine;
using Chemistry.Maths;

namespace Chemistry.Particles {

	public abstract class Particle {

		public ElectronVolt mass;

		[Range(-1f, 1f)]
		public float charge;

		[Range(0f, 1f)]
		public float spin;

		public ElectronVolt energy;

		public Hertz frequency;

		public Wavelength wavelength;

		public Vector2 velocity;

		public Vector2 acceleration;

		public Vector2 momentum;
	}
}