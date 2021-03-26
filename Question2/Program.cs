using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question2
{
    class Program
    {
        // Question 2:
        // Find every position in an input string where a letter is succeeded by itself
        // Please note that space is not a letter, each time a duplicated letter is found, write this letter plus it's position into the duplicate list
        
        /*
         * Example if data is "letter" position of t is 3 and value is tt
        */
            
        // NOTE: Please include comments in your code
        
        static void Main(string[] args)
        {
             const string data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commmodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            var duplicates = GetDuplicatedCharacters(data);
            Console.ReadLine();
        }

        private static List<StringPosition> GetDuplicatedCharacters(string data)
           
        {

        
            // Write your code here
            List <StringPosition> test = new List<StringPosition>(); // Create List
            int pos = 0;                                            // Set Variables
            int i = 0;

            for (int j = i + 1; j < data.Length; j++)               // Loop through data parameter
            {

                if (char.IsLetter(data[i]) && char.IsLetter(data[j])) // Check if character is a letter
                {
                    if (data[i] == data[j])                            // check if position @i = position @j (if first letter matches next letter)
                    {
                        pos = i;
                        StringPosition obj = new StringPosition();     //create instance of class
                        obj.DuplicatedPosition = pos + 1;              // assign object values
                        obj.DuplicatedLetter = (data[i]);               // Add to list
                        test.Add(obj);
                    }
               
                }
                i++;

            }
           
            for (int n = 0; n<test.Count; n++)  // For Every value , return output
            {
                StringPosition a = test[n];
                Console.WriteLine("Duplicate Value = {0}, Duplicate Letter = {1}",a.DuplicatedPosition,a.DuplicatedLetter);
            }
            return test;

        }
    }
}
