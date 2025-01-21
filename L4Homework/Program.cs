namespace L4Homework;

class Program
{
    static void Main(string[] args)
    {
        //Task 1: Common elements
        Console.WriteLine("------------------- Task 1 --------------------");
        string[] arrayOne = { "Hey", "hello", "test", "2", "4"};
        string[] arrayTwo = { "10","test", "hey", "4", "hello", "no" };
        
        for (int i = 0; i < arrayOne.Length; i++)
        {
            for (int j = 0; j < arrayTwo.Length; j++)
            {
                if (arrayOne[i] == arrayTwo[j])
                {
                    Console.Write($"{arrayOne[i]} ");
                }
            }
        }
        Console.WriteLine("\n------------------- End of Task 1 --------------------");
        //Task 2: Max Sequence of Equal Elements
        Console.WriteLine("------------------- Task 2 --------------------");
        int[] intArrayOne = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        int[] intArrayTwo = {1, 1, 1, 2, 3, 1, 3, 3};
        int[] intArrayThree = {4, 4, 4, 4};
        int[] intArrayFour = {0, 1, 1, 5, 2, 2, 6, 3, 3};
        FindLongestEqualSequence(intArrayOne);
        FindLongestEqualSequence(intArrayTwo);
        FindLongestEqualSequence(intArrayThree);
        FindLongestEqualSequence(intArrayFour);
        static void FindLongestEqualSequence(int[] arr)
        {
            int maxLength = 1; 
            int currentLength = 1;
            int startIndex = 0;
            int tempStart = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        startIndex = tempStart;
                    }
                    currentLength = 1;
                    tempStart = i;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startIndex = tempStart;
            }

            for (int i = startIndex; i < startIndex + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("------------------- End of Task 2 --------------------");
        //Task 3: Train
        Console.WriteLine("------------------- Task 3 --------------------");
        
        Console.WriteLine("Please input all vagons and their capacity: ");
        List<int> wagons = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        
        Console.WriteLine("Please input the max capacity of each wagon (a single integer): ");
        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        
        Console.WriteLine("Please input a command:\n" +
                          " - Add {passengers} – add a wagon to the end with the given number of passengers.\n" +
                          " - {passengers} - find an existing wagon to fit every passenger, starting from the first wagon.\n" +
                          " - end - to print the final state of the train (each of the wagons, separated by a space)");
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandParts = command.Split();

            if (commandParts[0] == "Add")
            {
                int passengersToAdd = int.Parse(commandParts[1]);
                wagons.Add(passengersToAdd);
            }
            else
            {
                int passengersToFit = int.Parse(commandParts[0]);
                
                bool placed = false;
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengersToFit <= maxCapacity)
                    {
                        wagons[i] += passengersToFit;
                        placed = true;
                        break;
                    }
                }
                
                if (!placed)
                {
                    Console.WriteLine("Not enough space in any wagon.");
                }
            }
        }
        
        Console.WriteLine(string.Join(" ", wagons));
        Console.WriteLine("------------------- End of Task 3 --------------------");
        //Task 4: Cards Game
        Console.WriteLine("------------------- Task 4 --------------------");
        Console.WriteLine("Please input the first player's hand: : ");
        List<int> firstPlayerHand = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        
        Console.WriteLine("Please input the second player's hand: : ");
        List<int> secondPlayerHand = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        while (firstPlayerHand.Count > 0 && secondPlayerHand.Count > 0)
        {
            int firstCard = firstPlayerHand[0];
            int secondCard = secondPlayerHand[0];
            
            if (firstCard > secondCard)
            {
                firstPlayerHand.Add(firstCard);
                firstPlayerHand.Add(secondCard);
            }
            else if (secondCard > firstCard)
            {
                secondPlayerHand.Add(secondCard);
                secondPlayerHand.Add(firstCard);
            }
            else
            {
                firstPlayerHand.RemoveAt(0);
                secondPlayerHand.RemoveAt(0);
            }
            
            // Remove the cards from the front of each player's hand after playing
            firstPlayerHand.RemoveAt(0);
            secondPlayerHand.RemoveAt(0);
        }

        if (firstPlayerHand.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
        }
        else
        {
            Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
        }
        Console.WriteLine("------------------- End of Task 4 --------------------");
    }
}