
// Class for the Circle object with Size

namespace DrawingApp {

    public class Circle : Shape {

        public int Size { get; set; }

        public override string Print() {
            return $"Circle {base.Print()} size ={Size}";
        }

    }
}