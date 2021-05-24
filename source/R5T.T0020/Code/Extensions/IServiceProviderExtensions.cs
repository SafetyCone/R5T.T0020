using System;
using System.Threading.Tasks;

using R5T.T0020;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class IServiceProviderExtensions
    {
        public static Task Run<TOperation>(this IServiceProvider serviceProvider)
            where TOperation : IOperation
        {
            var operation = serviceProvider.GetRequiredService<TOperation>();

            return operation.Run();
        }
    }
}
