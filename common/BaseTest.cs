using mark7.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Threading;

namespace mark7.Common
{
    public class BaseTest 
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public TaskPage taskPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Size = new Size(1440, 900);
            driver.Navigate().GoToUrl("http://192.168.1.15:5000/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            loginPage = new LoginPage(driver);
            taskPage = new TaskPage(driver);
        }

        [TearDown]
        public void Finish()
        {
               string path = System.IO.Directory.GetCurrentDirectory() + "/temp_screenshot.png";

	            var ts = (ITakesScreenshot)driver;

	          var screenshot = ts.GetScreenshot();
	    
              screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
	
	          TestContext.AddTestAttachment(path);	


            driver.Close();
        }
    }
}
