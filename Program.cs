//УРОК №7
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
void PrintArray(int[] myArray)
{
    int count = myArray.Length;
    int position = 0;
    while (position < count-1)
{
    Console.Write($"{myArray[position]} ");
    position++;
}
Console.Write($"{myArray[position]}");
}
Console.WriteLine("сколько чисел введете?");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [a];
for (int i=0; i < arr.Length; i++)
{
    Console.Write("введите числа ");
    arr[i]= Convert.ToInt32(Console.ReadLine());
}
PrintArray(arr);
int count=0;
for (int u=0; u<arr.Length; u++)
{
    if (arr[u]>0)
    {
        count++;
    }
        }
Console.WriteLine();
    Console.Write(count);
//0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
//Задача 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*Console.Write("введите к1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" x = {(b2-b1/(k1-k2))}");
int x = (b2-b1/(k1-k2));
Console.WriteLine($"y = {k1*x+b1}");*/
