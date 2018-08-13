using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace QaAutomationSecondExam.Pages.SliderPage
{
    public partial class SliderPage
    {
        public IWebElement Slider => Driver.FindElement(By.XPath("//*[@id=\"slider-range-max\"]/span"));

        public IWebElement SliderValue => Driver.FindElement(By.Id("amount1"));

        public IWebElement TargetElement => Driver.FindElement(By.XPath("//*[@id=\"slider-range-max\"]/div"));
    }
}
