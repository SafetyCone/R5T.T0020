using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0020;


namespace System
{
    public static class IServiceProviderExtensions
    {
        public static Task Run<TOperation>(this IServiceProvider serviceProvider)
            where TOperation : IOperation
        {
            var operation = serviceProvider.GetRequiredService<TOperation>();

            return operation.Run();
        }

        public static Task Run<TActionOperation, TValue>(this IServiceProvider serviceProvider,
            TValue value)
            where TActionOperation : IActionOperation<TValue>
        {
            var operation = serviceProvider.GetRequiredService<TActionOperation>();

            return operation.Run(value);
        }
    }
}
