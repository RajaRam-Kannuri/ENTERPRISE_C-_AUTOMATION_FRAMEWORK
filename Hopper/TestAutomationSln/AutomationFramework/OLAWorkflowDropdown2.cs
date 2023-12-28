﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    [KeywordTesting]
    public class OLAWorkflowDropdown2 : WebElement
    {
        public OLAWorkflowDropdown2(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

		[KeywordTestingOLAWorkflowDropdown2]
        public void SelectByPartialText(String item)
        {
            if (item == null) return;

            List<IWebElement> lineItems = LocateAll();

            IReadOnlyCollection<IWebElement> options = null;

            lineItems[2].Click();

            Thread.Sleep(StringConstants.DropDownWaitTime);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(StringConstants.WebdriverWaitTime));

            IWebElement list = lineItems[3];

            options = list.FindElements(By.TagName("li"));

            foreach (var option in options)
            {
                if (option.Text.Contains(item))
                {
                    option.Click();
                    break;
                }
            }
        }
    }
}
