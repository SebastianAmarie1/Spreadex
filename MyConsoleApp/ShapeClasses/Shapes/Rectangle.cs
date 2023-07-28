
// Class for the Rectangle object with Width, Height 

namespace DrawingApp {

	public class Rectangle: Shape {

		private int _width;
		private int _height;
		
		public int Width { 
			get { return _width; }
			set {
				if (value < 0)
					throw new ArgumentException("Width must be a positive number");
				_width = value;
			} 
		}
		
		public int Height { 
			get { return _height; }
			set {
				if (value < 0)
					throw new ArgumentException("Height must be a positive number");
				_height = value;
			} 
		}

		public override string Print() {
			return $"Rectangle {base.Print()} width={Width} height={Height}";
		}

	}
}