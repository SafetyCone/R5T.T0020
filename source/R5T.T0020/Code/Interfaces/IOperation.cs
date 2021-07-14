using System;
using System.Threading.Tasks;


namespace R5T.T0020
{
    public interface IOperation
    {
        Task Run();
    }

    #region Actions

    public interface IActionOperation<T>
    {
        Task Run(T value);
    }

    public interface IActionOperation<T1, T2>
    {
        Task Run(T1 value1, T2 value2);
    }

    #endregion


    #region Functions

    public interface IFunctionOperation<T>
    {
        Task<T> Run();
    }

    public interface IFunctionOperation<TIn, TOut>
    {
        Task<TOut> Run(TIn value);
    }

    public interface IFunctionOperation<TIn1, TIn2, TOut>
    {
        Task<TOut> Run(TIn1 value1, TIn2 value2);
    }

    #endregion
}
