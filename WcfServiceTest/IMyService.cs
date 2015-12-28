using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceTest
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMyService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMyService
    {

       [OperationContract]
        void SendMessage(MessageWcf input);

       
    }

    [DataContract]
    public class MessageWcf
    {
        /// <summary>
        /// Уровень важности
        /// </summary>
        [DataMember]
        public LevelImportance level { get; set; }
        /// <summary>
        /// Тип события
        /// </summary>
        [DataMember]
        public TypeEvent events { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        [DataMember]
        public string message { get; set; }
    }
    
}
