using System;

class Program {
    static void Main(string[] args) {
        double sum = 0.0;
        double max = Double.MinValue;
        double min = Double.MaxValue;
        int count = 0;

        while (true) {
            Console.Write("Enter a number (type 'End' to finish): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "end") {
                break;
            }

            double number;
            if (!Double.TryParse(input, out number)) {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            sum += number;
            count++;

            if (number > max) {
                max = number;
            }

            if (number < min) {
                min = number;
            }
        }

        Console.WriteLine();

        while (true) {
            Console.Write("Enter the statistical mode ('FindMax', 'FindMin', 'FindMean', or 'End' to exit): ");
            string mode = Console.ReadLine();

            if (mode.ToLower() == "end") {
                break;
            }

            switch (mode.ToLower()) {
                case "findmax":
                    Console.WriteLine("The maximum number is: " + max);
                    break;
                case "findmin":
                    Console.WriteLine("The minimum number is: " + min);
                    break;
                case "findmean":
                    if (count > 0) {
                        double mean = sum / count;
                        Console.WriteLine("The mean is: " + mean);
                    } else {
                        Console.WriteLine("No numbers entered.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid mode.");
                    break;
            }

            Console.WriteLine();
        }
    }
}