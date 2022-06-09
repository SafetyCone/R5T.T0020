using System;
using System.Threading.Tasks;


namespace R5T.T0020
{
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
}
