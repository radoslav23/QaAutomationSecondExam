using System.IO;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAutomationSecondExam.Pages.AccordionPage;

namespace QaAutomationSecondExam
{
    [TestFixture]
    public class AccorditionTest
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
        public void VerifyIconsAreNotToggle()
        {
            //verify icons are not toggle when navigate to Customize icons tab
            var accorditionPage = new AccordionPage(driver);

            accorditionPage.NavigateTo();
            accorditionPage.GoToCustomizeIconsTab();

            accorditionPage.SectionFour.GetAttribute("class").Should()
                .Be("ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons");
        }

        [Test]
        public void VerifyIconsAreToggleAfterClickButton()
        {
            //verify icons are toggle after clicking toggle button
            var accorditionPage = new AccordionPage(driver);

            accorditionPage.NavigateTo();
            accorditionPage.GoToCustomizeIconsTab();
            accorditionPage.ClickingToggleIconsButton();

            accorditionPage.SectionFour.GetAttribute("class").Should()
                .NotBe("ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons");
        }
    }
}
