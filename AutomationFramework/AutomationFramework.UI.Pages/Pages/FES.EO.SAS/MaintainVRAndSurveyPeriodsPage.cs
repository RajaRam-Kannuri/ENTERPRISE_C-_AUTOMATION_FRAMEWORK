﻿using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class MaintainVRAndSurveyPeriodsPage : BasePage
    {
        public Dropdown VRPeriodSchoolYear { get; private set; }

        public Dropdown VRPeriodId { get; private set; }

        public Dropdown VRType { get; private set; }

        public EditField VRPeriodSchoolCode { get; private set; }

        public EditField VRPeriodStudentAwardId { get; private set; }

        public EditField VRPeriodOpenDate { get; private set; }

        public EditField VRPeriodOpenTime { get; private set; }

        public Dropdown VRPeriodOpenTimeAmPm { get; private set; }

        public EditField VRPeriodCloseDate { get; private set; }

        public EditField VRPeriodCloseTime { get; private set; }

        public Dropdown VRPeriodCloseTimeAmPm { get; private set; }

        public EditField VRPeriodCheckDate { get; private set; }

        public EditField VRPeriodStartingCheckNumber { get; private set; }

        public Button SaveVRPeriodButton { get; private set; }

        public Table SavedVRPeriodsTable { get; private set; }

        public Dropdown SurveyWindowSchoolYear { get; private set; }

        public EditField SurveyWindowOpenDate { get; private set; }

        public EditField SurveyWindowOpenTime { get; private set; }

        public Dropdown SurveyWindowOpenTimeAmPm { get; private set; }

        public EditField SurveyWindowCloseDate { get; private set; }

        public EditField SurveyWindowCloseTime { get; private set; }

        public Dropdown SurveyWindowCloseTimeAmPm { get; private set; }

        public Button SaveSurveyWindowButton { get; private set; }

        public Table SavedSurveyWindowsTable { get; private set; }

        public MaintainVRAndSurveyPeriodsPage(IWebDriver driver)
            : base(driver)
        {
            VRPeriodSchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            VRPeriodId = new Dropdown(driver, By.CssSelector("select[id$=\"ddlVRPeriod\"]"));
            VRType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlVRType\"]"));
            VRPeriodSchoolCode = new EditField(driver, By.CssSelector("input[id$=\"tbSchoolCode\"][id*=\"vrperiodadministration\"]"));
            VRPeriodStudentAwardId = new EditField(driver, By.CssSelector("input[id$=\"tbStudentAwardID\"]"));
            VRPeriodOpenDate = new EditField(driver, By.CssSelector("input[id$=\"tbOpenDate\"]"));
            VRPeriodOpenTime = new EditField(driver, By.CssSelector("input[id$=\"tbOpenTime\"]"));
            VRPeriodOpenTimeAmPm = new Dropdown(driver, By.CssSelector("select[id$=\"ddlOpenDateAMPM\"]"));
            VRPeriodCloseDate = new EditField(driver, By.CssSelector("input[id$=\"tbCloseDate\"]"));
            VRPeriodCloseTime = new EditField(driver, By.CssSelector("input[id$=\"tbCloseTime\"]"));
            VRPeriodCloseTimeAmPm = new Dropdown(driver, By.CssSelector("select[id$=\"ddlCloseDateAMPM\"]"));
            VRPeriodCheckDate = new EditField(driver, By.CssSelector("input[id$=\"tbCheckDate\"]"));
            VRPeriodStartingCheckNumber = new EditField(driver, By.CssSelector("input[id$=\"tbStartingCheckNumber\"]"));
            SaveVRPeriodButton = new Button(driver, By.CssSelector("input[id$=\"btnSave\"]"));
            SavedVRPeriodsTable = new Table(driver, By.CssSelector("table[id$=\"gvVRPeriods\"]"));
            SurveyWindowSchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"ddlGSSchoolYear\"]"));
            SurveyWindowOpenDate = new EditField(driver, By.CssSelector("input[id$=\"tbGSOpenDate\"]"));
            SurveyWindowOpenTime = new EditField(driver, By.CssSelector("input[id$=\"tbGSOpenTime\"]"));
            SurveyWindowOpenTimeAmPm = new Dropdown(driver, By.CssSelector("select[id$=\"ddlGSOpenDateAMPM\"]"));
            SurveyWindowCloseDate = new EditField(driver, By.CssSelector("input[id$=\"tbGSCloseDate\"]"));
            SurveyWindowCloseTime = new EditField(driver, By.CssSelector("input[id$=\"tbGSCloseTime\"]"));
            SurveyWindowCloseTimeAmPm = new Dropdown(driver, By.CssSelector("select[id$=\"ddlGSCloseDateAMPM\"]"));
            SaveSurveyWindowButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveGSPeriod\"]"));
            SavedSurveyWindowsTable = new Table(driver, By.CssSelector("table[id$=\"tblExistingPeriod\"]"));
        }
    }
}
