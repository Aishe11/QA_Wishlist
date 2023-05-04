using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    public class PortalHomePage
    {

        public PortalEventPage EventPage => new PortalEventPage();

        public PortalAboveMenu AboveMenu => new PortalAboveMenu();





        public PortalHomePage Login(InvitedUser invitedUserInfo)
        {
            var loginField = new WebItem("//input[@id='login']", "Поле для ввода логина");
            loginField.SendKeys(invitedUserInfo.Login);
            Thread.Sleep(1000);
            loginField.SendKeys(Keys.Enter);

            var pwdField = new WebItem("//input[@id='password']", "Поле для ввода пароля");           
            pwdField.SendKeys(invitedUserInfo.Password, logInputtedText: false);
            Thread.Sleep(1000);
            pwdField.SendKeys(Keys.Enter);

            return new PortalHomePage();
        }
    }
}
