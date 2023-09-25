using System;

/// Parses data from input and outputs only numberic values

namespace ArrayParsing.App
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Parsing Data");
            bool continueParsing = true;

            /// While loop to just make sure user can stull input without having to restart code

            while (continueParsing) {

                /// Asking for user inout and weither or not user wants to input more

                Console.Write("Enter delimited values (EX: 1,2,3): ");
                string input = Console.ReadLine();

                Console.Write("Enter the delimiter (EX: ,): ");
                char delimiter = Console.ReadKey().KeyChar;

                string result = ParseInput(input, delimiter);
                Console.WriteLine($"\n Final result: {result}");

                Console.Write("Do you want to parse another input? (Y/N): ");
                char response = Console.ReadKey().KeyChar;
                continueParsing = (response == 'y' || response == 'Y');

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Parses the input string, validates numeric values, and returns a comma-delimited string of valid numbers.
        /// </summary>
        /// <param name="input">The input string containing delimited values.</param>
        /// <param name="delimiter">The delimiter character.</param>
        /// <returns>A comma-delimited string of valid numeric values.</returns>
        static string ParseInput(string input, char delimiter) {
            string[] values = input.Split(delimiter);
            string result = "";

            foreach (string value in values) {
                if (IsNumeric(value)) {
                    if (!string.IsNullOrEmpty(result))
                        result += ",";
                    result += value;
                }
            }

            return result;
        }

        /// <summary>
        /// Checks if a string represents a numeric value such as 1,2,3,4 etc.
        /// </summary>
        /// <param name="value">The string to check.</param>
        /// <returns>True if the string is numeric, false otherwise.</returns>
        static bool IsNumeric(string value) {
            bool isNumeric = double.TryParse(value, out _);
            return isNumeric;
        }
    }
}
