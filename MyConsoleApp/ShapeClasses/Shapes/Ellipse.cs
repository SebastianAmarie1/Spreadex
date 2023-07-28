
// Class for the TextBox object with Height Diameter and Vertival Diameter

namespace DrawingApp {

	public class Ellipse: Shape {

		public int DiameterH { get; set; }
		public int DiameterV { get; set; }

		//function that overrides the base parent class 
		public override string Print() {
			return $"Ellipse {base.Print()} diameterH = {DiameterH} diameterV = {DiameterV}";
		}

	}
}