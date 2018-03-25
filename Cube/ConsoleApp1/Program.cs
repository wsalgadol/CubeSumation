using Library.Contracts;
using Library.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public class Solution
    {
        static void Main(string[] args)
        {
            IProcess process = new Process();
            try
            {
                int cases = int.Parse(Console.ReadLine());
                while (cases > 0)
                {
                    var input2 = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input2.Trim()))
                    {
                        var input2List = input2.Split(' ');
                        int dimen = int.Parse(input2List[0]);
                        int query = int.Parse(input2List[1]);
                        var matriz3D = new int[dimen, dimen, dimen];
                        process.ProcessQuery(dimen, query, matriz3D);
                        cases--;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid value");
                    }
                }
                Console.WriteLine("Finish Proccess, Press Enter");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Value not found, press Enter for finish");
                Console.ReadLine();
                return;
            }
        }

        
    }
}
