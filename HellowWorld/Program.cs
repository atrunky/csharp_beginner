// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.ReadLine();
namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameImput;
            string birthdateImput;

            Console.WriteLine("Hello, Welcome to the calculate of years");
            Console.WriteLine("Please, Write your name: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {nameImput} ");
            Console.WriteLine("Please, Write your date of birthdate, in format: dd/mm/yyyy ");
            birthdateImput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdateImput,out dateConverted);
            if(isDateValid==false)  Console.WriteLine($"Bad your date of birthdate, I wrote the date format wrong. {birthdateImput} ");
            var person = new Person{
                Name = nameImput,
                Birthday=dateConverted,
                Age=DateTime.Now.Year-dateConverted.Year

            };
            Console.WriteLine($"Tu nombre: {person.Name} ");
            Console.WriteLine($"Nice to meet you {person.Birthday/*.ToString('yy-MM-dd')*/} ");
            Console.WriteLine($"Tu edada es: {person.Age} años. ");

            Console.WriteLine();

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}

//*************************************************************************
/*       static void Main()
       {
           /*Data Type*/
/*
int myNum = 3;                 //Integer (whole number)
double myDoubleNum = 6.988;    //Floating point number
char myLetter = 'R';           //character
bool myBool = true;            //Boolean
string myText = "Hello";       //texto
*******************************************
var Name = "Pepito Perez";
Console.WriteLine($"Hello world {Name} ");
Console.WriteLine($"Thanks for comming {Name} ");
Console.WriteLine();

}
*/ 