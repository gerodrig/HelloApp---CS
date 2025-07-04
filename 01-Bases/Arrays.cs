partial class Program {
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;

        //Direct assignation
        int[] numbersArray = [5, 19, 13, 29, 30, 29];

        //?Indexes
        Console.WriteLine($"First element {numbersArray[0]}");
        Console.WriteLine($"Third element {numbersArray[2]}");

        //Array Length
        Console.WriteLine($"The number of elements is: {numbersArray.Length}");

        //Starting from the end of the elements
        Console.WriteLine($"Last element is : {numbersArray[^1]}");
        Console.WriteLine($"SecondLast element is : {numbersArray[^2]}");

        //Ranges to get subarrays
        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];


        int idx = 1;
        foreach (var number in firstThree)
        {

            Console.WriteLine($"The first three elements are: {idx}- {number}");
            idx++;
        }
    }
}