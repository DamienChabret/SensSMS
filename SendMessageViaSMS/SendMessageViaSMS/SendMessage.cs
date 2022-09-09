using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SendMessageViaSMS
{
    /// <summary>
    /// Classe qui permet d'envoyer un message à un numéro de téléphone
    /// </summary>
    public static class SendMessage
    {
        /// <summary>
        /// Méthode qui permet d'envoyer un sms 
        /// </summary>
        /// <param name="number"> Numéro de téléphone de la personne qui va recevoir le sms </param>
        public static void SendSMS(string number, string sms)
        {
            
            var accountSid = "AC9f60af347996b8e8c40d935c1000cb46"; // SID du compte Twilio
            var authToken = "034f4ed26da6c104a7d28683a35ab1ce"; // Token de son compte Twilio
            TwilioClient.Init(accountSid, authToken);

            // Message qui va être envoyé
            var message = MessageResource.Create(
                body: sms,
                from: new Twilio.Types.PhoneNumber("+14013869852"),
                to: new Twilio.Types.PhoneNumber(number));

            Console.WriteLine(message.Body);

        }


    }
}
