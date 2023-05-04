﻿using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects;

namespace ATframework3demo.TestCases
{
    public class Case_WishList_DeletePresent : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Удаление подарка", homePage => DeletePresentInEvent(homePage)));
            return caseCollection;
        }

        void DeletePresentInEvent(PortalHomePage homePage)
        {
            var EventData = new WishlistEvent("Название мероприятия " + DateTime.Now, DateTime.Now.AddDays(7).ToString("dd-MM-yyyy"));
            var PresentData = new WishlistPresent("Название подарка" + DateTime.Now, "Ссылка", "какое-то описание");

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

            var DeletePresent = AddPresent
                .ClickButtonDeletePresent(PresentData.Title);

            // Проверка что подарок появился
            // обновляем страницу
            // ищем элемент с переданным именем

            /*            bool isPresentAppeared = CreateEvent.IsPresentAppeared();
                        if (isPresentAppeared == false)
                        {
                            Log.Error("Пост не появился в ленте новостей");
            */
            /*            }*/


        }
    }
}