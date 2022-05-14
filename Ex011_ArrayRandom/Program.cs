﻿void FillArray(int[] collection)
{
    int len = collection.Length;
    int ind = 0;
    while (ind < len)
    {
        collection[ind] = new Random().Next(1, 10);
        ind++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine(pos);