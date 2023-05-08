using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalEventPage
    {
        /// <summary>
        /// Клик на кнопку Добавить мероприятие
        /// </summary>
        public EventFrame ClickButtonAddEvent()
        {
            var btnAddEvent = new WebItem("//a[@id='form-btn']", "Кнопка Создать мероприятие");
            btnAddEvent.Click();
            return new EventFrame();
        }

        /// <summary>
        /// Открытие созданного мероприятия (поиск по переданному названию)
        /// </summary>
        public EventGiftPage OpenCreatedEvent(string title)
        {
            var btnOpenEvent = new WebItem($"//a[@class='event-title' and text()='{title}']", "Кнопка открытия мероприятия");
            btnOpenEvent.Click();
            return new EventGiftPage();
        }

        /// <summary>
        /// Клик на кнопку Пригласить друзей(поиск по переданному названию)
        /// </summary>
        public InviteUserFrame ClickButtonInviteUser(string title)
        {
            var btnInviteUserToEvent = new WebItem($"//a[@class='event-title' and text()='{title}']/ancestor::div[contains(@class, 'event-item')]/descendant::a[@data-role='invite']", "Кнопка приглашения друга");
            btnInviteUserToEvent.Click();
            return new InviteUserFrame();
        }

        /// <summary>
        /// Переключение на вкладку "Мероприятия друзей"
        /// </summary>
        public FriendsEventsPage ClickFriendEvent()
        {
            var btnFriendEvent = new WebItem("//a[text()='Мероприятия друзей']", "Кнопка Мероприятия друзей");
            btnFriendEvent.Click();
            return new FriendsEventsPage();
        }

        /// <summary>
        /// Проверка на регистрацию пользователя. Если переданный логин найден возвращает true
        /// </summary>
        internal bool IsUserLoginExist(string login, IWebDriver driver = default)
        {
            var LoginElement = new WebItem($"//div[@class='wish-login' and text()='{login}']", "Поиск имени зарегистированного пользователя");
            LoginElement.WaitElementDisplayed();
            return LoginElement.GetAttribute("innerHTML", driver) == login;
        }
    }
}