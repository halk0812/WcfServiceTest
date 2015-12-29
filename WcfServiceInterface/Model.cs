using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceInterface
{

    /// <summary>
    /// Уровень важности
    /// </summary>
    public enum LevelImportance
    {
        /// <summary>
        /// Отправка по E-Mail
        /// </summary>
        Low =1,
        /// <summary>
        /// Отправка SMS
        /// </summary>
        Middle=2,
        /// <summary>
        /// Отправка E-mail, SMS
        /// </summary>
        Critical=3
    }
    /// <summary>
    /// Канал связи
    /// </summary>
    [Flags]
    public enum TypeChannel
    {
        Email=1,
        SMS=2
    }
    /// <summary>
    /// Тип события
    /// </summary>
    public enum TypeEvent
    {
        PHP=1,
        CSHARP=2,
        ALL=3
    }

   
}