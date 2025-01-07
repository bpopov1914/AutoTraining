namespace L3HomeworkConsoleApp.Lecture3Homework;

public class Lecture3HomeworkTask5
{
    private int cakeWidth;
    private int cakeLength;
    private int numOfPieces;
    private int cakePiecesTaken = 0;
    private string userInput;
    private string stop = "STOP";

    public void TakeCakePieces()
    {
        Console.WriteLine("Task 5: Enter the size of the cake: ");
        Console.WriteLine("Please enter the width of the cake: ");
        userInput = Console.ReadLine();
        bool isWidthInt = int.TryParse(userInput, out cakeWidth);
        Console.WriteLine("Please enter the length of the cake: ");
        userInput = Console.ReadLine();
        bool isLengthInt = int.TryParse(userInput, out cakeLength);
        if (!isWidthInt || !isLengthInt)
        {
            Console.WriteLine("Please enter valid integers for width and length.");
            return;
        }

        if ((cakeWidth >= 1 && cakeWidth <= 1000) && (cakeLength >= 1 && cakeLength <= 1000))
        {
            numOfPieces = cakeLength * cakeWidth;
            Console.WriteLine($"The number of pieces in the cake is: {numOfPieces}");
        }

        while (numOfPieces > 0)
        {
            Console.WriteLine("Please enter how many pieces you want to take: ");
            userInput = Console.ReadLine();
            bool isNumOfPiecesInt = int.TryParse(userInput, out cakePiecesTaken);
            if(isNumOfPiecesInt)
            {
                numOfPieces -= cakePiecesTaken;
                if (numOfPieces <= 0)
                {
                    numOfPieces = Math.Abs(numOfPieces);
                    Console.WriteLine($"No more cake left. You need {numOfPieces} more pieces.");
                    return;
                }
                else
                {
                    Console.WriteLine($"There are {numOfPieces} pieces left in the cake.");
                }
            }
            else if (!isNumOfPiecesInt && userInput == stop)
            {
                Console.WriteLine($"There are {numOfPieces} pieces left.");
                return;
            }
            else
            {
                Console.Write("Please enter valid integers for pieces taken.");
            }
        }
        Console.WriteLine("-------------End of Task 5-------------");
    }
}