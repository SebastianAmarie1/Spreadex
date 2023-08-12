
// Parent Class for the shapes, all shapes share X and Y

namespace DrawingApp {

	public class Shape : IShape {

		public int X { get; set; }
		public int Y { get; set; }

		public virtual string Print(){
			return $"({X}, {Y})";
		}

	}
}