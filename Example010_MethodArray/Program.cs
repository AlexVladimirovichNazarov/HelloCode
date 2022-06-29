
int[] array = { 15, 21, 39, 12, 23, 33, 11, 17 };

int n = array.Length;

int find = 23;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

