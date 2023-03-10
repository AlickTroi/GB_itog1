// написать программу, которая из имеющегося
// массива строк формируется массив из строк,
// длина которых меньше либо равна 3 символа

Console.Clear();

string[] CreatArrayFromArray(string[] array, int maximumChar)
{
    int numberOfNumbers = array.Length;
    int index = 0;
    int indexSmaller = 0;
    while (index < numberOfNumbers)
    {
        if (array[index].Length <= maximumChar)
        {
            indexSmaller++;
        }
        index++;
    }
    string[] result = new string[indexSmaller];
    index = 0;
    indexSmaller = 0;
    while (index < numberOfNumbers)
    {
        if (array[index].Length <= maximumChar)
        {
            result[indexSmaller++] = array[index];
        }
        index++;
    }
    return result;
}
