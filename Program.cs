using System.Collections.Generic;
using System.Threading;
using System.Dynamic;
using System;
using System.Diagnostics;

namespace SoloLearn
{   
  class Program
  {
      static void Main(string[] args)
      {
        NoNumerals();
        /*string[] words = {"Home", "c#", "Victory"};
        string letter = Console.ReadLine();
        int i = 0;
        

        foreach (var item in words) 
        {
          // if (item.Contains(letter))
          {
            Console.WriteLine(item);
            i++;
          }
        }
          if(i == 0)
          {
            Console.Write("No match");
          }*/
          
        // for (int i = 0; i < letter.Length; i++)
        // {
        //   if (words.Contains(letter))
        //   {
          
        //   }
        // }

        // Settings("James", 12, "Spanish");
        // Settings("Tom", 23);
        // string postText = Console.ReadLine();
        // Post post = new Post();
        // post.Text = postText;
        // post.ShowPost();
        
        // DriversLiscence();
        //PrintA_Z();
        
      }
      
      static void OnlyTheEvens()
      {
        int[] num = new int[3];
        int i = 0;
        int sum = 0;
        for (i = 0; i < 3; i++)
        {
          num[i] = int.Parse(Console.ReadLine());
        }

        foreach (var x in num)
        {
          if (x % 2 == 0)
          {
          sum += x;
          }
        }
          System.Console.WriteLine(sum);
      }
      static void RemoveSymbols()
      {             
        Console.WriteLine("Enter word");
        string word = Console.ReadLine();
        char[] chars = word.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
          char c = chars[i];
          if (char.IsSymbol(c))
          {
            continue;
          } 
          Console.Write(c);
        }
      }

      static void PrintA_Z()
      {
        Console.WriteLine("Print A to Z");
        for (char letter = 'A';letter <= 'Z';letter++)
        Console.WriteLine(letter);
      }

      static void CheerCreator()
      {
        Console.WriteLine("--------Cheer Creator-----------");
        System.Console.WriteLine("Enter yards");
        int yards = int.Parse(Console.ReadLine());
        
        if (yards > 10)
        {
            System.Console.WriteLine("High Five");
        }
        else if (yards < 1)
        {
            System.Console.WriteLine("shh");
        }
        else
        {

        for (int i = 0; i < yards; i++)
        {
            Console.Write("Ra!");
        }
            
        }
        Console.WriteLine();
      }
      
      static void ThatsOdd()
      {
        Console.WriteLine("----Thats odd------");
        Console.WriteLine("Enter number Length");
        int a = int.Parse(Console.ReadLine());
        int[] numbers = new int[a];
        int sum = 0;
        for (int i = 0; i < a; i++)
        {
          Console.WriteLine("Enter number");
          numbers[i] = int.Parse(Console.ReadLine());
          if (numbers[i] % 2 == 0)
        {
          sum += numbers[i];
        }   
        } 
        Console.WriteLine($"The sum of the even no. is {sum}");
      }
      static void Hovercraft()
      {
          Console.WriteLine("-------Hovercraft------");
          decimal costOverCraft = 2000000;
          decimal sellingPrice = 3000000;
          decimal insurance = 1000000;
          Console.WriteLine("Enter number of customers");
          decimal customers = decimal.Parse(Console.ReadLine());
          decimal totalSold = (customers * sellingPrice) - insurance;
          decimal totalCost = costOverCraft * 10;

          if (totalSold > totalCost)
          {
            Console.WriteLine("Profit");   
          }
          else if(totalSold == totalCost)
          {
              Console.WriteLine("Broke Even");
          }
          else
          {
              Console.WriteLine("Loss");
              
          }
          Console.WriteLine();
      }
      static void AverageWordLength()
      {
        Console.WriteLine("------Average word length------");
        Console.WriteLine("Enter sentences: ");
        string input = Console.ReadLine();
        string[] words = input.Split(); 
        System.Console.WriteLine(words.Length + 1);
        Console.WriteLine();
      }

      static int Area(int height, int length)
      {
        int area = height * length;
        return area;
      }

      static void Settings(string name, int age, string lang = "English")
      {
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Language:" + lang);
      }
      
      static string DateUSToEU()
      {
        //----------Convert US Date to EU----------
        Console.WriteLine("Enter date in US format(MM/DD/YYYY)");
        string date = Console.ReadLine();
        string month = date.Substring(0,2);
        string day = date.Substring(3,3);

        string conversion = $"{day}{month}{date.Substring(5,5)}";       
        return conversion;
      }
                                      
      static void Piglatin()
      {
        Console.WriteLine("Input words");
        string words = Console.ReadLine();
        
      }

      static string NoNumerals()
      {
        
        Console.WriteLine("Enter words");
        string words = Console.ReadLine();
        string[] text = words.Split(" ");
        var numerals = new Dictionary<int, string>();
        numerals.Add(1, "one");
        numerals.Add(2, "two");
        
        for (int i = 0; i < text.Length; i++)
        {
            if (int.TryParse(text[i], out int num))
            {
              if (num >= 1 && num <= 2)
              {
                text[i] = numerals[num];
              }
              
            }
        }
        return String.Join(" ", text);  
      }

      static void DriversLiscence()
      {
        string name  = Console.ReadLine();
        int agentNo = int.Parse(Console.ReadLine());
        //string otherNames = Console.ReadLine();
        int position = 0;
        List<string>otherNames = new List<string>(Console.ReadLine().Split(' '));
        otherNames.Add(name);
        otherNames.Sort();
        string[] arr = otherNames.ToArray(); 
        foreach (var s in arr)
        {
          if (s == name)
          {
            position = Array.IndexOf(arr, s) + 1;
          }
        }
        // int timeTaken = 20 * ((1 + position) / agentNo);
        // System.Console.WriteLine(timeTaken);
        
        if (agentNo < position) 
        {
          Console.WriteLine(40);
        }
        else if(agentNo > position)
        {
          System.Console.WriteLine(20);
        }
        // int timeTaken = 0;
        // for (int numRot = position / agentNo; numRot > 0; numRot--)
        // {
        //    timeTaken += agentNo * 20; 
        // }
        

        // if (position % 2 != 0 && position != 1 && agentNo != 1)
        // {
        //   timeTaken += 20;
        // }
        // System.Console.WriteLine(timeTaken);
      }

     

      
  }
}
 