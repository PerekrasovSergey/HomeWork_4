// See https://aka.ms/new-console-template for more information

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

static void TaskNumber()
{
    int S = 2;
    while (S % 2 == 0)
    {
        System.Console.Write("Input number (or 'q' for exit): ");
        string? text = Console.ReadLine();
        if (text == "q")
        {
            return;
        }
        else
        {
            int number = Convert.ToInt32(text);
            S = number % 10;
            number /= 10;
            while (number > 0)
            {
                S += number % 10;
                number /= 10;
            }
        }
    }
}

// TaskNumber();

// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

static int EvenNumberInArr(int[] arr)
{
    int answer = 0;
    for (int i = 0; i < arr.Length; i += 1)
    {
        if (arr[i] % 2 == 0)
        {
            answer += 1;
        }
    }
    return answer;
}
static int[] RandomArrayThreeDidgit(int len)
{
    int[] answer = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i += 1)
    {
        answer[i] = rand.Next(100, 999);
        System.Console.Write(answer[i] + " ");
    }
    System.Console.WriteLine();
    return answer;
}

// System.Console.Write("Input length array: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] Arr = RandomArrayThreeDidgit(n);
// System.Console.WriteLine(EvenNumberInArr(Arr));

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

static void ReversArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i += 1)
    {
        Console.Write(arr[arr.Length - i- 1] + " "); 
    }
}

System.Console.Write("Input length array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Arr = RandomArrayThreeDidgit(n);
ReversArr(Arr);


