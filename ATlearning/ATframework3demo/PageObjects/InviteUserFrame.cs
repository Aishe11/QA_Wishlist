using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class InviteUserFrame
    {
        public InviteUserFrame InviteUser(string login)
        {
            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame();

            var InvitedUserLogin = new WebItem("//input[@class='ui-ctl-element' and @name='LOGIN']", "Добавление логина приглашаемого пользователя");
            InvitedUserLogin.SendKeys(login);

            InvitedUserLogin.SendKeys(Keys.Enter);

            return new InviteUserFrame();
        }

        public PortalEventPage ClickCloseFrame()
        {

            DriverActions.SwitchToDefaultContent();

            var btnCloseFrame = new WebItem("//div[@title='Закрыть']", "Кнопка закрыть фрейм");
            btnCloseFrame.WaitElementDisplayed();
            btnCloseFrame.Click();

            return new PortalEventPage();
        }
    }
}