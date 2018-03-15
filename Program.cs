﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GreenvilleRevenueCh6
{
    class Program
    {
        static void Main(string[] args)
        {
            int FEE = 25;
            int contestantsThisYear;
            int contestantsLastYear;
            int expectedRevenue;
            {

            }

            Write("Enter the number of contestants this year between 0-30: ");
            contestantsThisYear = Convert.ToInt32(ReadLine());

            while (contestantsThisYear < 0 || contestantsThisYear > 30)
            {
                Write("That number is invalid. Please enter a number between 0-30: ");
                contestantsThisYear = Convert.ToInt32(ReadLine());
            }

            string[] contestants = new string[contestantsThisYear];
            string[] codes = new string[contestantsThisYear];
            string codesFirst = "";
            int singCount = 0;
            int danceCount = 0;
            int magicCount = 0;
            int otherCount = 0;
            string sentinal = "";
            string codeInquiry = "";

            for (int x = 0; x < contestants.Length; x++)
            {
                Write("Enter the first name of contestant #{0}: ", x + 1);
                contestants[x] = ReadLine();
                Write("Enter the talent code for contestant #{0}: ", x + 1);
                codesFirst = ReadLine();
               // while (codesFirst != "S" || codesFirst != "s" || codesFirst != "D" || codesFirst != "d" || codesFirst != "M" || codesFirst != "m" || codesFirst != "O" || codesFirst != "o")
               // {
                  //  Write("That code is invalid. Please enter 'S' for singing, 'D' for dancing, 'M' for magic or 'O' for other: ");
                   // codesFirst = ReadLine();
                //}
                codes[x] = codesFirst;
            }
            WriteLine(contestants.Length);

            for (int x = 0; x < contestants.Length; x++)
            {
                if (codes[x] == "S" || codes[x] == "s")
                {
                    singCount++;
                }
                else if(codes[x] == "D" || codes[x] == "d")
                {
                    danceCount++;
                }
                else if(codes[x] == "M" || codes[x] == "m")
                {
                    magicCount++;
                }
                else if(codes[x] == "O" || codes[x] == "o")
                {
                    otherCount++;
                }
            }

            WriteLine("Number contestants for singing is: {0}", singCount);
            WriteLine("Number contestants for dancing is: {0}", danceCount);
            WriteLine("Number contestants for magic is: {0}", magicCount);
            WriteLine("Number contestants for other is: {0}", otherCount);

            while(sentinal != "X")
            {
                Write("Enter a talent code to display contestants for that group: ");
                codeInquiry = ReadLine();
                sentinal = codeInquiry;
            
                for(int x = 0; x < contestants.Length; x++)
                {
                    if(codeInquiry == "S" || codeInquiry == "s" && codeInquiry == codes[x])
                    {
                        WriteLine("Singing contestant: {0}", contestants[x]);
                    }
                    else if(codeInquiry == "D" || codeInquiry == "d" && codeInquiry == codes[x])
                    {
                        WriteLine("Dancing contestant: {0}", contestants[x]);
                    }
                    else if(codeInquiry == "M" || codeInquiry == "m" && codeInquiry == codes[x])
                    {
                        WriteLine("Magic contestant: {0}", contestants[x]);
                    }
                    else if(codeInquiry == "O" || codeInquiry == "o" && codeInquiry == codes[x])
                    {
                        WriteLine("Other contestant: {0}", contestants[x]);
                    }
                    else
                    {
                        WriteLine("Code not valid");
                    }
                }
            }
                WriteLine("Enter the number of contestants from last year between 0-30: ");
            contestantsLastYear = Convert.ToInt32(ReadLine());

            while (contestantsLastYear < 0 || contestantsLastYear > 30)
            {
                WriteLine("That number is invalid. Please enter a number between 0-30: ");
                contestantsLastYear = Convert.ToInt32(ReadLine());
            }

            expectedRevenue = contestantsThisYear * FEE;

            WriteLine(expectedRevenue.ToString("C"));
            if (contestantsThisYear > (contestantsLastYear * 2))
            {
                WriteLine("The competition is more than twice as big this year! ");
            }
            else if ((contestantsThisYear <= (contestantsLastYear * 2)) && (contestantsThisYear > contestantsLastYear))
            {
                WriteLine("The competition is bigger than ever!");
            }
            else
                WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}
