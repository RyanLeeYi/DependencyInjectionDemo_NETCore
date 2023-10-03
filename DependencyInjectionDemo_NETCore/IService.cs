using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo_NETCore
{
    public interface IService
    {
        void SayHello();
    }
    public class ChtService : IService
    {
        public void SayHello()
        {
            Console.WriteLine("哈囉世界！");
        }
    }

    public class EngService : IService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
