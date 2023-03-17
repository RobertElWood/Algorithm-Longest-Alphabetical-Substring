namespace Algorithm_Practice___Longest_Alphabetical_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice Goal #1: Take in a non numeric string from user input. 
            //Determine the longest alphabetical substring present in the user's input, and display it to the console.

            //Pseudo Code Planning:
            //Step 1: Take in the user's input as a variable.
            //Step 2: Create a variable to store the longest substring.
            //Step 3: Create a variable to store the current alphabetical string.
            //Step 4: Iterate through the user's input, looking at one character of the input string at a time.
            //Step 5: If the character to the right of the current character (i) is GREATER than the character before it, then it is alphabetical. It should be concatenated onto the variable from step 3.
            //Step 6: Check the length of the current current string against the longest string. If current is longer, replace the longest string before it is displayed to the user.
            //Step 7: If a character is encountered that isn't alphabetical, wipe the current variable before continuing the iteration. Start over with the next value.
            //Step 7: At the end of the iteration, display the longest substring variable to the user.


            Console.WriteLine("Please enter a non-numeric string to find its longest alphabetical substring: \n");

            string input = Console.ReadLine();

            string longest = $"{input[0]}";

            string current = $"{input[0]}";

            for (int i = 0; i < input.Length-1; i++)
            {
                if(input[i] <= input[i+1])
                {
                    current += input[i + 1];

                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                } 
                else
                {
                    current = "";
                    current += input[i + 1];
                }
               
            }

            Console.WriteLine(longest);
        }
    }
}