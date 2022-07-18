/*
int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);
*/

int[] array = {1, 2, 3, 22, 44, 55, 66, 77, 88, 55, 999, 1233};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.Write(index);
        break;
    }
    index++;
}