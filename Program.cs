// See https://aka.ms/new-console-template for more information

static void OddEvenNumberSummator(int[] array, ref int evenTotal, ref int oddTotal)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            oddTotal += array[i];
        }
        else
        {
            evenTotal += array[i];
        }
    }

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
int evenTotal = 0;
int oddTotal = 0;

OddEvenNumberSummator(array, ref evenTotal, ref oddTotal);
Console.WriteLine("\nThe sum of all odd numbers is : {0} \nThe sum off all even numbers is : {1}", oddTotal, evenTotal);


