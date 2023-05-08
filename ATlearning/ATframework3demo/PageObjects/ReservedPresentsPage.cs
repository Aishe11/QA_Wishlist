using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class ReservedPresentsPage
    {
        /// <summary>
        /// Проверка наличия зарезирвированного подарка во вкладке "Подарки".
        /// </summary>
        internal bool IsPresentReserved(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[@class='gift-title' and text()='{title}']", "Поиск подарка с заданным заголовком");
            return PresentTitleElement.GetAttribute("title", driver) == title;
        }

        /// <summary>
        /// Проверка отсутствия подарка во вкладке "Подарки".
        /// </summary>
        internal bool IsPresentNotReserved(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[@class='gift-title' and text()='{title}']", "Поиск подарка с заданным заголовком");
            return !PresentTitleElement.WaitWhileElementDisplayed();
        }
    }
}