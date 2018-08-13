using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace QaAutomationSecondExam.Pages.AutomateThePlanetPage
{
    public partial class AutomateThePlanetPage : BasePage
    {
        public AutomateThePlanetPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "https://docs.microsoft.com/en-us/dotnet/csharp/";
        }

        public void GoToInThisArticle()
        {
            DotNETCoreGuideLink.Click();
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", DockerLink);
            je.ExecuteScript("arguments[0].click();", DockerLink);
            IntroductionToDotNETAndDocker.Click();
        }

        public void ClickPackagingYourAppsLink()
        {
            PackagingYourAppsLink.Click();
        }

        public void ClickScenarioBasedGuidanceLink()
        {
            ScenarioBasedGuidanceLink.Click();
        }

        public void ClickExploringDockerEcosystemLink()
        {
            ExploringDockerEcosystemLink.Click();
        }

        public void ClickNextStepsLink()
        {
            NextStepsLink.Click();
        }
    }
}
