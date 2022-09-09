using System;
using System.Collections.Generic;
using System.Text;
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
            TwilioClient.Init(Information.AccountSid, Information.AuthToken);

            // Message qui va être envoyé
            var message = MessageResource.Create(
                body: sms,
                from: new Twilio.Types.PhoneNumber(Information.FromNumber),
                to: new Twilio.Types.PhoneNumber(number));

            Console.WriteLine(message.Body);

        }
    }
}
