using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace SendMessageViaSMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "+33661782612";
            string message = "SSAAAAAAAAAAALUTG";
            SendMessage.SendSMS(number, message);
        }
    }
}

