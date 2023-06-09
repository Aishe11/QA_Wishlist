﻿using atFrameWork2.SeleniumFramework;

namespace atFrameWork2.PageObjects
{
    public class FriendsEventsPage
    {
        /// <summary>
        /// Клик на Принять приглашение. Поиск по переданному названию.
        /// </summary>
        public FriendsEventsPage ClickAcceptUserInvitation(string title)
        {            
            var btnAcceptUserInvitation = new WebItem($"//a[@class='event-title' and text()='{title}']/ancestor::div[contains(@class, 'event-main-info')]/descendant::a[contains(@id, 'form-btn-delete') and contains(@href, 'action=accept')]", "Кнопка приглашения друга");
            btnAcceptUserInvitation.Click();
            return new FriendsEventsPage();
        }

        /// <summary>
        /// Открытие события на которое пользователь был приглашен. Поиск по переданному названию.
        /// </summary>
        public EventGiftPage ClickOpenInvitedEvent(string title)
        {
            var btnOpenInvitedEvent = new WebItem($"//a[@class='event-title' and text()='{title}']", "Кнопка открытия мероприятия");
            btnOpenInvitedEvent.Click();
            return new EventGiftPage();
        }
    }
}