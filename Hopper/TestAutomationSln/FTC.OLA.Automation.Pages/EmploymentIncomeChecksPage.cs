﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class EmploymentIncomeChecksPage : IncomeWizardPage
    {
        //public Button No { get; private set; }
        //public Button Yes { get; private set; }
        //public EditField IncomeAmount { get; private set; }
        //public OLAWorkflowDropdown PaymentFrequencyDropdown { get; private set; }
        //public OLAWorkflowDropdown2 DocumentDropdown { get; private set; }
        //public Text YouMustEnterAValueMessage { get; private set; }
        //public Text YouMustSelectAPayFrequencyMessage { get; private set; }
        //public Text ProjectedAnnualIncomeStatement { get; private set; }
        //public Text PleaseSelectAnAnswerMessage { get; private set; }

        public EmploymentIncomeChecksPage(IWebDriver driver)
            : base(driver)
        {
            //No = new Button(Driver, By.CssSelector("#question-form > div:nth-child(1) > div.col.s6.right-align.no-radio-container > div > label"));
            //Yes = new Button(Driver, By.CssSelector("#question-form > div:nth-child(1) > div:nth-child(2) > label"));
            //IncomeAmount = new EditField(Driver, By.Id("income"));
            //PaymentFrequencyDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            //DocumentDropdown = new OLAWorkflowDropdown2(Driver, By.ClassName("select-dropdown"));
            //YouMustEnterAValueMessage = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div:nth-child(1) > income-component > div > form > div.row.section.no-margin-top.input-field.income-errors > div > div > p:nth-child(1)"));
            //YouMustSelectAPayFrequencyMessage = new Text(Driver, By.CssSelector("#question-form > div.row.section.no-margin-bottom.no-margin-top > div:nth-child(1) > income-component > div > form > div.row.section.no-margin-top.input-field.income-errors > div > div > p:nth-child(2)"));
            //ProjectedAnnualIncomeStatement = new Text(Driver, By.XPath("//*[contains(@p, 'Based on what you entered')]"));
            //PleaseSelectAnAnswerMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > shared-income-frequency-container > shared-income-frequency > div > div > div > div"));
        }
    }
}