using Vectrosity;
using UnityEngine;
using System.Collections.Generic;

namespace Chemistry.GameObjects {

	//todo: make abstract? might not be able to because this is also a monobehavior
	public class ParticleView : MonoBehaviour {

		protected readonly Vector3[] defaultPoints = new[]{
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero,
			Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero, Vector3.zero
		};

		protected VectorLine center;//rename to something else.

		protected List<VectorLine> waves = new List<VectorLine>();

		public void Awake(){
			center = new VectorLine(gameObject.name+"_center", new List<Vector3>(){transform.position}, 1f, LineType.Points);
			center.color = Color.red;
			center.Draw3DAuto();
		}

		protected virtual float angle { get {return 0f;}}
	}
}