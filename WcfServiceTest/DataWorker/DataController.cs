using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Configuration;
using WcfServiceInterface;

namespace WcfServiceTest.DataWorker
{
    public class DataController
    {
        
       
        public DataController()
        {
           
        }
        
        public string SendMessage(Message _input)
        {
            try
            {
                if (_input != null)
                {
                    var _nameEvent = _input._events.ToString("G");
                    var _subscribers = SubscriberDataWorker.GetAllSubscriberByEvent(_nameEvent);
                    Messenger _messenger = new Messenger();
                    return _messenger.SendMessage(_subscribers, _input._level, _input._message);
                }
                else
                    return "Input is null";
            }
            catch (Exception exc)
            {
                MyWcfService._logFile.Trace(exc.Message);
                return "Error";
            }
         }

    }
}