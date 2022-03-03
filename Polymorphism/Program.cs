using Polymorphism.Models;

Animal Cat = new Cat();
Cat.Speak();

Animal Dog = new Dog();
Dog.Speak();

Console.WriteLine("Hello, World!");


//Overloading example

Rectangle rectangle = new Rectangle(10.0, 9.0);

Console.WriteLine(rectangle.Width);
Console.WriteLine(rectangle.Height);
Console.WriteLine(rectangle.GetArea());

rectangle.Resize(5.0);
Console.WriteLine(rectangle.Width);
Console.WriteLine(rectangle.Height);
Console.WriteLine(rectangle.GetArea());

