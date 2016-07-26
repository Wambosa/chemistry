using Vectrosity;
using UnityEngine;

namespace Chemistry.Terminals {
    public sealed class SubatomicTerminal : Terminal {

        public new void Start(){
            VectorLine.SetLine(Color.red, new Vector2(0, 0), new Vector2(Screen.width-1, Screen.height-1));
        }
    }
}