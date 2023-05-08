using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class GiftFrame
    {
        /// <summary>
        /// Добавление подарка(название, ссылка, описание).Самообновляется после выполнения.Работа с фреймом(переключение на него и обратно)
        /// </summary>
        public EventGiftPage AddPresent(WishlistPresent presentData)
        {
            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame();

            var PresentName = new WebItem("//input[@class='ui-ctl-element' and @name='TITLE']", "Добавление названия подарка");
            PresentName.SendKeys(presentData.Title);

            var PresentLink = new WebItem("//input[@class='ui-ctl-element' and @name='GIFT_LINK']", "Добавление ссылки на подарок");
            PresentLink.SendKeys(presentData.Link);

            var PresentDescription = new WebItem("//textarea[@class='ui-ctl-element' and @name='COMMENT']", "Добавление описания подарка");
            PresentDescription.SendKeys(presentData.Description);

            PresentName.SendKeys(Keys.Enter);

            DriverActions.Refresh();

            DriverActions.SwitchToDefaultContent();

            return new EventGiftPage();

        }

        /// <summary>
        /// Изменение существующего подарка(название, ссылка, описание).Самообновляется после выполнения.
        /// Работа с фреймом(переключение на него и обратно)
        /// </summary>
        public EventGiftPage EditPresent(WishlistPresent presentData)
        {
            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame();

            var PresentName = new WebItem("//input[@class='ui-ctl-element' and @name='TITLE']", "Изменение названия подарка");
            PresentName.Click();
            PresentName.SendKeys(Keys.Control + "a");
            PresentName.SendKeys(Keys.Delete); 
            PresentName.SendKeys(presentData.Title);

            var PresentLink = new WebItem("//input[@class='ui-ctl-element' and @name='GIFT_LINK']", "Добавление ссылки на подарок");
            PresentLink.Click();
            PresentLink.SendKeys(Keys.Control + "a");
            PresentLink.SendKeys(Keys.Delete); 
            PresentLink.SendKeys(presentData.Link);

            var PresentDescription = new WebItem("//textarea[@class='ui-ctl-element' and @name='COMMENT']", "Добавление описания подарка");
            PresentDescription.Click();
            PresentDescription.SendKeys(Keys.Control + "a");
            PresentDescription.SendKeys(Keys.Delete); 
            PresentDescription.SendKeys(presentData.Description);

            PresentName.SendKeys(Keys.Enter);

            DriverActions.Refresh();

            DriverActions.SwitchToDefaultContent();

            return new EventGiftPage();

        }
    }
}