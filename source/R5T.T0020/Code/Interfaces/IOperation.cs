using System;
using System.Threading.Tasks;


namespace R5T.T0020
{
    public interface IOperation
    {
        Task Run();
    }


    public interface IActionOperation<T>
    {
        Task Run(T value);
    }
}
