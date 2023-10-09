// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Promt(string message)
{
    Console.Write(message);
    string inputRead = Console.ReadLine();
    int value = Convert.ToInt32(inputRead);
    return value;
}
int[] GetMNumbers(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Promt($"Input number {i + 1} = ");
    }
    return array;
}
int NumbersMoreThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i] > 0) count++;
    }
    return count;
}

int[] arr = GetMNumbers(Promt("Input length array: "));
Console.WriteLine($"Amount of numbers which more tah 0 = {NumbersMoreThanZero(arr)}");










