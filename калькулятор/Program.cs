using System;


//char[] availableOperations = { '1', '2', '3', '4', '5' };
//bool isNumber = char.TryParse(operationInput, out operationNumber);
//if (availableOperations.Contains(operationNumber))


Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to Lerochkin calculator! Here are the available operations:" + '\n' +
            "  slozhenie (1)" + '\n' +
            "    vichitanie (2)" + '\n' +
            "      umnozhenie (3)" + '\n' +
            "          delenie (4)" + '\n' +
            "To leave the calculator enter 5" + '\n' +
            "Enter the number of the desired operation: ");



        switch (char.Parse(Console.ReadLine()))
        {
            case '1':
                Slozhenie();
                break;

            case '2':
                Vichitanie();
                break;

            case '3':
                Umnozhenie();
                break;

            case '4':
                Delenie();

                break;

            case '5':
                break;

            default:
                Console.WriteLine("Incorrect input, try again");
                break;
        }



        static void Slozhenie()
        {
            Console.WriteLine("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} equals " + (first + second) + ".", first, second);

        }

        static void Vichitanie()
        {
            Console.WriteLine("Enter the umenshaemoe: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the vichitaemoe: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The difference of {0} and {1} equals " + (first - second) + ".", first, second);
        }

        static void Umnozhenie()
        {
            Console.WriteLine("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The proisvedenie of {0} and {1} equals " + (first * second) + ".", first, second);

        }

        static void Delenie()
        {
            Console.WriteLine("Enter the delimoe: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the delitel number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The chastnoe of {0} and {1} equals " + (first / second) + ".", first, second);

        }
    


