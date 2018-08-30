using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

            BrowserWindow browser = BrowserWindow.Launch(new Uri("http://localhost:54881/"));


            HtmlHyperlink Continue_lnk = new HtmlHyperlink(browser);
            Continue_lnk.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "registerLink");
            Mouse.Click(Continue_lnk);

            HtmlEdit Email_txtbox = new HtmlEdit(browser);
            Email_txtbox.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "Email");
            Email_txtbox.SetFocus();
            Keyboard.SendKeys("test@gmail.com");

            HtmlEdit Password_txtbox = new HtmlEdit(browser);
            Password_txtbox.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "Password");
            Password_txtbox.SetFocus();
            Keyboard.SendKeys("144685");

            HtmlEdit ConPassword_txtbox = new HtmlEdit(browser);
            ConPassword_txtbox.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "ConfirmPassword");
            ConPassword_txtbox.SetFocus();
            Keyboard.SendKeys("144685");


        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
