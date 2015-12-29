using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NLog;
using WcfServiceInterface;
using WcfServiceTest.DataWorker;
namespace WcfServiceTest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MyService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы MyService.svc или MyService.svc.cs в обозревателе решений и начните отладку.
    public class MyWcfService : IMyService
    {
        public static Logger _logFile=LogManager.GetCurrentClassLogger();
        public string SendMessage(Message _input)
        {
            string _result = string.Empty;
            if (_input != null)
            {
                var dataController = new DataController();
                _result=dataController.SendMessage(_input);
            }
            else
            {
                _logFile.Trace("Input message is null!");
                _result = "Error";
            }
            return _result;
        }

    }
}
