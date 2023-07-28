
// Class for the TextBox object with Width, Height and Text

namespace DrawingApp {

    public class TextBox: Shape {

        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; } = string.Empty;

        //function that overrides the base parent class 
        public override string Print() {
            return $"Textbox {base.Print()} width={Width} height={Height} Text=\"{Text}\"";
        }

    }
}