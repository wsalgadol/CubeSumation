using Library.Contracts;
using Library.Implementations;
using System;

namespace Library.Implementations
{
    public class Process: IProcess
    {
        private static Update _update = new Update();
        private static Query _query = new Query();
        private static int[,,] matriz3D;
        public  void ProcessQuery(int dimension, int queries, int[,,] matriz)
        {
            var cont = 1;
            var sum = 0;
            while (queries > 0)
            {
                Console.Write(cont + ". ");
                var inputQuery = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputQuery.Trim()))
                {
                    var inputQueryList = inputQuery.Split(' ');
                    var queryName = string.IsNullOrEmpty(inputQueryList[0])?"": inputQueryList[0];
                    switch (queryName)
                    {
                        case "UPDATE":
                            matriz3D = _update.UpdateM3(inputQueryList, matriz);
                            break;
                        case "QUERY":
                            sum = _query.Sum(inputQueryList, matriz);
                            break;
                    } 
                    queries--;
                    cont++;
                }
                else
                {
                    Console.WriteLine("Enter any query (UPDATE, QUERY");
                }
            }
        }       


    }
}
