using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceTest.DataWorker
{
    public class SubscriberDataWorker
    {
        public SubscriberDataWorker()
        {

        }
        
        public static List<Subscriber> GetAllSubscriberByEvent(string _typeEvent)
        {
            List<Subscriber> _listSubscriber = new List<Subscriber>();
            try
            {
                var _dataBaseEntities = new MyDataBaseEntities();
                _dataBaseEntities.Database.Initialize(false);
                _listSubscriber = _dataBaseEntities.data.
                    Where(n => n.TypeEvent == _typeEvent).ToList();
                 
            }
            catch (Exception _exc)
            {
                
            }
            return _listSubscriber;
        }
    }
}