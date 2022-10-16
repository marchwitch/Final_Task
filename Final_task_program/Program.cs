// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] collection = { "ice", "anatomy", "ask", ":-)", "axe", "lesson", "90987" };
Console.WriteLine("Первоначальный массив:");
PrintArray(collection);
Console.WriteLine();
string[] collect = NewArrayLessThreeSymbols(collection);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
PrintArray(collect);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

string[] NewArrayLessThreeSymbols(string[] array)
{   
    int newLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if(length <= 3) newLength++;
    }

    string[] result = new string[newLength];
    
    int count = 0; 
    for(int i = 0; i < array.Length; i++)
    {   
        if(count < newLength)
        {
            int length = array[i].Length;
            if(length <= 3)
            {
                result[count] = array[i]; 
                count++; 
            }
        }
    }
    return result; 
}
