Console.Clear();

Console.Write("Введите количество чисел М: ");
int M = Convert.ToInt32(Console.ReadLine());

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите " + (i + 1) + " число: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int[] ConverArray(string[] array)
{
    int[] numberArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        numberArray[i] = Convert.ToInt32(array[i]);
    }
    return numberArray;
}

void PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество положительных чисел = " + count);
}

string[] NewArray = FillArray(M);
int[] arraynumber = ConverArray(NewArray);
PositiveNumbers(arraynumber);