void PrintArray(string [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write(" " + array[i]); 
    }
Console.WriteLine();  
}

string [] FillArray(string [] massiv)
{
    for (int i = 0; i < 3; i++)
    {
        if (massiv[i].Length > 3)
        {
            massiv[i] = "";
        }
    }
    return massiv;
}

    string [] InputMassiv()
{
    string [] massiv = new string [4];
    int index = 0;
    int length = massiv.Length;
    Console.WriteLine("Введите четыре слова");
        while (index < length)
        {
            Console.WriteLine($"Введите {index+1} слово: ");
            massiv[index] = (Console.ReadLine()); 
            index++;
        }
return massiv;
}

Console.WriteLine("Введите ПЕРВЫЙ массив строк");
string [] massiv = InputMassiv();
Console.WriteLine("Введите  ВТОРОЙ строк");
string [] massiv2 = InputMassiv();
Console.WriteLine("Введите ТРЕТИЙ массив строк");
string [] massiv3 = InputMassiv();
string [] array = FillArray(massiv);
string [] array2 = FillArray(massiv2);
string [] array3 = FillArray(massiv3);
PrintArray(array);
PrintArray(array2);
PrintArray(array3);
