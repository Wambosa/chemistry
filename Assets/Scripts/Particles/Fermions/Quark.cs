namespace Chemistry.Particles.Fermions {

    public enum QUARK_STATE {
        NONE = 0,
        UP,
        DOWN,
        STRANGE,
        CHARM,
        BOTTOM,
        TOP
    };

    public class Quark: Particle {

        public QUARK_STATE State(){// ???
            return QUARK_STATE.NONE;
        }
    }
}