Console.WriteLine("Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];

for (int i = 0; i < N; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Console.ReadLine();
    }
Console.Write("Ваш массив: ");
for (int i = 0; i < N; i++)
    {
        Console.Write(array[i] + "; ");
    }
Console.WriteLine();

Console.Write("Элементы массива, в которых длина строк меньше или равно 3: ");
for (int i = 0; i < N; i++)
{
    if(array[i].Length <= 3)
    {
        Console.Write(array[i] + "; ");
    }
}
