/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

int[] filArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = getNumber("Введите число: ");
    }
    return array;
}

int getCountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int len = getNumber("Введите количество вводимых чисел: ");
int[] array = new int[len];
filArray(array);

Console.WriteLine($"Вы ввели {getCountPositiveNumbers(array)} чисел больше нуля");