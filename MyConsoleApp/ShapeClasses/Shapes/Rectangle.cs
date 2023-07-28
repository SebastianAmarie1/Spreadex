
// Class for the Rectangle object with Width, Height 

namespace DrawingApp {

	public class Rectangle: Shape {

		public int Width { get; set; }
		public int Height { get; set; }

		public override string Print() {
			return $"Rectangle {base.Print()} width={Width} height={Height}";
		}

	}
}