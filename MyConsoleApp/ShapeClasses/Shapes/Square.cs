
// Class for the Square object with Size

namespace DrawingApp  {

    public class Square : Shape {

        public int Size { get; set; }

        public override string Print() {
            return $"Square {base.Print()} size={Size}";
        }    

    }
}