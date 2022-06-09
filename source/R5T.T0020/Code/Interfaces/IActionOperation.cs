using System;
using System.Threading.Tasks;


namespace R5T.T0020
{
    public interface IActionOperation
    {
        Task Run();
    }

    public interface IActionOperation<T>
    {
        Task Run(T value);
    }

    public interface IActionOperation<T1, T2>
    {
        Task Run(T1 value1, T2 value2);
    }
}
