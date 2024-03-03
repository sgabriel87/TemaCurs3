/*Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul*/


Console.WriteLine("Enter the numbers");
int number = Int32.Parse(Console.ReadLine());
int result = CheckPerfactSquare(number);


int CheckPerfactSquare(int number)
{
    double result = Math.Sqrt(number);
    bool isSquare = result % 1 == 0;
    if (isSquare == true)
    {
        Console.WriteLine($"It is Square {result}");
        return 1;
    }
    else
    {
        Console.WriteLine($"It's not Square {result}");
        return 0;
    }
}
