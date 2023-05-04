using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class ReservedPresentsPage
    {
        internal bool IsPresentReserved(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[@class='gift-title' and text()='{title}']", "Поиск подарка с заданным заголовком");
            return PresentTitleElement.GetAttribute("title", driver) == title;
        }


        internal bool IsPresentNotReserved(string title, IWebDriver driver = default)
        {
            var PresentTitleElement = new WebItem($"//div[@class='gift-title' and text()='{title}']", "Поиск подарка с заданным заголовком");
            return !PresentTitleElement.WaitWhileElementDisplayed();
        }


    }
}