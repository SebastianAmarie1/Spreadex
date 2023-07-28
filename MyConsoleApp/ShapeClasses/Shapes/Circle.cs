
// Class for the Circle object with Size

namespace DrawingApp {

    public class Circle : Shape {

        private int _size;
		
		public int Size { 
			get { return _size; }
			set {
				if (value < 0)
					throw new ArgumentException("Size must be a positive number");
				_size = value;
			} 
		}


        public override string Print() {
            return $"Circle {base.Print()} size ={Size}";
        }

    }
}