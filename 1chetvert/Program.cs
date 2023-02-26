// Задача для итоговой работы первой четверти
string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
string[] array3 = new string[4] {"1234", "1567", "computer science", "-2"};
string[] array4 = new string[array3.Length];
string[] array5 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] array6 = new string[array5.Length];

//метод вычисляет в первом массиве строку меньше 3
void FirstArray(string[] array1, string[] array2)
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
//выводит ответ первого массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//метод вычисляет во втором массиве строку меньше 3
void SecondArray(string[] array3, string[] array4)
{
    int count = 0;
    for (int i = 0; i < array3.Length; i++)
    {
    if(array3[i].Length <= 3)
        {
        array4[count] = array3[i];
        count++;
        }
    }
}
//выводит строку из второго массива
void PrintArray2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//метод вычисляет в третьем массиве строку меньше 3
void ThirdArray(string[] array5, string[] array6)
{
    int count = 0;
    for (int i = 0; i < array5.Length; i++)
    {
    if(array5[i].Length <= 3)
        {
        array6[count] = array1[i];
        count++;
        }
    }
}
//выводит ответ третьего массива
void PrintArray3(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FirstArray(array1, array2);
PrintArray(array2);
SecondArray(array3, array4);
PrintArray2(array4);
ThirdArray(array5, array6);
PrintArray3(array6);