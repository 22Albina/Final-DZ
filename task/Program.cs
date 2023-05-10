//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 





string[] array1 = new string[] {"11111", "222", "33", "qwer","heh", "tak", "array", "-=-"};
string[] array2 = new string[array1.Length];

void StringArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
StringArray(array1, array2);
PrintArray(array1);
PrintArray(array2);