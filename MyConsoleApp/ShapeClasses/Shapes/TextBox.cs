
// Class for the TextBox object with Width, Height and Text

namespace DrawingApp {

    public class TextBox: Shape {

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
        
        public string Text { get; set; } = string.Empty;

        //function that overrides the base parent class 
        public override string Print() {
            return $"Textbox {base.Print()} width={Width} height={Height} Text=\"{Text}\"";
        }

    }
}