using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class EventFrame
    {

        public PortalEventPage AddNewEvent(WishlistEvent eventData)
        {

            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame();

            var EventName = new WebItem("//input[@class='ui-ctl-element' and @name='TITLE']", "Добавление названия мероприятия");
            EventName.SendKeys(eventData.Title);

            var EventData = new WebItem("//input[@class='ui-ctl-element' and @name='EVENT_DATE']", "Добавление даты мероприятия");
            EventData.SendKeys(eventData.Date);

            EventName.SendKeys(Keys.Enter);

            DriverActions.SwitchToDefaultContent();

            return new PortalEventPage();
        }
    }
}