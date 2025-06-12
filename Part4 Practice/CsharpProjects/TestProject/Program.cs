using System;
using System.ComponentModel.Design;

namespace part4Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            //strings();
            //sortReverse();
            //clearResize();
            //revString();
            //parseID();
            // letter();
            //stringMethods();
            workwithstrings();
        }
        static void workwithstrings()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            const string openSpan = "<span>";
            const string closeSpan = "</span>";
            int quantityStart=input.IndexOf(openSpan)+openSpan.Length;
            int quantityEnd = input.IndexOf(closeSpan);
            int quantityLength=quantityEnd-quantityStart;
            quantity=input.Substring(quantityStart, quantityLength);
            Console.WriteLine(quantity);
            const string tradeSymbol = "&trade";
            const string regSymbol = "&reg";
            output=input.Replace(tradeSymbol, regSymbol);
            const string openDiv = "<div>";
            int divStart=output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);
            const string closeDiv = "</div>";
            int divEnd=output.IndexOf(closeDiv);
            output = output.Remove(divEnd, closeDiv.Length);

            Console.WriteLine(output);
        }
        static void stringMethods()
        {
            string message = "Find what is (inside the parentheses)";
            int openingposition = message.IndexOf('(');
            int closingposition = message.IndexOf(')');
            int length=closingposition-openingposition;
            Console.WriteLine(message.Substring(openingposition+1,length-1));
            message = "(What if) there are (more than) one (set of parentheses)?";
            while(true)
            {
                openingposition = message.IndexOf("(");
                if (openingposition < 0) break;
                closingposition = message.IndexOf(")");
                length = closingposition - openingposition;
                Console.WriteLine(message.Substring(openingposition + 1, length - 1));
                message=message.Substring(closingposition + 1);
            }
            message = "Help (find) the {opening symbols} and after that";
            Console.WriteLine($"Searching THIS Message: {message}");
            char[] openSymbols = { '[', '{', '(' };
            int startPosition = 5;
            int openingPosition=message.IndexOfAny(openSymbols);
            Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");
            openingposition=message.IndexOfAny(openSymbols,startPosition);
            Console.WriteLine($"Found with using startPosition {startPosition}: {message.Substring(openingPosition)}");



        }
        static void letter()
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }
        static void parseID()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] words = orderStream.Split(',');
            Array.Sort(words);
            
           foreach (var word in words) 
            {
                if (word.Length ==4) 
                Console.WriteLine(word);
                else
                    Console.WriteLine(word+ "   error");
            }
        }
        static void revString()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(' ');
            string[] newMessage = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i]=new string(letters);
            }
            string result=string.Join(" ", newMessage);
            Console.WriteLine(result);
            
            

        }
        static void clearResize()
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("");

            Console.WriteLine($"Before: {pallets[0].ToLower()}");
            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"After: {pallets[0].ToLower()}");

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

        }
        static void sortReverse() 
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }
       
       static void strings()
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string message="";
            decimal total = 0m;
            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }
    }
       
}
