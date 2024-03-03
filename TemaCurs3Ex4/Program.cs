/*Ex 4. Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata*/

Console.Write("Enter the size of the vector: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] vector = new int[size];


Console.WriteLine("Enter {0} numbers to populate the vector:", size);

for (int i = 0; i < size; i++)
{
    Console.Write("Enter number {0}: ", i + 1);
    vector[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < size / 2; i++)
{
    int temp = vector[i];
    vector[i] = vector[size - 1 - i];
    vector[size - 1 - i] = temp;
}

DisplayVector(vector);

    void DisplayVector(int[] arr)
{
    Console.WriteLine("Reversed Vector:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}