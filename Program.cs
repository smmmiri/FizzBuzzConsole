string? continueInput;

do
{
    Console.Write("Please enter a number between 1 and 255 to run the game up to that number: ");
    var input = Console.ReadLine();
    Console.WriteLine();

    try
    {
        var number = byte.Parse(input);
        if (number == 0)
        {
            throw new OverflowException();
        }

        PlayFizzBuzz(number);
    }
    catch (OverflowException) when (input.Equals("0"))
    {
        Console.WriteLine("Zero isn't a valid number.");
    }
    catch (FormatException)
    {
        Console.WriteLine("Please enter number correctly.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The entered number must be between 1 and 255.");
    }
    finally
    {
        Console.WriteLine("\nDo you want to continue? (Y/N)");
        continueInput = Console.ReadLine();
        Console.WriteLine();
    }
}
while (continueInput.ToLower() != "n");

static void PlayFizzBuzz(byte number)
{
    for (int i = 1; i < number + 1; i++)
    {
        if (i % 15 == 0)
        {
            Console.Write("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.Write("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.Write("Buzz");
        }
        else
        {
            Console.Write($"{i}");
        }

        if (i == number)
        {
            Console.WriteLine(".");
        }
        else if (i % 10 == 0)
        {
            Console.WriteLine(", ");
        }
        else
        {
            Console.Write(", ");
        }
    }
}
