/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la
tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
*Dificultate ridicata*
• Numerele patrate perfecte din vector
*/

Console.Write("Enter the size of the vector: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] vector = ReadVectorFromUser(size);

int[] divisibleByThree = GetNumbersDivisibleByThree(vector);
int[] perfectSquares = GetPerfectSquares(vector);

var result = FindMinMax(vector);
Console.WriteLine($"Minimum: {result.min}, Maximum: {result.max}");

Console.WriteLine("Numbers divisible by 3:");
for (int i = 0; i < divisibleByThree.Length; i++)
{
    Console.WriteLine(divisibleByThree[i]);
}
Console.WriteLine("Perfect squares:");
for (int i = 0; i < perfectSquares.Length; i++)
{
    Console.WriteLine(perfectSquares[i]);
}
int[] ReadVectorFromUser(int size)
{
    int[] vector = new int[size];
    Console.WriteLine("Enter {0} numbers to populate the vector:", size);
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter number {0}: ", i + 1);
        vector[i] = Convert.ToInt32(Console.ReadLine());
    }
    return vector;
}
(int min, int max) FindMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return (min, max);
}
int[] GetNumbersDivisibleByThree(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 3 == 0)
        {
            count++;
        }
    }

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 3 == 0)
        {
            result[index] = arr[i];
            index++;
        }
    }
    return result;
}
int[] GetPerfectSquares(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int sqrt = (int)Math.Sqrt(arr[i]);
        if (sqrt * sqrt == arr[i])
        {
            count++;
        }
    }

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int sqrt = (int)Math.Sqrt(arr[i]);
        if (sqrt * sqrt == arr[i])
        {
            result[index] = arr[i];
            index++;
        }
    }
    return result;
}
