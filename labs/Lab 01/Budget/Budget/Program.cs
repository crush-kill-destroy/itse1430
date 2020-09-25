/*
 * Matthew Traywick
 * ITSE 1430 
 * Lab 1
 */



using System;


namespace budget
{

    class Program
    {
        static string name;
        static string accountNumber;
        static decimal balance;

        static void Main()
        {
            Console.WriteLine("Welcome to Traywick LCC Bank of Neutropia.");
            Console.WriteLine("We need some basic information before we let you get into our super secure twelve layer nacho encryption.");
            Console.WriteLine("Can you please give us your account name?");
            name = GetName();
            Console.WriteLine($"\nAh, yes. Thank you, {name}. What was your account number again?");
            accountNumber = GetNumber().ToString();
            Console.WriteLine("\nOh. Good. Almost done. Just need help remembering how much money was in your account.");
            balance = GetMoney();

            var menu = true;
            do
            {
                Console.WriteLine($"\n{name}\t  Account: {accountNumber}\t  Balance: {balance:C}\n");
                Console.WriteLine("D) Make a deposit");
                Console.WriteLine("E) Add an expense");
                Console.WriteLine("Q) Quit\n");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "d":
                    case "D":
                    {
                        CheckForMistake("deposit");
                        var deposit = GetNumber();

                        if (deposit == 0)
                            break;

                        balance += deposit;
                        var date = GetDate();
                        var note = GetNote();
                        DisplayAdjustment(deposit, date, note);
                        ShowBalance(balance);
                        break;
                    }

                    case "e":
                    case "E":
                    {
                        while (true)
                        {
                            var expense = AddExpense();

                            if (expense > balance)
                            {
                                Console.WriteLine("You don't have the $$$ for that.");
                                continue;
                            }

                            if (expense == 0)
                                break;

                            else
                            {
                                balance -= expense;
                                var date = GetDate();
                                var note = GetNote();

                                DisplayAdjustment(-expense, date, note);
                                ShowBalance(balance);

                                break;
                            }
                        }
                    }
                    break;

                    case "q":
                    case "Q":
                    {
                        Console.WriteLine("Good. Go. We don't want you at our bank anyways.");
                        menu = false;
                        break;
                    }

                    default: Console.WriteLine("That wasn't an option. Try again."); break;
                }
            } while (menu);

        }



        static string GetName()
        {
            while (true)
            {
                var value = Console.ReadLine();

                if (!(String.IsNullOrEmpty(value)))
                    return value;

                Console.WriteLine("You have to actually enter a name for this to work.");
            }
        }

        static long GetNumber()
        {
            while (true)
            {
                var value = Console.ReadLine();
                var success = Int64.TryParse(value, out long attempt);

                if (success == true && attempt < 0)
                {
                    NegativeNumber();
                    continue;
                } else if (success)
                    return attempt;

                LookingForNumber();
            }
        }

        static decimal GetMoney()
        {
            while (true)
            {
                var value = Console.ReadLine();
                var success = Decimal.TryParse(value, out decimal number);

                if (success == true && number > 0)
                    return number;

                else if (success == true && number < 0)
                {
                    NegativeNumber();
                    continue;
                }

                LookingForNumber();
            }
        }

        static decimal AddExpense()
        {
            while (true)
            {
                CheckForMistake("expense");
                var number = GetMoney();

                if ((balance - number) < 0)
                {
                    Console.WriteLine("That'd be great if you had that much money to begin with.\nBut you don't.\nTry again.");
                    continue;
                }

                return number;
            }

        }


        static string GetDate()
        {
            Console.WriteLine("Would you like to enter this in as today's date? (y/n)");

            while (true)
            {
                var yesNo = Console.ReadLine();

                switch (yesNo)
                {
                    case "y":
                    case "Y": return DateTime.Now.ToString("d");

                    case "n":
                    case "N":
                    {
                        var month;
                        var day;
                        var year;

                        while (true)
                        {
                            month = GetWithinRange("month", 1, 12);
                            day = GetWithinRange("day", 1, 31);
                            year = GetWithinRange("year", 1897, 2020);

                            if (CheckDate(day, month, year) == true)
                                return $"{month}\\{day}\\{year}";

                            var namedMonth = ConvertToMonth(month);
                            Console.WriteLine($"You do realize there is no {namedMonth} {day} in {year}, correct?");
                        }

                    }

                    default: YesOrNo(); break;
                }
            }

        }


        static int GetWithinRange(string date, int min, int max)
        {
            Console.WriteLine($"Give me a {date}");

            while (true)
            {
                var checking = GetNumber();

                if (!(checking >= min && checking <= max))
                    Console.WriteLine($"\nThat isn't a valid {date}, moron.");

                else
                {
                    var conversion = (int)checking;
                    return conversion;
                }
            }
        }

        static bool CheckDate(int day, int month, int year)
        {
            var betweenJanJuly = month <= 7;
            var leapYear = (year % 4) == 0;

            if (betweenJanJuly == true && month % 2 == 0 && day == 31)
                return false;

            else if (betweenJanJuly == false && month %2 == 1)
                return false;

            else if (month == 2 && day > 29)
                return false;

            else if (leapYear == false && month == 2 && day == 29)
                return false;

            return true;
        }

        static string ConvertToMonth(int month)
        {
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "MONTH";
            }
        }

        static string GetNote()
        {
            Console.WriteLine("\nWould you like to add a note? (y/n)");
            do
            {
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "n":
                    case "N":
                    {
                        Console.WriteLine("\nGood. Literally no one cares.");
                        return "";
                    }

                    case "y":
                    case "Y":
                    {
                        Console.WriteLine("\nFine. Give us more stuff to store.");
                        var note = Console.ReadLine();
                        return note;
                    }

                    default: YesOrNo(); break;
                }

            } while (true);
        }
        static void ShowBalance(decimal amount)
        {
            Console.WriteLine($"\nYour new balance is {amount:C}");
        }

        static void DisplayAdjustment(decimal amount, string date, string note)
        {
            Console.WriteLine($"\nTRANSACTION RECORDED!\n{amount:C}\t{date}\t{note}");
        }

        static void YesOrNo()
        {
            Console.WriteLine("You know where the N and Y keys are, correct?");
        }

        static void LookingForNumber()
        {
            Console.WriteLine("I'm looking for a number. You know what numbers are, right?");
        }

        static void NegativeNumber()
        {
            Console.WriteLine("This is a place of positivity. We do not accept negative numbers here.");
        }

        static void CheckForMistake(string option)
        {
            Console.WriteLine($"You picked {option}. If you didn't mean to pick this, just enter 0. Otherwise, give us the amount.");
        }
    }
}
