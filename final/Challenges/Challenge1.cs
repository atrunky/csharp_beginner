namespace itm.csharp.basic
{
    /*INDICA SI UN NUMERO ES POSITIVO, NEGATIVO O CERO*/
    /*INDICATES IF A NUMBER IS POSITIVE, NEGATIVE OR ZERO*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Enter one number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positive");
            else if (num < 0) Console.WriteLine("Negative");
            else Console.WriteLine("Is Cero");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*OPERACIONES BASICA ENTRE DOS NUMEROS*/
    /*BASIC OPERATIONS BETWEEN TWO NUMBERS*/
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Addition: {num1 + num2}\nSubtraction: {num1 + num2}\nMultiplication {num1 + num2}\nDivision: {num1 + num2}");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*CUADRADO DE UN NUMERO*/
    /*SQUARE OF A NUMBER*/
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Enter one number: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"The square of  {numero} is: {numero * numero}");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }
    /*AREA DE UN CIRCULO*/
    /*AREA OF A CIRCLE*/
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * radio * radio;
            Console.WriteLine($"The area of ​​the circle with radius{radio} is {area}");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*DIA DE LA SEMANA*/
    /*WEEKDAY*/
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Enter a number between 1 and 7: ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Monday-Lunes"); break;
                case 2: Console.WriteLine("Tuesday-Martes"); break;
                case 3: Console.WriteLine("Wednesday-Miercoles"); break;
                case 4: Console.WriteLine("Thursday-Jueves"); break;
                case 5: Console.WriteLine("Friday-Viernes"); break;
                case 6: Console.WriteLine("Saturday-Sabado"); break;
                case 7: Console.WriteLine("Sunday-Domingo"); break;
                default: Console.WriteLine("Invalid number"); break;
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*IMPUESTO A PAGAR*/
    /*TAX PAYABLE*/
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Enter your monthly salary: ");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 1000 ? 0.1 * salario : 0;
            Console.WriteLine($"The tax to pay is {impuesto}");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*DIVISION DE 2 NUMEROS*/
    /*DIVISION OF 2 NUMBERS*/
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Number to divide: ");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divider: ");
                double divisor = double.Parse(Console.ReadLine());
                Console.WriteLine($"The result is:  {n / divisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot be divided by ZERO !!! ");
            }
            catch (Exception)
            {
                Console.WriteLine("Error when performing the operation...!!! ");
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*CALCULA Y MUESTRA LA SUMA DE NUMEROS IMPARES ENTRE 1 Y 100*/
    /*CALCULATE AND SHOW THE SUM OF ODD NUMBERS BETWEEN 1 AND 100*/
    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"The sum of odd numbers between 1 and 100 is: {suma} ");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*SUMAR FRACCIONES*/
    /*ADDING FRACTIONS*/
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Enter numerator of the first fraction: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter denominator of the first fraction: ");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter numerator of the second fraction: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter denominator of the second fraction: ");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num1, den1);
                Fraccion resultado = fraccion1.Sumar(fraccion2);
                Console.WriteLine($"The sum of {fraccion1} and {fraccion2} is: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();

        }
    }

    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }
        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0) ;
            {
                throw new ArgumentException("The denominator cannot be zero. ");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }
        //SE PUEDEN AGREGAR MAS METODOS PARA OTRAS OPERACIONES DE SER NECESARIO
        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    /*SOLICITAR PALABRA AL USUARIO Y MOSTRARLA INVERTIDA*/
    /*REQUEST WORD FROM THE USER AND SHOW IT INVERTED*/
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Enter one word: ");
            string palabra = Console.ReadLine();
            string invertida = new string(palabra.Reverse().ToArray());
            Console.WriteLine($"The inverted word is: {invertida}");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*SOLICITA AL USUARIO 3 NUMEROS Y MUESTRA SU PROMEDIO*/
    /*ASKS THE USER FOR 3 NUMBERS AND SHOWS THEIR AVERAGE*/
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            double num3 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine($"The average of the three numbers is: {promedio}");

            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();

        }
    }

    /*SOLICITAR AL USUARIO 5 NUMEROS Y MUESTRA EL MAS GRANDE*/
    /*ASK THE USER FOR 5 NUMBERS AND SHOW THE LARGEST ONE*/
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter one number {i + 1} : ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number more big of the list is: {numeros.Max()} ");
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*INTRODUCE UNA PALABRA, SI O NO ES PALINDROMO*/
    /*ENTER A WORD, IF OR NOT IT IS PALINDROME*/
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Enter one word: ");
            string palabra = Console.ReadLine();

            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                Console.WriteLine($"The word {palabra} is a palindrome. ");
            }
            else
            {
                Console.WriteLine($"The word {palabra} is not a palindrome. ");
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*EL USUARIO INGRESA NUMERO Y SE MUESTRA SI ES PAR O IMPAR*/
    /*THE USER ENTER NUMBER AND IT IS SHOWN IF IT IS EVEN OR ODD*/
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Enter first number: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"The number {numero} is even(par). ");
            }
            else
            {
                Console.WriteLine($"The number {numero} is odd(impar). ");
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }

    /*INGRESA UN NUMERO Y VALIDA SI ESTA ENTRE EL RANGO DE 0 A 10*/
    /*ENTER A NUMBER AND VALIDATE IF IT IS BETWEEN THE RANGE OF 0 TO 10*/
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Enter one number: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                Console.WriteLine($"The number  {numero} is in the range of 0 a 10. ");
            }
            else
            {
                Console.WriteLine($"The number  {numero} is out the range of 0 a 10. ");
            }
            Console.WriteLine(" \n****** Operation completed, thank you. ****** \n ******** Select New Option ********");
            Menu.MostrarMenu();
        }
    }
}