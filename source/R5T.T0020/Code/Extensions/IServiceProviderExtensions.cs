﻿using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0020;


namespace System
{
    public static class IServiceProviderExtensions
    {
        public static Task Run<TOperation>(this IServiceProvider serviceProvider)
            where TOperation : IActionOperation
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

        public static Task Run<TActionOperation, TValue1, TValue2>(this IServiceProvider serviceProvider,
            TValue1 value1,
            TValue2 value2)
            where TActionOperation : IActionOperation<TValue1, TValue2>
        {
            var operation = serviceProvider.GetRequiredService<TActionOperation>();

            return operation.Run(value1, value2);
        }

        public static Task<TOut> Run<TFunctionOperation, TOut>(this IServiceProvider serviceProvider)
            where TFunctionOperation : IFunctionOperation<TOut>
        {
            var operation = serviceProvider.GetRequiredService<TFunctionOperation>();

            return operation.Run();
        }

        public static Task<TOut> Run<TFunctionOperation, TIn, TOut>(this IServiceProvider serviceProvider,
            TIn value)
            where TFunctionOperation : IFunctionOperation<TIn, TOut>
        {
            var operation = serviceProvider.GetRequiredService<TFunctionOperation>();

            return operation.Run(value);
        }
    }
}
