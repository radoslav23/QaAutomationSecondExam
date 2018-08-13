using System;
using System.Collections.Generic;
using System.Text;
using QaAutomationSecondExam.Pages;
using OpenQA.Selenium;

namespace QaAutomationSecondExam.Pages.SliderPage
{
    public partial class SliderPage : BasePage
    {
        public SliderPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/slider/";
        }

        public void DragSliderToThree()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 40, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToFour()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 140, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToFive()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 240, 0)
                .Release()
                .Build()
                .Perform();
        }


        public void DragSliderToSix()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 300, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToSeven()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 400, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToEight()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 450, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToNine()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 500, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToTen()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, 600, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void DragSliderToOne()
        {
            Action.ClickAndHold(Slider)
                .MoveToElement(TargetElement, -40, 0)
                .Release()
                .Build()
                .Perform();
        }
    }
}
