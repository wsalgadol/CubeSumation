using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Contracts
{
    public interface IProcess
    {
       void ProcessQuery(int dimension, int queries, int[,,] matriz);
    }
}
