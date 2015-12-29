using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceInterface
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMyService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMyService
    {

       [OperationContract]
        string SendMessage(Message _input);

       
    }

    [DataContract]
    public class Message
    {
        /// <summary>
        /// Уровень важности
        /// </summary>
        [DataMember]
        public LevelImportance _level { get; set; }
        /// <summary>
        /// Тип события
        /// </summary>
        [DataMember]
        public TypeEvent _events { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        [DataMember]
        public string _message { get; set; }
    }
    
}
