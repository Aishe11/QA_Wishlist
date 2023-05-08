using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class PortalRegistrationPage
    {
        public PortalEventPage RegistrateNewUser (RegistrationInfo newUser)
        {
            var emailField = new WebItem("//input[@id='email']", "Поле для ввода почты");
            emailField.SendKeys(newUser.Email);
            emailField.SendKeys(Keys.Enter);

            var loginField = new WebItem("//input[@id='login']", "Поле для ввода логина");
            loginField.SendKeys(newUser.Login);
            loginField.SendKeys(Keys.Enter);


            var pwdField = new WebItem("//input[@id='pass']", "Поле для ввода пароля");
            pwdField.SendKeys(newUser.Password, logInputtedText: false);
            pwdField.SendKeys(Keys.Enter);

            var repeatPwdField = new WebItem("//input[@id='conf-pass']", "Поле для повторного ввода пароля");
            repeatPwdField.SendKeys(newUser.Password, logInputtedText: false);
            repeatPwdField.SendKeys(Keys.Enter);

            return new PortalEventPage();
        }
    }
}