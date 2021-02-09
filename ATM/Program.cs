using System;
using System.Threading;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pin:");
            string pin = Console.ReadLine();
            User user1 = new User
            {
                Name = "Namiq",
                Surname = "Qaracuxurlu",
                CreditCard = new Card
                {
                    PAN = PanGenerator.GeneratePan(),
                    PIN = "2077",
                    CVC = "786",
                    Balance = 1000,
                    ExpireDate = "17.07.2024"
                }
            };
            User user2 = new User
            {
                Name = "Arif",
                Surname = "Bagirli",
                CreditCard = new Card
                {
                    PAN = PanGenerator.GeneratePan(),
                    PIN = "1717",
                    CVC = "131",
                    Balance = 1700,
                    ExpireDate = "17.03.2022"
                }
            };
            User user3 = new User
            {
                Name = "Agamirze",
                Surname = "Memmedov",
                CreditCard = new Card
                {
                    PAN = PanGenerator.GeneratePan(),
                    PIN = "1348",
                    CVC = "364",
                    Balance = 7000,
                    ExpireDate = "01.02.2023"
                }
            };
            User user4 = new User
            {
                Name = "Asif",
                Surname = "Nuriyev",
                CreditCard = new Card
                {
                    PAN = PanGenerator.GeneratePan(),
                    PIN = "9854",
                    CVC = "354",
                    Balance = 2000,
                    ExpireDate = "14.09.2021"
                }
            };
            User user5 = new User
            {
                Name = "Mehemmed",
                Surname = "Deniz",
                CreditCard = new Card
                {
                    PAN = PanGenerator.GeneratePan(),
                    PIN = "1234",
                    CVC = "852",
                    Balance = 100000,
                    ExpireDate = "01.12.2026"
                }
            };
            User[] users = { user1, user2, user3, user4, user5 };
            void startProgram()
            {

                foreach (var item in users)
                {
                    if (item.CreditCard.PIN == pin)
                    {
                        Console.WriteLine($"Welcome {item.Name} {item.Surname}");
                        Console.WriteLine("Show Balance:1");
                        Console.WriteLine("Get Cash:2");
                        Console.WriteLine("Transfer Cash between Cards:3");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {

                            Console.WriteLine("Currency:AZN");
                            Console.WriteLine($"Balance:{item.CreditCard.Balance}");
                            Console.WriteLine("Return:0");
                            string secondChoice = Console.ReadLine();
                            if (secondChoice == "0")
                            {
                                Console.Clear();
                                startProgram();
                            }

                        }
                        if (choice == "2")
                        {
                            OutOfBalance exception = new OutOfBalance("Out of Balance Exception,Unable to get more cash if there is no enough cash in balance");
                            Console.WriteLine("1.10 AZN");
                            Console.WriteLine("2.20 AZN");
                            Console.WriteLine("3.50 AZN");
                            Console.WriteLine("4.100 AZN");
                            Console.WriteLine("5.Enter amount");
                            string choiceThree = Console.ReadLine();
                            if (choiceThree == "1")
                            {
                                if (item.CreditCard.Balance >= 10)
                                {
                                    decimal temp = item.CreditCard.Balance - 10;
                                    item.CreditCard.Balance = temp;
                                    Console.WriteLine("Checking Balance..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Take Money..");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    startProgram();

                                }
                                else
                                {
                                    throw exception;
                                }
                            }
                            if (choiceThree == "2")
                            {
                                if (item.CreditCard.Balance >= 20)
                                {
                                    decimal temp = item.CreditCard.Balance - 20;
                                    item.CreditCard.Balance = temp;
                                    Console.WriteLine("Checking Balance..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Take Money..");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    startProgram();

                                }
                                else
                                {
                                    throw exception;
                                }

                            }
                            if (choiceThree == "3")
                            {
                                if (item.CreditCard.Balance >= 30)
                                {
                                    decimal temp = item.CreditCard.Balance - 30;
                                    item.CreditCard.Balance = temp;
                                    Console.WriteLine("Checking Balance..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Take Money..");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    startProgram();
                                }
                                else
                                {
                                    throw exception;
                                }

                            }
                            if (choiceThree == "4")
                            {
                                if (item.CreditCard.Balance >= 20)
                                {
                                    decimal temp = item.CreditCard.Balance - 20;
                                    item.CreditCard.Balance = temp;
                                    Console.WriteLine("Checking Balance..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Take Money..");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    startProgram();

                                }
                                else
                                {
                                    throw exception;
                                }

                            }
                            if (choiceThree == "5")
                            {
                                string amountTemp = Console.ReadLine();
                                decimal amount = Convert.ToDecimal(amountTemp);
                                if (item.CreditCard.Balance >= amount)
                                {
                                    decimal temp = item.CreditCard.Balance - amount;
                                    item.CreditCard.Balance = temp;
                                    Console.WriteLine("Checking Balance..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Take Money..");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    startProgram();

                                }
                                else
                                {
                                    throw exception;
                                }

                            }


                        }
                        if (choice == "3")
                        {
                            Console.Write("Pin:");
                            string pinForTransfer = Console.ReadLine();
                            foreach (var item2 in users)
                            {
                                if (pinForTransfer == item2.CreditCard.PIN)
                                {
                                    Console.WriteLine("Set Amount of Money To Transfer:");
                                    string amountForTransfer = Console.ReadLine();

                                    int amountOfMoney = Convert.ToInt32(amountForTransfer);
                                    if (amountOfMoney <= item.CreditCard.Balance)
                                    {
                                        decimal temp = item.CreditCard.Balance - amountOfMoney;
                                        item.CreditCard.Balance = temp;
                                        Console.WriteLine("Transfer Started..");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("Transfer Completed..");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        startProgram();
                                    }
                                    else throw new OutOfBalance("Unable to transfer money");
                                }
                            }
                        }
                    }
                }

            }
            try
            {
                startProgram();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
