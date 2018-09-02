using System.IO;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAutomationSecondExam.Pages.SliderPage;

namespace QaAutomationSecondExam
{
    [TestFixture]
    public class SliderTest
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
        public void DragSliderToThreeTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToThree();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("3");
        }

        [Test]
        public void DragSliderToFourTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToFour();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("4");
        }

        [Test]
        public void DragSliderToFiveTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToFive();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("5");
        }

        [Test]
        public void DragSliderToSixTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToSix();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("6");
        }

        [Test]
        public void DragSliderToSevenTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToSeven();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("7");
        }

        [Test]
        public void DragSliderToEightTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToEight();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("8");
        }

        [Test]
        public void DragSliderToNineTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToNine();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("9");
        }

        [Test]
        public void DragSliderToTenTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToTen();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("10");
        }

        [Test]
        public void DragSliderToOneTest()
        {
            var sliderPage = new SliderPage(driver);

            sliderPage.NavigateTo();
            sliderPage.DragSliderToOne();

            sliderPage.SliderValue.GetAttribute("value").Should().Be("1");
        }
    }
}
