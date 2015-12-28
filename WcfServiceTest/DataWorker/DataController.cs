using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Configuration;

namespace WcfServiceTest.DataWorker
{
    public class DataController
    {
        private StreamWriter st = null;
        

        private string email_server = "";
        private int port = 25;
        private string login = "";
        private string password = "";
        private string email = "";
        private void WriteToLog(string Text)
        {
            if (st == null)
            {
                st = new StreamWriter("logfile", true);
            }
            st.WriteLine(Text);
            st.Close();
        }
        public DataController()
        {
           email_server = (ConfigurationManager.AppSettings["email_server"]!="")
                                 ? ConfigurationManager.AppSettings["email_server"]
                                 : "";
            port = (ConfigurationManager.AppSettings["port"]!="")
                                 ? int.Parse(ConfigurationManager.AppSettings["port"])
                                 : 25;
            login = (ConfigurationManager.AppSettings["login"]!="")
                                ? ConfigurationManager.AppSettings["login"]
                                : "";
            password = (ConfigurationManager.AppSettings["password"]!="")
                                ? ConfigurationManager.AppSettings["password"]
                                : "";
            email = (ConfigurationManager.AppSettings["email"]!="")
                               ? ConfigurationManager.AppSettings["email"]
                               : "";
        }
        private void SendEmail(List<data> clients, string message)
        {
            foreach (var item in clients)
            {
                if (!string.IsNullOrEmpty(item.email))
                {
                    SmtpClient Smtp = new SmtpClient(email_server, port);
                    Smtp.Credentials = new NetworkCredential(login, password);
                    Smtp.EnableSsl = true;
                    Smtp.Timeout = 10000;
                    Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    MailMessage Message = new MailMessage();
                    Message.From = new MailAddress(email);
                    Message.To.Add(new MailAddress(item.email));
                    Message.Subject = "Рассылка";
                    Message.Body = message;

                    try
                    {
                        Smtp.Send(Message);
                    }
                    catch (SmtpException exc)
                    {
                        WriteToLog(exc.Message);
                    }
                }
            }
            
            
        }
        private void SendSms(List<data> clients, string message)
        {
            try
            {
                foreach (var item in clients)
                {
                    if (!string.IsNullOrEmpty(item.sms))
                    {
                        StreamWriter stream = new StreamWriter(item.sms, true);
                        stream.WriteLine(message);
                        stream.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                WriteToLog(exc.Message);
            }
        }
        public void SendMessage(MessageWcf input)
        {
            try
            {
                var db = new MyDataBaseEntities();
                db.Database.Initialize(false);
                if (input != null)
                {
                    var str = input.events.ToString("G");
                    var test = db.data.Where(n => n.TypeEvent == str).ToList();
                    if (test != null || test.Count != 0)
                    {
                        switch (input.level)
                        {
                            case LevelImportance.Low:
                                SendEmail(test, input.message);
                                break;
                            case LevelImportance.Middle:
                                SendSms(test, input.message);
                                break;
                            case LevelImportance.Critical:
                                {
                                    SendEmail(test, input.message);
                                    SendSms(test, input.message);
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                WriteToLog(exc.Message);
            }
         }

    }
}