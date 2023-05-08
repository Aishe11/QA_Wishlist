using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;


namespace ATframework3demo.TestCases
{
    public class Case_Wishlist_CancelBookingPresentAtOpenEvent : CaseCollectionBuilder
    {
        private PortalInfo testPortal;

        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Удаление брони на подарок", homePage => CancelBookingPresentAtOpenEvent(homePage)));
            return caseCollection;
        }

        void CancelBookingPresentAtOpenEvent(PortalHomePage homePage)
        {
            var EventData = new WishlistEvent("Название мероприятия " + DateTime.Now, DateTime.Now.AddDays(7).ToString("dd-MM-yyyy"));
            var PresentData = new WishlistPresent("Название подарка " + DateTime.Now, "Ссылка", "какое-то описание");
            User user2 = new User();
            user2.Login = "admin2";
            user2.Password = "123456";

            var CreateEvent = homePage
                .EventPage
                // клик на добавить мероприятие
                .ClickButtonAddEvent()
                // переключение фрейма, передача данных и нажатие на Enter, возвращение фрейма
                .AddNewEvent(EventData);

            var AddPresent = CreateEvent
                // Открытие на мероприятия
                .OpenCreatedEvent(EventData.Title)
                // Клик на добавитьь подарок
                .ClickButtonAddPresent()
                // переключение фрейма, передача данных и нажатие на Enter, возвращение фрейма
                .AddPresent(PresentData);

            //отправление приглашение на мероприятие:
            var InviteToEvent = homePage
                .AboveMenu
                //возврат к мероприятию(клик на кнопку мероприятия сверху)
                .OpenEventsPage()
                //клик на пригласить пользователя
                .ClickButtonInviteUser(EventData.Title)
                //ввод логина admin2 +нажатие enter
                .InviteUser(user2.Login)
                //закрыть фрейм(можно заменить обновлением страницы)
                .ClickCloseFrame();

            var ChangeUsers = homePage
                .AboveMenu
                //выход с аккаунта
                .ClickLogout(testPortal)
                //Вход с акаунта admin2
                .ReLogin(user2);

            var AcceptEvent = homePage
                .EventPage
                //клик на "мероприятия друзей"
                .ClickFriendEvent()
                //клик на принять
                .ClickAcceptUserInvitation(EventData.Title);

            var ReservePresent = AcceptEvent
                //клик на подробнее
                .ClickOpenInvitedEvent(EventData.Title)
                //клик на бронировать
                .ClickReservePresent(PresentData.Title)
                //клик на отмена
                .ClickCancelReservePresent(PresentData.Title);



            // Проверка заключается в переходе к вкладке мои подарки и просмотру там данного подарка
            var ReservedPresent = homePage
                .AboveMenu
                .ReservedPresent();

            bool isPresentNotReserved = ReservedPresent.IsPresentNotReserved(PresentData.Title);
            if (isPresentNotReserved == false)
            {
                Log.Error($"Подарок с названием {PresentData.Title} не был удален");

            }
        }
    }
}
