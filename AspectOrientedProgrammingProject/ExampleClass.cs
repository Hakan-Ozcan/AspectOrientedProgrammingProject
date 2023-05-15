using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOrientedProgrammingProject
{
    public class ExampleClass
    {
        [LoggingAspect]
        public void PerformTask()
        {
            Console.WriteLine("Görev gerçekleştiriliyor...");
            throw new Exception("Hata oluştu!");
        }
    }
}
