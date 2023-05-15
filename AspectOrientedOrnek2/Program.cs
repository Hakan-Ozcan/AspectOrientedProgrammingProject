using Castle.DynamicProxy;
using System;

namespace AspectOrientedOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxyGenerator = new ProxyGenerator();
            var example = proxyGenerator.CreateClassProxy<ExampleClass>(new LoggingAspect());

            example.PerformTask();

            Console.ReadLine();
        }
    }
}
