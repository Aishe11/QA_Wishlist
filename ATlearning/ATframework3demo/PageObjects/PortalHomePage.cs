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
    }
}
