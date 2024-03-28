using CSharp.Tutorials.DataStructureTypes;

var p1 = new Person("Jepozdemir", 36);
var p2 = p1;
p2.Age = 40;
Console.WriteLine(p1.Age);
Console.WriteLine(p2.Age);

var s1 = new Square(10);
var s2 = s1;
s2.Side = 5;
Console.WriteLine(s1.Perimeter());
Console.WriteLine(s2.Perimeter());

var mercedes = new Car { Brand = "Mercedes", MaxSpeed = 240 };

Console.WriteLine(mercedes.ToString());

// Output
// Car { Brand = Mercedes, Speed = 240 }

var car1 = new LuxuryCar("Mercedes", 240);
var car2 = new LuxuryCar("Mercedes", 240);

// Output: True, because records provides value-based equality
Console.WriteLine(car1 == car2);

