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

        public void ProcessQuery()
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
                    matriz3D = new int[dimen, dimen, dimen];
                    ProcessCases(dimen, query);
                    cases--;
                }
                else
                {
                    Console.WriteLine("Enter a valid value");
                }
            }
        }
        public  void ProcessCases(int dimension, int queries)
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
                            matriz3D = _update.UpdateM3(inputQueryList, matriz3D);
                            break;
                        case "QUERY":
                            sum = _query.Sum(inputQueryList, matriz3D);
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
