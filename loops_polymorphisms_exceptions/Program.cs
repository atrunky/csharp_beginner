var circ = new Circle();

circ.Radio = 20;
var result_area = circ.Area();
var result_perim = circ.Perimeter();

Console.WriteLine($"The Area is: {result_area}, and the Perimeter is: {result_perim} the new radio is: {circ.Add10()} ");

/*Serio o sucesión de Fibonacci */
int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

/*Excepciones*/
try
{
    Console.WriteLine("Number to divide: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("Divider: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    Console.WriteLine($"Result: {n / divisor}");
}
catch(DivideByZeroException)
{
    Console.WriteLine("Cannot be divided by zero: ");
}
catch(Exception)
{
    Console.WriteLine("Unknown error: ");
}
// abstract class Figure
// {
//     public abstract double Area();
//     public abstract double Perimeter();
// }

interface IExtraCalculation
{
    public double Add10();
}

interface IFigura
{
    public double Area();
    public double Perimeter();
}

class Circle : IFigura/*Figure*/, IExtraCalculation
{
    public double Radio { get; set; }
    // public override double Area() => Math.PI * Radio * Radio;
    // public override double Perimeter() => 2 * Math.PI * Radio;
    public double Area() => Math.PI * Radio * Radio;
    public double Perimeter() => 2 * Math.PI * Radio;

    public double Add10()
    {
        return Radio + 10;
    }
}
