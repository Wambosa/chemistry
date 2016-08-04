using UnityEngine;

namespace GameObjects {
	public class TriggerTest: MonoBehaviour {

		public void OnTriggerEnter2D(Collider2D collider){
			Debug.LogWarning(collider.gameObject.name + " hit!");
		}

		public void OnTriggerStay2D(Collider2D collider){
			Debug.LogWarning(collider.gameObject.name + " stay!");
		}

	}
}