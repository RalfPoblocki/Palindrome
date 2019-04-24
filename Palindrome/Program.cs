using System;
using System.Linq;

namespace Palindrome
{
    //Translation Resource File
    //Unit Test Project
    //Prüfung auf alles was nicht Text ist statt nur Nummer (https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp)
    //IsPalindrome Methode (Unit Test möglich)

    public class Program
    {
        static void Main(string[] args)
        {
            do
            {               
                Console.WriteLine("Palindrome eingeben");
                var inputText = Console.ReadLine();
                var inputTextArray = inputText.ToCharArray();

                if (HasDigitOrSpecialCharacter(inputTextArray))
                {
                    Console.WriteLine("Zahlen oder Sonderzeichen sind nicht erlaubt");
                }
                else
                { 
                    if (IsPalindrome(inputText, inputTextArray))
                    {
                        Console.WriteLine("Es ist ein Palindrome"); 
                    }
                    else
                    {
                        Console.WriteLine("Es ist kein Palindrome");  
                    }
                } 
            } while (true);
        }       
        
        public static bool IsPalindrome(string inputText, char[] inputTextArray)
        {
            
            var reverseText = new string(inputTextArray.Reverse().ToArray());
            var returnText = string.Empty;

            var isEqual = inputText.ToLower() == reverseText.ToLower();
            return isEqual; 
        }
        
        public static bool HasDigitOrSpecialCharacter(char[] inputTextArray)
        {
            foreach (var item in inputTextArray)
            {
                if (!char.IsLetter(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
