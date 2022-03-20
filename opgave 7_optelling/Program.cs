Console.Write("Count: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (count == 1)
{
    Console.WriteLine("1");
}
else
{
    int[] number = new int[count];
    number[0] = 1;
    number[1] = 1;

    for (int i = 2; i < count; i++)
    {
        number[i] = number[i - 1] + number[i - 2];
    }
        
    for (int i = 0; i < count; i++)
    {
        Console.Write(number[i] + " ");
    }   
}
Console.WriteLine("");