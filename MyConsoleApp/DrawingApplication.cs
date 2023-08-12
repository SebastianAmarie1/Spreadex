using System;
using System.Collections.Generic;

//use the namesspace DrawingApp
using DrawingApp;

class DrawingApplication {
	
	static void Main(string[] args) {

        //Create the Objects
		var shapes = new List<IShape> {
			new Rectangle { X = 10, Y = 10, Width = 30, Height = 40 },
            new Square { X = 15, Y = 30, Size = 35 },
            new Ellipse { X = 100, Y = 150, DiameterH = 300, DiameterV = 200 },
            new Circle { X = 1, Y = 1, Size = 300 },
            new TextBox { X = 5, Y = 5, Width = 200, Height = 100, Text = "sample text" }
		};

		Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Requested Drawing");
        Console.WriteLine("----------------------------------------------------------------");
        //Print Each Shape Out
        foreach (var shape in shapes){
            Console.WriteLine(shape.Print());
        }

        Console.WriteLine("----------------------------------------------------------------");
	}
}