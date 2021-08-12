using System;
using Microsoft.Extensions.DependencyInjection;

namespace EFDI.ApplicationTask.Tests
{
    public abstract class ModuleTestBase
    {
        protected ModuleTestBase()
        {
            BuildServices(null);
        }

        protected ServiceProvider Locator { get; private set; } = null!;

        protected ServiceProvider BuildServices(Action<IServiceCollection>? buildAction)
        {
            var builder = new ServiceCollection().AddLogging();

            buildAction?.Invoke(builder);

            return Locator = builder.BuildServiceProvider();
        }
    }
}