using System;
using System.Threading.Tasks;


namespace R5T.T0020
{
    /// <summary>
    /// Empty marker interface that can be implemented by a type to communicate that that type is an operation.
    /// </summary>
    // Not itself marked with the operation marker attribute to avoid erroneous identification of this interface as an operation.
    public interface IOperation
    {
    }


    #region Actions

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
