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
        result = double.TryParse(Console.ReadLine(), out number);
    }  

    return inputNumber;


    return inputNumber;
}

/// <summary>
/// Write in Console array
/// </summary>
/// <param name="inputArray">
/// given array
/// </param>
void WriteArray(string[,] inputArray)
{
    System.Console.WriteLine();

    for(int k=0; k < (1 + inputArray.GetUpperBound(1)); k++)
    {
        Console.WriteLine(inputArray[i, k]);
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
int[,] FillArray(int size)
{
    int half = size / 2;
    int amountElements = size * size;
    int[,] spiralMatrix = new int[size, size];
    int row = 0;
    int column = 0;
    int count = 0;
    while(count < amountElements)
    {
        if
        // 1 quarter (upper)
        (
            (column < size - row - 1) && (column > row - 2) 
            && (row < half + 1 ) && (row > -1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("1 quarter");
            System.Console.WriteLine();
            column++;
        }    
        else if
        // 2 quarter (right)
        (
            (column < size) && (column >= half)  
            && (row < column) && (row > -1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("2 quarter");
            System.Console.WriteLine();
            row++;
        }
        else if
        // 3 quarter (lower)
        (
            (column < size) && (column > size - row - 1)  
            && (row < size) && (row >= half)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
            System.Console.WriteLine("3 quarter");
            System.Console.WriteLine();
            column--;
        }
        else if
        // 4 quarter (left)
        (
            (column < half) && (column > - 1)  
            && (row < size) && (row > column + 1)
        )
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");            
            System.Console.WriteLine("4 quarter");
            System.Console.WriteLine();
            row--;
        }        
        else
        {
            spiralMatrix[row, column] = count + 1;
            System.Console.WriteLine("исключение");
            System.Console.WriteLine($"count = {count}");
            System.Console.WriteLine($"spiralMatrix[{row}, {column}] = {spiralMatrix[row, column]}");
        }

        count++;
    }

    return spiralMatrix;
}


System.Console.Write("Введите размер двумерного массива с равными измерениями: ");
int sizeArray = CheckConsoleInput();

int[,] array = FillArray(sizeArray);
WriteArray(array);
