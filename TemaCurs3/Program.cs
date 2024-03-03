/*Scrieti o functie care va calcula suma cifrelor unui numar.*/

Console.WriteLine("Enter the numbers");
int number = Int32.Parse(Console.ReadLine());
int sum = SumOfNumbers(number);

int SumOfNumbers(int number)
{
    if (number != 0 && number > 0)
    {
        return (number % 10 + SumOfNumbers(number / 10));
    }
    else
    {
        return 0;
    }

}

Console.WriteLine($"The Sum of Digits is : {sum}");
