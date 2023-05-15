using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedOrnek2
{
    public class LoggingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                var methodName = invocation.Method.Name;
                var className = invocation.TargetType.Name;

                Console.WriteLine($"Metod başladı: {className}.{methodName}");

                var stopwatch = Stopwatch.StartNew();

                invocation.Proceed(); // Hedef metodu çağır

                stopwatch.Stop();

                Console.WriteLine($"Metod bitti: {className}.{methodName}");
                Console.WriteLine($"Metod süresi: {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
