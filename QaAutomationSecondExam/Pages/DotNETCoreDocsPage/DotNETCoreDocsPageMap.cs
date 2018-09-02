using OpenQA.Selenium;

namespace QaAutomationSecondExam.Pages.DotNETCoreDocsPage
{
    public partial class DotNETCoreDocsPage
    {
        public IWebElement DotNETCoreGuideLink => Driver.FindElement(By.XPath("//*[@id=\"filterResults\"]/ul/li[3]/a"));

        public IWebElement DockerLink => Wait.Until(x => x.FindElement(By.XPath("//*[@id=\"filterResults\"]/ul/li[3]/ul/li[12]/a")));

        public IWebElement IntroductionToDotNETAndDocker => Driver.FindElement(By.XPath("//*[@id=\"filterResults\"]/ul/li[3]/ul/li[12]/ul/li[1]/a"));

        public IWebElement InThisArticle => Driver.FindElement(By.XPath("//*[@id=\"side-doc-outline\"]/h3"));

        public IWebElement PackagingYourAppsLink => Driver.FindElement(By.XPath("//*[@id=\"side-doc-outline\"]/ol/li[1]/a"));

        public IWebElement PackagingYourAppsHeader => Driver.FindElement(By.XPath("//*[@id=\"docker-packaging-your-apps-to-deploy-and-run-anywhere\"]"));

        public IWebElement ScenarioBasedGuidanceLink => Driver.FindElement(By.XPath("//*[@id=\"side-doc-outline\"]/ol/li[2]/a"));

        public IWebElement ScenarioBasedGuidanceHeader => Driver.FindElement(By.XPath("//*[@id=\"scenario-based-guidance\"]"));

        public IWebElement ExploringDockerEcosystemLink => Driver.FindElement(By.XPath("//*[@id=\"side-doc-outline\"]/ol/li[3]/a"));

        public IWebElement ExploringDockerEcosystemHeader => Driver.FindElement(By.XPath("//*[@id=\"exploring-the-rich-docker-development-ecosystem\"]"));

        public IWebElement NextStepsLink => Driver.FindElement(By.XPath("//*[@id=\"side-doc-outline\"]/ol/li[4]/a"));

        public IWebElement NextStepsHeader => Driver.FindElement(By.XPath("//*[@id=\"next-steps\"]"));
    }
}
