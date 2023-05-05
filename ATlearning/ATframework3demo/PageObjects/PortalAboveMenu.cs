using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalAboveMenu
    {
        public PortalEventPage OpenEventsPage()
        {
            var btnOpenEventPage = new WebItem("//a[@class='header-btn' and text()= 'Мероприятия']", "Кнопка открытия вкладки мероприятия");
            btnOpenEventPage.Click();
            return new PortalEventPage();
        }

        public PortalHomePage ClickLogout()
        {
            var btnLogout = new WebItem("//a[@class='wish-logout']", "Кнопка выхода с аккаунта");
            btnLogout.Click();
            return new PortalHomePage();
        }


        public ReservedPresentsPage ReservedPresent()
        {
            var btnReservedPresentPage = new WebItem("//a[@class='header-btn' and text()= 'Подарки']", "Кнопка открытия вкладки Подарки");
            btnReservedPresentPage.Click();
            return new ReservedPresentsPage();
        }
    }
}