using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalAboveMenu
    {

        /// <summary>
        /// Открытие страницы с созданными мероприятиями
        /// </summary>
        public PortalEventPage OpenEventsPage()
        {
            var btnOpenEventPage = new WebItem("//a[@class='header-btn' and text()= 'Мероприятия']", "Кнопка открытия вкладки мероприятия");
            btnOpenEventPage.Click();
            return new PortalEventPage();
        }


        /// <summary>
        /// Выход с акуаунта
        /// </summary>
        public PortalLoginPage ClickLogout(PortalInfo testPortal)
        {
            var btnLogout = new WebItem("//a[@class='wish-logout']", "Кнопка выхода с аккаунта");
            btnLogout.Click();
            return new PortalLoginPage(testPortal); 
        }


        /// <summary>
        /// Открытие страницы с забронированными подарками
        /// </summary>
        public ReservedPresentsPage ReservedPresent()
        {
            var btnReservedPresentPage = new WebItem("//a[@class='header-btn' and text()= 'Подарки']", "Кнопка открытия вкладки Подарки");
            btnReservedPresentPage.Click();
            return new ReservedPresentsPage();
        }
    }
}