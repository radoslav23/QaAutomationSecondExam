using System.IO;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAutomationSecondExam.Pages.AutomateThePlanetPage;

namespace QaAutomationSecondExam
{
    [TestFixture]
    public class AutomateThePlanetTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [TearDown]
        public void EndTest()
        {
            //take a screenshot in case of test failure
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotLocation = Path.GetFullPath(@"..\..\..\Screenshots\");
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotLocation + testName + ".png", ScreenshotImageFormat.Png);
            }
            //driver.Close();
        }

        [Test]
        public void NavigateToInThisArticle()
        {
            var automateThePlanetPage = new AutomateThePlanetPage(driver);

            automateThePlanetPage.NavigateTo();
            automateThePlanetPage.GoToInThisArticle();

            automateThePlanetPage.InThisArticle.Text.Contains("In this article").Should().BeTrue();
        }

        [Test]
        public void ValidatePackagingYourAppsLink()
        {
            var automateThePlanetPage = new AutomateThePlanetPage(driver);

            automateThePlanetPage.NavigateTo();
            automateThePlanetPage.GoToInThisArticle();
            automateThePlanetPage.ClickPackagingYourAppsLink();

            automateThePlanetPage.PackagingYourAppsHeader.Text.Contains("Docker: Packaging your apps to deploy and run anywhere").Should().BeTrue();
        }

        [Test]
        public void ValidateScenarioBasedGuidanceLink()
        {
            var automateThePlanetPage = new AutomateThePlanetPage(driver);

            automateThePlanetPage.NavigateTo();
            automateThePlanetPage.GoToInThisArticle();
            automateThePlanetPage.ClickScenarioBasedGuidanceLink();

            automateThePlanetPage.ScenarioBasedGuidanceHeader.Text.Contains("Scenario based guidance").Should().BeTrue();
        }

        [Test]
        public void ValidateExploringDockerEcosystemLink()
        {
            var automateThePlanetPage = new AutomateThePlanetPage(driver);

            automateThePlanetPage.NavigateTo();
            automateThePlanetPage.GoToInThisArticle();
            automateThePlanetPage.ClickExploringDockerEcosystemLink();

            automateThePlanetPage.ExploringDockerEcosystemHeader.Text.Contains("Exploring the rich Docker development ecosystem").Should().BeTrue();
        }

        [Test]
        public void ValidateNextStepsLink()
        {
            var automateThePlanetPage = new AutomateThePlanetPage(driver);

            automateThePlanetPage.NavigateTo();
            automateThePlanetPage.GoToInThisArticle();
            automateThePlanetPage.ClickNextStepsLink();

            automateThePlanetPage.NextStepsHeader.Text.Contains("Next steps").Should().BeTrue();
        }
    }
}

