int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 99 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);


// for (int i = 0; i < n; i = i + 1)
max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);



// форич
max = array[0];
foreach(int e in array)
{
    if (e>max)
    {
        max = e;
    }
}
Console.WriteLine(max);