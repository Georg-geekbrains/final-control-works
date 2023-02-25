
/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше или равна 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте выполнения
алгоритма. При решении не рекомендуестя пользоваться коллекциями, лучше
обойтись исключительно массивами.
Примеры:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []*/

Console.Clear();
Console.WriteLine("Введите  пять элементов массива");

string[] array = GetArrayFromUser(5);
int newSize  = NewArraySize(array);
string[] finalArray = FillArray(newSize,array);

Console.WriteLine($"[ {String.Join(", ", array)} ] -> [ {String.Join(", ", finalArray)} ]");


string[] GetArrayFromUser(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        string n = Console.ReadLine() ?? "";
        arr[i] = n;
    }
    return arr;
}

int NewArraySize(string[] arr3)
{
    int count = 0;
    int nSize = 0;
    int m = 3;

    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i].Length <= m)
        {
            count++;
            nSize = count;
        }
    }
    return nSize;
}

string[] FillArray(int n, string[] arr)
{
    int count1 = 0;
    int m1 = 3;
    string[] Sym = new string[n];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= m1)
        {
            Sym[count1] = arr[i];
            count1++;
        }
    }
    return Sym;
}


