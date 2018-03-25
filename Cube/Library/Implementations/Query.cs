using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Implementations
{
    public class Query
    {
        public int Sum(string[] args, int[,,] matriz)
        {
            var sum = 0;
            try
            {
                var x1 = int.Parse(args[1]) - 1;
                var y1 = int.Parse(args[2]) - 1;
                var z1 = int.Parse(args[3]) - 1;
                var x2 = int.Parse(args[4]) - 1;
                var y2 = int.Parse(args[5]) - 1;
                var z2 = int.Parse(args[6]) - 1;

                for(int v1 = x1; v1 <= x2; v1++)
                {
                    for(int v2 = y1; v2 <= y2; v2++)
                    {
                        for(int v3 = z1; v3 <= z2; v3++)
                        {
                            sum += matriz[v1, v2, v3];
                        }
                    }
                }

                Console.WriteLine("Output: "+sum);
            }
            catch
            {
                Console.WriteLine("There was an error in the proccess QUERY");
                Console.ReadLine();
            }
            return sum;
        }
    }
}
