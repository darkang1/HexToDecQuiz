using System;

namespace HexToDecQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Hints ***");
            Console.WriteLine("Zero to Fifteen: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F");
            Console.WriteLine("Sixteen to Thirty-Two: 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 1A, 1B, 1C, 1D, 1E, 1F, 20");
            Console.WriteLine("****    ****");
            Console.WriteLine();

            do
            {
                try
                {
                    do
                    {
                        var rand = new Random();

                        int randNum = rand.Next(0, 4099);

                        // Converting hex to integer
                        int int_value = Convert.ToInt32(randNum);
                        int toBase = 16;
                        string hex = Convert.ToString(randNum, toBase).ToUpper();

                        Console.WriteLine($"Hex number is: {hex}");
                        Console.Write("Decimal number is: ");
                        int ans = int.Parse(Console.ReadLine());


                        if (ans == int_value)
                        {
                            Console.WriteLine($"Correct!");
                        }
                        else
                        {
                            Console.WriteLine($"Wrong! The decimal number is: {int_value}");
                        }

                        Console.WriteLine();
                    } while (true);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                Console.WriteLine();

            }while (true);
        }


        }


}
