using System;
using System.ComponentModel.Design;

namespace part5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.WriteLine("Generating random numbers:");
                //DisplayRandomeNumbers();
                // AdjustMedicineTime();
                // validateIP();
                //fortuneTeller();
                //testScope();
                //genEmail();
                //calBill();
                //convertCurrency();
                // revString();
                //game();
                pettingZooProject();
            }
        }
        static void pettingZooProject()
        {
           string[] pettingZoo = 
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6) 
            {
                RandomizeAnimals(); 
                string[,] group = AssignGroup(groups);
                Console.WriteLine(schoolName);
                PrintGroup(group);
            }

            void RandomizeAnimals() 
            {
                Random random = new Random();

                for (int i = 0; i < pettingZoo.Length; i++) 
                {
                    int r = random.Next(i, pettingZoo.Length);

                    string temp = pettingZoo[r];
                    pettingZoo[r] = pettingZoo[i];
                    pettingZoo[i] = temp;
                }
            }

            string[,] AssignGroup(int groups = 6) 
            {
                string[,] result = new string[groups, pettingZoo.Length/groups];
                int start = 0;

                for (int i = 0; i < groups; i++) 
                {
                    for (int j = 0; j < result.GetLength(1); j++) 
                    {
                        result[i,j] = pettingZoo[start++];
                    }
                }

                return result;
            }

            void PrintGroup(string[,] groups) 
            {
                for (int i = 0; i < groups.GetLength(0); i++) 
                {
                    Console.Write($"Group {i + 1}: ");
                    for (int j = 0; j < groups.GetLength(1); j++) 
                    {
                        Console.Write($"{groups[i,j]}  ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void game()
        {
            Random random = new Random();
            Console.WriteLine("Would you like to play ? (Y/N)");
            if (shouldPlay())
                PlayGame();
            bool shouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }
            void PlayGame()
            {
                var play = true;
                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();
                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(winOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");
                    play = shouldPlay();
                }

            }
            int GetTarget()
            {
                return random.Next(1, 6);
            }
            int RollDice()
            {
                return random.Next(1, 7);
            }
            string winOrLose(int roll, int target)
            {
                if (roll > target)
                    return "You win";
                else
                    return "You lose";
            }

        }
        static void revString()
            {
                string result = "";
                string input = "snake";
                Console.WriteLine(input);
                result = revWord(input);
                Console.WriteLine(result);
                input = "I love Gurpreet";
                Console.WriteLine(input);
                result = "";
                string[] words = input.Split(" ");
                foreach (string word in words)
                    result += revWord(word) + " ";
                Console.WriteLine(result);
            }
        static string revWord(string word)
            {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--)
                    result += word[i];
                return result;
            }
        static void convertCurrency()
        {
            double usd = 23.73;
            int vnd = UsdToVnd(usd);
            Console.WriteLine($"${usd} USD =${vnd} VND");
            int UsdToVnd(double usd)
            {
                int rate = 23500;
                return (int)(rate * usd);
            }
        }

        static void calBill()
        {
            double total = 0;
            double minimumSpend = 30.00;

            double[] items = { 5.97, 3.50, 12.25, 2.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
                Console.WriteLine("in for loop at " + items[i] + " total " + total);
            }

            total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                Console.WriteLine("in get discountedprice " + items[itemIndex]);
                return items[itemIndex] * (1 - discounts[itemIndex]);

            }

            bool TotalMeetsMinimum()
            {
                //Console.WriteLine("yes");
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }
        }


        static void genEmail()
        {
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < external.GetLength(0); i++)
            {
                string first = external[i, 0];
                string last = external[i, 1];

                string abbreviation = first.Substring(0, 2) + last;

                Console.WriteLine(abbreviation + externalDomain);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                string first = corporate[i, 0];
                string last = corporate[i, 1];

                string abbreviation = first.Substring(0, 2) + last;

                Console.WriteLine(abbreviation + "contoso.com");
            }
        }


        static void testScope()
        {
            string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

            DisplayStudents(students);
            DisplayStudents(new string[] { "Robert", "Vanya" });

            void DisplayStudents(string[] students)
            {
                foreach (string student in students)
                {
                    Console.Write($"{student}, ");
                }
                Console.WriteLine();
            }


        }
        static void fortuneTeller()
        {
            Random random = new Random();
            int luck = random.Next(100);

            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }

        }
        static void validateIP()
        {
            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input)
            {
                address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

                ValidateLength();
                ValidateZeroes();
                ValidateRange();

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength()
            {
                validLength = address.Length == 4;
            }
            ;

            void ValidateZeroes()
            {
                foreach (string number in address)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                    {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            }

            void ValidateRange()
            {
                foreach (string number in address)
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }

        }
        static void AdjustMedicineTime()
        {
            int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes();
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

            void DisplayTimes()
            {
                /* Format and display medicine times */
                foreach (int val in times)
                {
                    string time = val.ToString();
                    int len = time.Length;

                    if (len >= 3)
                    {
                        time = time.Insert(len - 2, ":");
                    }
                    else if (len == 2)
                    {
                        time = time.Insert(0, "0:");
                    }
                    else
                    {
                        time = time.Insert(0, "0:0");
                    }

                    Console.Write($"{time} ");
                }
                Console.WriteLine();
            }

            void AdjustTimes()
            {
                /* Adjust the times by adding the difference, keeping the value within 24 hours */
                for (int i = 0; i < times.Length; i++)
                {
                    times[i] = ((times[i] + diff)) % 2400;
                }
            }

        }


        static void DisplayRandomeNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }
            Console.WriteLine();
        }
    }
}
