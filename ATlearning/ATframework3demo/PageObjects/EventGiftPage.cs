﻿using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace atFrameWork2.PageObjects
{
    public class EventGiftPage
    {
        public GiftFrame ClickButtonAddPresent()
        {
            var btnAddPresent = new WebItem("//a[@id='form-dtn']", "Кнопка Добавить подарок");
            btnAddPresent.Click();
            return new GiftFrame();
        }

        public GiftFrame ClickButtonEditPresent(string title)
        {

            var btnEditPresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Изменить']", "Кнопка Изменить");
            btnEditPresent.WaitElementDisplayed();
            btnEditPresent.Click();
            return new GiftFrame();
        }


        public EventGiftPage ClickButtonDeletePresent(string title)
        {

            var btnEditPresent = new WebItem($"//div[@class='gift-title' and @title='{title}']/ancestor::div[@class='gift-item']//button[@title='Удалить']", "Кнопка Удалить");
            btnEditPresent.WaitElementDisplayed();
            btnEditPresent.Click();
            return new EventGiftPage();
        }
    }
}