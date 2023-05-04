using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalEventPage
    {

        public EventFrame ClickButtonAddEvent()
        {
            var menuHeader = new WebItem("//a[@id='form-btn']", "Кнопка Создать мероприятие");
            menuHeader.Click();
            return new EventFrame();
        }


        public EventGiftPage OpenCreatedEvent(string title)
        {
            var menuHeader = new WebItem($"//a[@class='event-title' and text()='{title}']", "Кнопка открытия мероприятия");
            menuHeader.Click();
            return new EventGiftPage();
        }

      }
}