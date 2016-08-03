using Vectrosity;
using UnityEngine;
using System.Collections.Generic;

namespace Chemistry.GameObjects {

	//todo: make abstract? might not be able to because this is also a monobehavior
	public class ParticleView : MonoBehaviour {

		private List<Vector3> defaultPoints = new List<Vector3>(){
			Vector3.zero, Vector3.right, Vector3.up, Vector3.down};

		protected VectorLine view;

		public void Awake(){
			view = new VectorLine(gameObject.name+"_view", defaultPoints, 2f, LineType.Continuous);
			view.Draw3DAuto();
		}

		protected virtual float angle { get {return 0f;}}

		// default some draw stuff
	}
}