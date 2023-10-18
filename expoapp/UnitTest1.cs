using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace expoapp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeIP = "192.168.1.65";
            var polytechIP = "10.118.0.101";

            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2 API 30"); // name of emulator I'm using for my cookbook app
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.BrowserName, "Expo");
            appiumOptions.AddAdditionalCapability("appTopLevelWindow", $"exp://10.118.0.101:8081");

            AppiumDriver<WindowsElement> driver = new AndroidDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appiumOptions);

            // Your test code here, e.g., click a button
            driver.FindElementById("button-id").Click();

            // Assertions for your test, check the app's state, etc.
            // For example, you can use MSTest's Assert methods:
            // Assert.AreEqual(expected, actual);

            // Quit the driver after the test
            driver.Quit();
        }
    }
}
