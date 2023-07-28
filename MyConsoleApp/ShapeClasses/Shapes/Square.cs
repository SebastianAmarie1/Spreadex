
// Class for the Square object with Size

namespace DrawingApp  {

    public class Square : Shape {

        private int _size;
		
		public int Size { 
			get { return _size; }
			set {
				if (value < 0)
					throw new ArgumentException("Width must be a positive number");
				_size = value;
			} 
		}

        public override string Print() {
            return $"Square {base.Print()} size={Size}";
        }    

    }
}