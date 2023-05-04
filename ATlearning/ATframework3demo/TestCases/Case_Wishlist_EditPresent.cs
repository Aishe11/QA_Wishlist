using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;


namespace ATframework3demo.TestCases
{
    public class Case_WishList_EditPresent : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Изменение подарка", homePage => MadeEventWithEditedPresent(homePage)));
            return caseCollection;
        }

        void MadeEventWithEditedPresent(PortalHomePage homePage)
        {
            var EventData = new WishlistEvent("Название мероприятия " + DateTime.Now, DateTime.Now.AddDays(7).ToString("dd-MM-yyyy"));
            var PresentData = new WishlistPresent("Название подарка " + DateTime.Now, "Ссылка", "Какое-то описание");
            var EditedPresentData = new WishlistPresent("Измененное название подарка " + DateTime.Now, "Измененная ссылка", "Какое-то измененное описание");

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

            var EditPresent = AddPresent
                //клик на изменить подарок
                .ClickButtonEditPresent(PresentData.Title)
                //удаление предыдущих данных и внесение новых
                .EditPresent(EditedPresentData);

            // Проверка что подарок появился
            // обновляем страницу
            // ищем элемент с переданным именем

            bool isPresentNameExist = EditPresent.IsPresentNameExist(EditedPresentData.Title);
            if (isPresentNameExist == false)
            {
                Log.Error($"Подарка с названием {EditedPresentData.Title} нет");

            }


        }
    }
}
