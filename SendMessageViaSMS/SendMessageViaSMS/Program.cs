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
            Console.WriteLine("Insérez le message à envoyer :");
            string message = Console.ReadLine();
            SendMessage.SendSMS(Information.ToNumber, message);
        }
    }
}

