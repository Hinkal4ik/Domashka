using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmailLib.Services
{
    public class SMSService
    {
        public void Send(string phone, string text)
        {
            // створюємо змінні і використовуємо їх для підключення до мобізону та насилання повідомлення
            string apiKey = "ua8caf175fdc9d94570c06b5a25c0026b75430c83a387df04865a937b6548a281663bf";
            string url = $"https://api.mobizon.ua/service/message/sendsmsmessage?recipient={phone}&text={text}&apiKey={apiKey}";


            // Створення запиту на URL.
            WebRequest request = WebRequest.Create(url);

            // Якщо вимагається сервером, установіть облікові дані.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Отримати відповідь.
            WebResponse response = request.GetResponse();
            // Показати статус.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Отримати потік, що містить вміст, повернутий сервером.
            // Блок використання забезпечує автоматичне закриття потоку.
            using (Stream dataStream = response.GetResponseStream())
            {

                // Відкрийте потік за допомогою StreamReader для легкого доступу.
                StreamReader reader = new StreamReader(dataStream);

                // Прочитати зміст.
                string responseFromServer = reader.ReadToEnd();

                // Показ вмісту.
                Console.WriteLine(responseFromServer);
            }


            // Закрити відповідь.

            response.Close();

        }
    }
}
