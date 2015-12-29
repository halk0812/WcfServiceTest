
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using WcfServiceInterface;
namespace WcfServiceTest.DataWorker
{
    public class Messenger
    {
        public Messenger()
        {
            email_server =  ConfigurationManager.AppSettings["email_server"];
            port = int.Parse(ConfigurationManager.AppSettings["port"]);
            login = ConfigurationManager.AppSettings["login"];
            password = ConfigurationManager.AppSettings["password"];
            email = ConfigurationManager.AppSettings["email"];
        }
        private string email_server = "";
        private int port = 25;
        private string login = "";
        private string password = "";
        private string email = "";

        private void SendEmail(List<Subscriber> clients, string message)
        {
            foreach (var item in clients)
            {
                if (!string.IsNullOrEmpty(item.Email))
                {
                    SmtpClient _smtp = new SmtpClient(email_server, port);
                    _smtp.Credentials = new NetworkCredential(login, password);
                    _smtp.EnableSsl = true;
                    _smtp.Timeout = 10000;
                    _smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    MailMessage _message = new MailMessage();
                    _message.From = new MailAddress(email);
                    _message.To.Add(new MailAddress(item.Email));
                    _message.Subject = "Рассылка";
                    _message.Body = message;
                    try
                    {
                        _smtp.Send(_message);
                    }
                    catch (SmtpException exc)
                    {
                        MyWcfService._logFile.Trace(exc.Message);
                    }
                }
            }


        }
        private void SendSms(List<Subscriber> clients, string message)
        {
            try
            {
                foreach (var item in clients)
                {
                    if (!string.IsNullOrEmpty(item.PhoneNumber))
                    {
                        StreamWriter stream = new StreamWriter(item.PhoneNumber, true);
                        stream.WriteLine(message);
                        stream.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                MyWcfService._logFile.Trace(exc.Message);
            }
        }

        public string SendMessage(List<Subscriber> _listSubscriber,LevelImportance _level,string _message)
        {
            string _result = string.Empty;
            if (_listSubscriber != null || _listSubscriber.Count != 0)
            {
                switch (_level)
                {
                    case LevelImportance.Low:
                        SendEmail(_listSubscriber, _message);
                        break;
                    case LevelImportance.Middle:
                        SendSms(_listSubscriber, _message);
                        break;
                    case LevelImportance.Critical:
                        {
                            SendEmail(_listSubscriber, _message);
                            SendSms(_listSubscriber, _message);
                        }
                        break;
                }
                _result = "OK";
            }
            else
                _result = "Null List";
            return _result;
        }
    }
}