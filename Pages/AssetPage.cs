using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTechnique.Pages
{
    public class HomePage
    {
        private DriverHelper _driverHelper;
        public HomePage(DriverHelper driverHelper) => this._driverHelper = driverHelper;

        public static By AssetName = By.XPath("//");
        public static By SearchField = By.XPath("//");
        public static By Filter = By.XPath("//");

        public bool VerifyAssettName(string AssetName)
        {
            string AlertName = _driverHelper.Driver.FindElement(AssetName).Text;
            return (String.Equals(AssetName, AssetName));
        }
        public bool VerifyRandomTestContent(string Content)
        {
            //A JS Query or a loop can be added to scroll and search for the item with the specific content if the item is not visible
            IList<IWebElement> TestText = _driverHelper.Driver.FindElements(AssetName);
            foreach (IWebElement Element in TestText)
            {
                if (Element.Text.Contains(Content))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchTestContent(string Keyword)
        {
            _driverHelper.Driver.FindElement(SearchField).SendKeys(Keyword);
        }
    }
}
