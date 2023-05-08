using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class EventGiftPage
    {

        /// <summary>
        /// Клик на кнопку "Добавить подарок"
        /// </summary>
        public GiftFrame ClickButtonAddPresent()
        {
            var btnAddPresent = new WebItem("//a[@id='form-dtn']", "Кнопка Добавить подарок");
            btnAddPresent.Click();
            return new GiftFrame();
        }


        /// <summary>
        /// Клик на кнопку "Редактировать подарок" 
        /// </summary>
        public GiftFrame ClickButtonEditPresent(string title)
        {

            var btnEditPresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Изменить']", "Кнопка Изменить");
            btnEditPresent.WaitElementDisplayed();
            btnEditPresent.Click();
            return new GiftFrame();
        }


        /// <summary>
        /// Клик на кнопку "Удалить подарок"
        /// </summary>
        public EventGiftPage ClickButtonDeletePresent(string title)
        {

            var btnDeletePresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Удалить']", "Кнопка Удалить");
            btnDeletePresent.WaitElementDisplayed();
            btnDeletePresent.Click();
            return new EventGiftPage();
        }



        /// <summary>
        /// Проверка наличия подарка с переданным названием. В случае если находит возвращается true.
        /// </summary>
        internal bool IsPresentNameExist(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[contains(text(), '{title}')]", "Поиск подарка с заданным заголовком");
            return PresentTitleElement.GetAttribute("title", driver) == title;

        }

        /// <summary>
        /// Проверка отсутствия подарка с переданным названием. Возвращается true если подарок не найден.
        /// </summary>
        internal bool IsPresentNameNotExist(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[contains(text(), '{title}')]", "Поиск подарка с заданным заголовком");
            return !PresentTitleElement.WaitWhileElementDisplayed();

        }


        /// <summary>
        /// Клик на Бронировать подарок. Бронь подарка с переданным в метод названием
        /// </summary>
        public EventGiftPage ClickReservePresent(string title)
        {
            var btnReservePresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Бронировать']", "Кнопка забронировать подарок");
            btnReservePresent.Click();
            return new EventGiftPage();
        }

        /// <summary>
        /// Клик на Отказаться от брони подарка с переданным в метод названием
        /// </summary>
        internal object ClickCancelReservePresent(string title)
        {
            var btnUneservePresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Отказаться']", "Кнопка Отказаться от подарка");
            btnUneservePresent.Click();
            return new EventGiftPage();
        }
    }
}