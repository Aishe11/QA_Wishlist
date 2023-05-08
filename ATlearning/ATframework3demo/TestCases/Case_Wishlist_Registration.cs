using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;


namespace ATframework3demo.TestCases
{
    public class Case_WishList_Registration : CaseCollectionBuilder
    {
        private PortalInfo testPortal;

        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Регистрация", homePage => Registration(homePage)));
            return caseCollection;
        }

        void Registration(PortalHomePage homePage)
        {
            RegistrationInfo NewUser = new RegistrationInfo();
            NewUser.Email = DateTime.Now.ToString("yyyyMMddHHmmss") + "@mail.ru";
            NewUser.Login = DateTime.Now.ToString("yyyyMMddHHmmss");
            NewUser.Password = DateTime.Now.ToString("yyyyMMddHHmmss");



            var RegistrateUser = homePage
                    .AboveMenu
                    // выход с аккаунта
                    .ClickLogout(testPortal)
                    //переключиться на вкладку регистрация
                    .ClickRegistration()
                    // передача данных о пользователе и регистрация(нажатие enter после каждого заполненного поля) 
                    .RegistrateNewUser(NewUser);


            // Проверка что пользователь с данным именем получил доступ к функционалу 

            bool isUserLoginExist = RegistrateUser.IsUserLoginExist(NewUser.Login);
            if (isUserLoginExist == false)
            {
                Log.Error($"Пользователь с именем {NewUser.Login} не был зарегистрирован");
            }
        }
    }
}

