using System.IO;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAutomationSecondExam.Pages.DotNETCoreDocsPage;

//Navigate to https://docs.microsoft.com/en-us/dotnet/csharp/
//On left navigation click on .NET Core Guide;
//On nested articles click on Docker;
//On nested articles click on Introduction to.NET and Docker;
//On the right you can see In this Article navigation
//Verify that every link in In this Article scroll to section in the article with the same name

namespace QaAutomationSecondExam
{
    [TestFixture]
    public class DotNETCoreDocsTest
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
            driver.Close();
        }

        [Test]
        public void NavigateToInThisArticle()
        {
            var dotNETCoreDocsPage = new DotNETCoreDocsPage(driver);

            dotNETCoreDocsPage.NavigateTo();
            dotNETCoreDocsPage.GoToInThisArticle();

            dotNETCoreDocsPage.InThisArticle.Text.Contains("In this article").Should().BeTrue();
        }

        [Test]
        public void ValidatePackagingYourAppsLink()
        {
            var dotNETCoreDocsPage = new DotNETCoreDocsPage(driver);

            dotNETCoreDocsPage.NavigateTo();
            dotNETCoreDocsPage.GoToInThisArticle();
            dotNETCoreDocsPage.ClickPackagingYourAppsLink();

            dotNETCoreDocsPage.PackagingYourAppsHeader.Text.Contains("Docker: Packaging your apps to deploy and run anywhere").Should().BeTrue();
        }

        [Test]
        public void ValidateScenarioBasedGuidanceLink()
        {
            var dotNETCoreDocsPage = new DotNETCoreDocsPage(driver);

            dotNETCoreDocsPage.NavigateTo();
            dotNETCoreDocsPage.GoToInThisArticle();
            dotNETCoreDocsPage.ClickScenarioBasedGuidanceLink();

            dotNETCoreDocsPage.ScenarioBasedGuidanceHeader.Text.Contains("Scenario based guidance").Should().BeTrue();
        }

        [Test]
        public void ValidateExploringDockerEcosystemLink()
        {
            var dotNETCoreDocsPage = new DotNETCoreDocsPage(driver);

            dotNETCoreDocsPage.NavigateTo();
            dotNETCoreDocsPage.GoToInThisArticle();
            dotNETCoreDocsPage.ClickExploringDockerEcosystemLink();

            dotNETCoreDocsPage.ExploringDockerEcosystemHeader.Text.Contains("Exploring the rich Docker development ecosystem").Should().BeTrue();
        }

        [Test]
        public void ValidateNextStepsLink()
        {
            var dotNETCoreDocsPage = new DotNETCoreDocsPage(driver);

            dotNETCoreDocsPage.NavigateTo();
            dotNETCoreDocsPage.GoToInThisArticle();
            dotNETCoreDocsPage.ClickNextStepsLink();

            dotNETCoreDocsPage.NextStepsHeader.Text.Contains("Next steps").Should().BeTrue();
        }
    }
}

