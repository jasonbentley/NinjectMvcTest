using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMvcTest.Code
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello, World!";
        }
    }
}