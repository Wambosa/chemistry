namespace Chemistry.Maths {
	public abstract class CustomUnit {

		protected string unitOfMeasurement = "???";

		public char prefix;
		public short value;

		public override string ToString() {
			return string.Format("{0} {1}{2}",
				value,
				prefix,
				unitOfMeasurement
			);
		}
	}
}