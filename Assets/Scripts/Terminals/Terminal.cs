using Vectrosity;
using UnityEngine;

namespace Chemistry.Terminals {

    public abstract class Terminal: MonoBehaviour {

	    //pressure, temperature,

	    // volume? more accurate per group of particles instead of total volume.. hmmm

        public void Start(){
            VectorLine.SetLine(Color.yellow, new Vector2(0, 0), new Vector2(Screen.width-1, Screen.height-1));
        }
    }
}