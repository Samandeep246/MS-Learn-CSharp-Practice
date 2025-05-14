using System;

namespace part3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //oneLinecode();
            //bolleanExpchallenge();
            // twoof7();
            // fourof7();
            //switchcase1();
            //iteration();
            //fizzbuzz();
            //dowhile();
            //codeproject1();
            //codeproject2();
            codeproject3();
        }
        static void codeproject2() 
        {
            string? readResult;
            string roleName = "";
            bool validEntry = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);

            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            readResult = Console.ReadLine();
        }
        static void codeproject1()
        {
            string? readResult;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter an integer value between 5 and 10");

            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    valueEntered = readResult;
                }

                validNumber = int.TryParse(valueEntered, out numValue);

                if (validNumber == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                }
            } while (validNumber == false);

            Console.WriteLine($"Your input value ({numValue}) has been accepted.");

            readResult = Console.ReadLine();
        }
        static void codeproject3()
        {
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }

        static void dowhile()
        { 
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
        }

        static void fizzbuzz()
        { 
            for (int i = 1; i < 26; i++) 
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine(i + "fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine(i + "fizz");
                else if (i % 5 == 0)
                    Console.WriteLine(i + "buzz");
                else
                    Console.WriteLine(i);
            }
        }
        static void iteration()
        { 
            for(int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);   
            }
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
        }
        static void switchcase1() 
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }
        static void switchcase()
        {
            int employeeLevel = 200;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
        static void fourof7()
        {
            int[] numbers = { 4, 8, 15, 16, 23,42 };
            int total = 0; // Initialize total before using it
            bool found = false; // Declare found outside the loop
            foreach (int number in numbers) 
            {
                
                total += number;
                if (number == 42) 
                {
                     found = true;
                }
                if (found)
                    Console.WriteLine("Set contains 42");
            }
            //if (found)
               // Console.WriteLine("Set contains 42");
            Console.WriteLine($"total:{total}");
        }
        static void twoof7()
        {
            bool flag = true;
            if(flag)
            {
                int value = 10;
                Console.WriteLine($" Inside the code block :{value}"); 
            }
        }
        static void oneLinecode()
        {
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);

            string myValue = "a";
            Console.WriteLine(myValue == "a");
            int saleAmount = 1000;
            // int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
            Random coin = new Random();
            Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
        }
        static void bolleanExpchallenge()
        {
            string permission = "Admin|Manager";
            int level = 33;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}