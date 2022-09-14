string[] array = new string[6] { "Russia", "1994", "Hi", "000", "task", "1" };
string[] resultArray = new string[array.Length];

void GetArray(string[] arr, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[count] = arr[i];
            count++;
        }
    }
}