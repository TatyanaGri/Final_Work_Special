int GetSize(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректный размер! Повторите ввод.");
        }
    }
    return result;
}

string[] InitArray(int size) 
{
    string[] startArray = new string[size];
    
    for (int i = 0; i < startArray.Length; i++)
    {
        Console.Write($"Заполните {i + 1} элемент массива: ");
        startArray[i] = Console.ReadLine();
    }
    return startArray;
}
 
string[] FinalArray(string[] startArray) 
{
    int length = 0;
    int count = 0;

    for (int i = 0; i < startArray.Length; i++)
    {
        length = startArray[i].Length;
        if (startArray[i].Length <= 3)
        {
            count++;
        }
    }
   
    string[] finalArray = new string[count];
    count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        length = startArray[i].Length;
        if (length <= 3)
        {
            finalArray[count] = startArray[i];
            count++;
        }
    }
    return finalArray;
}

int size = GetSize("Введите размер массива: ");
Console.WriteLine();

string[] startArray = InitArray(size);
Console.WriteLine();
Console.WriteLine("Массив введеный пользователем: ");
Console.WriteLine("[{0}]",string.Join(", ", startArray));

string[] finalArray = FinalArray(startArray);
Console.WriteLine();
Console.WriteLine("Массив удовлетворяющий заданым условиям: ");
Console.WriteLine("[{0}]",string.Join(", ", finalArray));

