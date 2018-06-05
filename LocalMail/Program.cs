using Newtonsoft.Json;
using Pop3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMail
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MessageData> messageDatas=new List<MessageData>();
            Pop3Client pop3Client = new Pop3Client();
            pop3Client.Connect("smtp.gmail.com", "recent:smtptesteritstep@gmail.com", "167AEq!!",true);
            var messages = pop3Client.List();
            foreach (Pop3Message message in messages)
            {
                pop3Client.Retrieve(message);

                Console.WriteLine("MessageId: {0}", message.MessageId);
                Console.WriteLine("Date: {0}", message.Date);
                Console.WriteLine("From: {0}", message.From);
                Console.WriteLine("To: {0}", message.To);
                Console.WriteLine("Subject: {0}", message.Subject);
                Console.WriteLine("___________________________________");
                Console.WriteLine();
                MessageData data = new MessageData
                {
                    MessageId = message.MessageId,
                    Date = message.Date,
                    From = message.From,
                    Subject = message.Subject,
                    To = message.To
                };
                messageDatas.Add(data);
            }
            JsonConvert.SerializeObject(messageDatas);
            pop3Client.Disconnect();

            Console.ReadLine();
        }
    }
}
