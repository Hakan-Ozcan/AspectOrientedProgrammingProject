using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgrammingProject
{
    // Günlükleme işlevini gerçekleştiren Aspect sınıfı
    [Serializable]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Metod başladı: " + args.Method.Name);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Metod bitti: " + args.Method.Name);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Hata oluştu: " + args.Exception.Message);
        }
    }
}
