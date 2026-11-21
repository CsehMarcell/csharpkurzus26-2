using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Core;

public static class ReadInput
{
    public static int ReadForMainMenu()
    {
        Console.WriteLine("Choose from the options above.");

        int result = 0;
        bool isNotValid = true;


        while (isNotValid)
        {
            Console.Write("Option: ");
            string? input = Console.ReadLine();
            try
            {
                result = int.Parse(input);
                if (result >= 0 && result <= 5)
                {
                    isNotValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 5.");
                    isNotValid = true;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        }
        return result;
    }

    public static int ReadForInspectInventoryMenu()
    {
        Console.WriteLine("Choose from the options above.");

        int result = 0;
        bool isNotValid = true;



        while (isNotValid)
        {
            Console.Write("Option: ");
            string? input = Console.ReadLine();
            try
            {
                result = int.Parse(input);
                if (result >= 0 && result <= 6)
                {
                    isNotValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 5.");
                    isNotValid = true;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        }
        return result;
    }

    public static int ReadForFilterMenu()
    {
        Console.WriteLine("Choose from the options above.");

        int result = 0;
        bool isNotValid = true;

        while (isNotValid)
        {
            Console.Write("Option: ");
            string? input = Console.ReadLine();
            try
            {
                result = int.Parse(input);
                if (result >= 1 && result <= 2)
                {
                    isNotValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 2.");
                    isNotValid = true;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        return result;
    }
}
