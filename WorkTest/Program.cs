
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
string[] array3 = NewArray(array);
string[] finalArray = FillArray(array3,array);

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

string[] NewArray(string[] arr3)
{
    int count = 0;
    string[] ThreeSym = new string[count];

    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i].Length <= 3)
        {
            count++;
            ThreeSym = new string[count];
        }
    }
    return ThreeSym;
}

string[] FillArray(string[] arr3, string[] arr)
{
    int count1 = 0;
    string[] Sym = new string[arr3.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Sym[count1] = arr[i];
            count1++;
        }
    }
    return Sym;
}


