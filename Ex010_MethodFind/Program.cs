int[] array = { 21, 20, 3, 4, 95, 96, 72, 82, 29 };

int n = array.Length;
int find = 82;

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