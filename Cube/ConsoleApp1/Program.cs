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
                process.ProcessQuery();
                 
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
