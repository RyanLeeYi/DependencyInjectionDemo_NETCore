using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo_NETCore
{
    public class App
    {
        private readonly IService _service;

        public App(IService service)
        {
            _service = service;
        }

        public void Run()
        {
            _service.SayHello();
        }
    }
}
