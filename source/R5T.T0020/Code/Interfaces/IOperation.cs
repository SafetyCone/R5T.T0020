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
}
