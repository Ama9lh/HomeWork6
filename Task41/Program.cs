Console.Clear();
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
Console.WriteLine("Введите свои числа: ");
void FillArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
}

int pos = 0;

FillArray(array); 

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        pos++;
    }
}   

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Положительных чисел в массиве = {pos}");