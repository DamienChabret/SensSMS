using System;
using System.Collections.Generic;
using System.Text;

namespace SendMessageViaSMS
{
    public static class Information
    {
        private static string fromNumber = "+14013869852";
        /// <summary>
        /// Numéro qui envoie le message
        /// </summary>
        public static string FromNumber
        {
            get => fromNumber;
            set => fromNumber = value;
        }

        private static string toNumber = "+33661782612";
        /// <summary>
        /// Numéro a qui va être envoyé
        /// </summary>
        public static string ToNumber
        {
            get => toNumber;
            set => toNumber = value;
        }

        private static string accountSid = "AC9f60af347996b8e8c40d935c1000cb46";
        /// <summary>
        /// SID Account 
        /// </summary>
        public static string AccountSid
        {
            get => accountSid;
            set => accountSid = value;
        }

        private static string authToken = "034f4ed26da6c104a7d28683a35ab1ce";
        /// <summary>
        /// Token d'authenfication
        /// </summary>
        public static string AuthToken
        {
            get => authToken;
            set => authToken = value;
        }
    }
}
