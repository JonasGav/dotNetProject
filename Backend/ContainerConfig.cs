using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<dotNetProject.ParsedData>().As<IParsedData>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(dotNetProject)))
                .Where(t => t.Namespace.Contains("Time"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }

    }
}
