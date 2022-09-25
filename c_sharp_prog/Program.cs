// 1th_quarter_exam
// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа


/// <summary>
/// Thrown when input value is Integer and greater than 1
/// </summary>
/// <returns>
/// returns the entered integer
/// </returns>
int CheckConsoleInput()
{
    bool result = int.TryParse(Console.ReadLine(), out int inputNumber);
    
    while(result != true & inputNumber > 1)
    {
        Console.WriteLine("Ошибка ввода: введено не целое число больше 0. Попробуйте повторить.");
        result = int.TryParse(Console.ReadLine(), out inputNumber);
    }
    return inputNumber;
}

/// <summary>
/// Write in Console array
/// </summary>
/// <param name="inputArray">
/// given array
/// </param>
void WriteArray(string[] inputArray)
{
    System.Console.WriteLine();

    for(int k=0; k < (1 + inputArray.GetUpperBound(0)); k++)
    {
        Console.WriteLine(inputArray[k]);
    }
}

/// <summary>
/// Fill string array with element's length smaller strLength
/// </summary>
/// <param name="size">
/// rank0 = size 1D array
/// </param>
/// <param name="strLength">
/// array[i].length < strLength
/// </param>
string[] FillArray(int size, int strLengthMax)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        int strLength = new Random().Next(1, strLengthMax);
        for (int j = 0; j < strLength; j++)
        {
            array[i] = array[i] + Convert.ToChar(new Random().Next(1, strLengthMax));
        }
    }
    return array;    
}


System.Console.Write("Введите размер массива: ");
int sizeArray = CheckConsoleInput();
System.Console.Write("Введите максимальную длину строки: ");
int maxSizeSrting = CheckConsoleInput();
string[] array = FillArray(sizeArray, maxSizeSrting);
WriteArray(array);
