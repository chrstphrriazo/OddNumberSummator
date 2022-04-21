// See https://aka.ms/new-console-template for more information

//This is the method for summating all odd number
static int OddNumberSummation(int[] x)
{
    int total = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 2 == 1)
        {
            total += x[i];
        }
    }
    return total;

}

int[] array = new int[5];
bool retry = false;


for (int i = 0; i < array.Length; i++)
{
    retry = false;
    try
    {
        Console.Write("Enter an integer number " + (i + 1) + " : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e)
    {
        retry = true;
        Console.Clear();
        Console.WriteLine("You did not enter an integer");
    }
    if (retry)
    {
        i = 0;
    }

}

Console.WriteLine(OddNumberSummation(array));


