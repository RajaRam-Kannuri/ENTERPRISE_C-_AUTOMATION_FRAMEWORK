﻿using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class AribaSAPDenyCommentsPage : BasePage
    {
        public EditField CommentsTextbox { get; private set; }
        public Button OKButton { get; private set; }

        public AribaSAPDenyCommentsPage(IWebDriver driver)
            : base(driver)
        {
            CommentsTextbox = new EditField(driver, By.Id("_vwptbc"));
            OKButton = new Button(driver, By.Id("_svvsg"));
        }
    }
}
