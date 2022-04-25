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

//This is the method for summating all even number
static int EvenNumberSummation(int[] x)
{
    int total = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 2 == 0)
        {
            total += x[i];
        }
    }
    return total;

}


Console.Write("How many number you want to input? ");
int inputNum = Convert.ToInt32(Console.ReadLine());
int[] array = new int[inputNum];
bool retry = false;


for (int i = 0; i < array.Length; i++)
{
    retry = false;
    try
    {
        Console.Write("Enter an integer number " + (i + 1) + " : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e){
        retry = true;
//        Console.Clear();
        Console.WriteLine("You did not enter an integer");
    }

    if (retry){
        i = i-1;
    }

}

while (true)
{
    Console.Write("Do you want to insert another number? input Y if Yes and N if no. ");
    String answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
    {

        Array.Resize<int>(ref array, array.Length+1);
        Console.Write("Input an integer number " + array.Length + " : ");
        array[array.Length-1] = Convert.ToInt32(Console.ReadLine());
    }
    else if (answer == "N" || answer == "n")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Input.");
    }

}
for(int i = 0; i < array.Length; i++) {
Console.Write(array[i]+"\t");
}
Console.WriteLine("\nThe summation of all odd numbers is : " + OddNumberSummation(array));
Console.WriteLine("\nThe summation of all odd numbers is : " + EvenNumberSummation(array));


