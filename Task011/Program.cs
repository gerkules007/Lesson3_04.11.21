int FindMinMax(int[] input)
{
    if (input is null || input.Length == 0)
    {
        throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
    }

    var max = int.MinValue;
    foreach (var i in input)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}

int[] NaturalArray(int minValue, int maxValue)
{
    int maxindex = maxValue-minValue+1;
    int[] newArray = new int[maxindex];
    for (int i = 0, n = minValue; i < maxindex; i++)
    {
        newArray[i] = n;
        n++;
    }
    return newArray;
}

int[] A = NaturalArray(10, 99);
int maxN = FindMinMax(A);
Console.WriteLine($"Максимальное число в массиве {maxN}");
