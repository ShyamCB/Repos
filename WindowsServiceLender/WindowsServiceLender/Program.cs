using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceLender
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            Service1 svc = new Service1();
            
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#endif
        }
    }
}
