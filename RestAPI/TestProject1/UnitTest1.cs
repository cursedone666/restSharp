using System;
using Xunit;
using RestSharp;
using RestAPI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;



namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AuthTest()
        {

            IRestResponse resp = new ApiHelper().PostMethod();
            Cookie cck = CookieHelper.ExtractCookie(resp, "ussat");




            IWebDriver chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Navigate().GoToUrl("https://rozetka.com.ua/");
            chrome.Manage().Cookies.AddCookie(cck);
            
            
            
            

            
            
            
           // ApiHelper sendReq = new ApiHelper();
            //sendReq.ToString();
        }
    }
}
