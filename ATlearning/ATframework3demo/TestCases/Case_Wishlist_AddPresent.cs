using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;


namespace ATframework3demo.TestCases
{
    public class Case_WishList_AddPresent : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Добавление подарка", homePage => CreatePresent(homePage)));
            return caseCollection;
        }

        void CreatePresent(PortalHomePage homePage)
        {
            var EventData = new WishlistEvent("Название мероприятия " + DateTime.Now, DateTime.Now.AddDays(7).ToString("dd-MM-yyyy"));
            var PresentData = new WishlistPresent("Название подарка " + DateTime.Now, "Ссылка", "какое-то описание");

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


            // Проверка что подарок появился
            // ищем элемент с переданным именем

            bool isPresentNameExist = AddPresent.IsPresentNameExist(PresentData.Title);
            if (isPresentNameExist == false)
            {
                Log.Error($"Подарка с названием {PresentData.Title} нет");

            }
        }
    }
}
