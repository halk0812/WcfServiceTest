using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceTest.DataWorker;
namespace WcfServiceTest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MyService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы MyService.svc или MyService.svc.cs в обозревателе решений и начните отладку.
    public class MyService : IMyService
    {
        public void SendMessage(MessageWcf input)
        {
            if (input != null)
            {
                var dataController = new DataController();

                dataController.SendMessage(input);
            }
        }
    }
}
