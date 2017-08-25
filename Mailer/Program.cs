using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Mailer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleCmdLine c = new ConsoleCmdLine();
            CmdLineString from = new CmdLineString("from", false, "Recipient email address");
            CmdLineString to = new CmdLineString("to", false, "Sender email address");
            CmdLineString subject = new CmdLineString("subject", false, "Email subject");
            CmdLineString body = new CmdLineString("body", false, "Email body");
            CmdLineString server = new CmdLineString("server", false, "Smtp Server address");
            CmdLineInt port = new CmdLineInt("port", false, "Smtp Server port", 1, 65536);
            CmdLineString user = new CmdLineString("user", false, "Smtp Server username");
            CmdLineString password = new CmdLineString("password", false, "Smtp Server password");

            c.RegisterParameter(from);
            c.RegisterParameter(to);
            c.RegisterParameter(subject);
            c.RegisterParameter(body);
            c.RegisterParameter(server);
            c.RegisterParameter(port);
            c.RegisterParameter(user);
            c.RegisterParameter(password);
            c.Parse(args);

            /**
             * only if server is set
             */
            if (server != "")
            {
                MailMessage mail = new MailMessage(from, to);
                SmtpClient client = new SmtpClient();
                client.Port = port;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential(user, password);
                client.Host = server;
                mail.Subject = subject;
                mail.Body = body;
                client.Send(mail);
            }
        }
    }
}
