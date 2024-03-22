// See https://aka.ms/new-console-template for more information
/*Classes*/
// var rect = new Rectangle();
// rect.Base = 20;
// rect.Height = 40;
// Console.WriteLine($"The Area is: {rect.Area()}");
// Console.WriteLine($"The Perimeter is: {rect.Perimeter()}");
/*End Classes*/
/*Para comentar varias líneas en Visual Studio Code, seleccionar las líneas y presionar las teclas Ctrl + K + C en Windows o Linux,
 para descomentarlas, se debe presionar Ctrl + K + U */
var scua = new Scuare();
scua.Base = 20;
scua.Height = 40;
Console.WriteLine($"The Area is: {scua.Area()}");
Console.WriteLine($"The Perimeter is: {scua.Perimeter()}");
Console.WriteLine($"The Side is: {scua.Side}");

class Rectangle
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Area() => Base * Height;
    public double Perimeter() => 2 * Base + 2 * Height;
}

class Scuare : Rectangle
{
    public double Side
    {
        set {Base = value; Height = value;}
        get {return Base;}
    }
}


