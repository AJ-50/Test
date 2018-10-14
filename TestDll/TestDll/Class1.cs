using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDll
{
    public class WebService
    {
        public string HelloWorldMethod()
        {
            TestWebService.WebService T = new TestWebService.WebService();

            return T.HelloWorld();
        }
    }
}
