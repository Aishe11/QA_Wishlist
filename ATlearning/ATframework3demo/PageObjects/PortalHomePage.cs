using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalHomePage
    {

        /// <summary>
        /// Страница со всеми мероприятиями
        /// </summary>
        public PortalEventPage EventPage => new PortalEventPage();


        /// <summary>
        /// Верхнее меню
        /// </summary>
        public PortalAboveMenu AboveMenu => new PortalAboveMenu();
    }
}
