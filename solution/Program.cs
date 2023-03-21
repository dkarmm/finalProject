int GetDataFromUser(string text)
{
    int value = 0;
    bool flag = false;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
        if (value <= 0)
        {
            Console.WriteLine("Необходимо ввести целое число больше 0.");
            flag = false;
        }
    }
    return value;
}
void PhillArray(string[] array)
{
    int elementsCounts = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {elementsCounts} элемент массива: ");
        array[i] = Console.ReadLine();
        elementsCounts++;
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
string [] GetResultArray(string[] array)
{
    int resultArraySize = 0;
    int indexForArrayWithIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArraySize++;
        }
    }
    string[] arrayResult = new string[resultArraySize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[indexForArrayWithIndex] = array[i];
            indexForArrayWithIndex++;
        }
    }
    return arrayResult;
}

int arraySize = GetDataFromUser("Введите количество элементов массива: ");
string[] array = new string[arraySize];

PhillArray(array);
Console.Write("Элементы, длина которых меньше или равна 3: ");
ShowArray(GetResultArray(array));