using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    public static class WebService
    {
        public static string HelloWorldMethod()
        {
            TestWebService.WebService T = new TestWebService.WebService();

            return T.HelloWorld();
        }
    }
}
