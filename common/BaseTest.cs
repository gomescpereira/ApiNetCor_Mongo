using mark7.Pages;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace mark7.Common
{
    public class BaseTest 
    {
        public static IConfigurationRoot Configuration { get; set;} 
        public IWebDriver driver;
        public LoginPage loginPage;
        public TaskPage taskPage;

        [SetUp]
        public void SetUp()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("test.json");

             Configuration = builder.Build();

             var browser = Configuration["browser"];
             var urlDefault = Configuration["url"];  

             if (browser.Equals("chrome-headless"))
             {
                var options = new ChromeOptions();
                options.AddArgument("--headless");
                driver = new ChromeDriver(options);
             } 
             
             if (browser.Equals("chrome"))
             {
                driver = new ChromeDriver();
             }
            
            if (browser.Equals("fox"))
            {
                driver = new FirefoxDriver();
            }
            

            driver.Manage().Window.Size = new Size(1440, 900);
            driver.Navigate().GoToUrl(urlDefault);
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
