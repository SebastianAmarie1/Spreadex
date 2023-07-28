
// Class for the TextBox object with Height Diameter and Vertival Diameter

namespace DrawingApp {

	public class Ellipse: Shape {

		private int _diameterh;
		private int _diameterv;
		
		public int DiameterH { 
			get { return _diameterh; }
			set {
				if (value < 0)
					throw new ArgumentException("DiameterH must be a positive number");
				_diameterh = value;
			} 
		}
		
		public int DiameterV { 
			get { return _diameterv; }
			set {
				if (value < 0)
					throw new ArgumentException("DiameterV must be a positive number");
				_diameterv = value;
			} 
		}

		//function that overrides the base parent class 
		public override string Print() {
			return $"Ellipse {base.Print()} diameterH = {DiameterH} diameterV = {DiameterV}";
		}

	}
}