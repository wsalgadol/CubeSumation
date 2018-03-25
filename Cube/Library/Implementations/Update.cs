using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Implementations
{
    public class Update
    {
        public int[,,]  UpdateM3(string[] args, int[,,] matriz)
        {
            try
            {
                var x1 = int.Parse(args[1])-1;
                var y1 = int.Parse(args[2])-1;
                var z1 = int.Parse(args[3])-1;
                var valor = int.Parse(args[4]);
                matriz[x1, y1, z1] = valor;
            }
            catch
            {
                Console.WriteLine("There was an error in the proccess UPDATE");
                Console.ReadLine();
            }
            return matriz;
        }
    }
}
