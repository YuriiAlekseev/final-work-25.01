void PrintArray(string [] array)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] +","); 
    }
Console.Write("]");
Console.WriteLine();  
}

string [] FillArray(string [] massiv)
{
    // int len = massiv.Length;
    for (int i = 0; i <= 3; i++)
    {
        if (massiv[i].Length > 3)
        {   
            Array.Clear(massiv, i, 1);
            // len = len-1;
        }
    }
    // Array.Resize(ref massiv, len);
    // Console.WriteLine(len);
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

Console.Clear();
Console.WriteLine("Введите ПЕРВЫЙ массив строк");
string [] massiv = InputMassiv();
Console.Clear();
Console.WriteLine("Введите  ВТОРОЙ массив строк");
string [] massiv2 = InputMassiv();
Console.Clear();
Console.WriteLine("Введите ТРЕТИЙ массив строк");
string [] massiv3 = InputMassiv();
string [] array = FillArray(massiv);
string [] array2 = FillArray(massiv2);
string [] array3 = FillArray(massiv3);
Console.Clear();
PrintArray(array);
PrintArray(array2);
PrintArray(array3);
