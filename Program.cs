using System;
using System.Collections.Generic;
using System.Linq;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            var eleCount = Convert.ToInt32(Console.ReadLine());

            List<int> array=Console.ReadLine().TrimEnd().Split(' ').Select(x=>Convert.ToInt32(x)).ToList();
            int matchCount=0;
            for (int i = 0; i < eleCount; i++)
            {

                List<int> indMatch=new List<int>();
                indMatch.Add(array[i]);
                int mulRes=array[i];
                for (int j = 0; j < eleCount; j++)
                {
                    if(i>=j){
                        continue;
                    }
                    indMatch.Add(array[j]);
                    indMatch.Select(x=>mulRes= x*mulRes);
                    if(mulRes%2==1){
                        matchCount++;
                    }
                }
            }
            Console.WriteLine(matchCount);
            Console.ReadLine();
        }
    }
}