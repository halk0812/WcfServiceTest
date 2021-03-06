// <copyright file="MyServiceTest.cs" company="Microsoft">Copyright © Microsoft 2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceTest;

namespace WcfServiceTest.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для MyService</summary>
    [PexClass(typeof(MyWcfService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MyServiceTest
    {
        /// <summary>Тестовая заглушка для SendMessage(MessageWcf)</summary>
        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public void SendMessageTest([PexAssumeUnderTest]MyWcfService target, MessageWcf input)
        {
            target.SendMessage(input);
            // TODO: добавление проверочных утверждений в метод MyServiceTest.SendMessageTest(MyService, MessageWcf)
        }
    }
}
