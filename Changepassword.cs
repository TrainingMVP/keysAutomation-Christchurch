using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class Changepassword
    {
        internal Changepassword()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);

        public void ChangePassword()
        {
            
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
                //Skip
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                Thread.Sleep(1000);

                //Profile icon
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //Change password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //Current Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Current PWD"));
                Thread.Sleep(1000);

                //New Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "New PWD"));
                Thread.Sleep(1000);

                //Confirm new Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Confirm new PWD"));
                Thread.Sleep(1000);

                //Change Password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Thread.Sleep(1000);

                //Profile icon
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //Logout
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
                Thread.Sleep(1000);

                //Username
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "Username"));
                Thread.Sleep(1000);

                //Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "password"));
                Thread.Sleep(1000);

                //login button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));
                Thread.Sleep(1000);
            try
            {


                Assert.AreEqual("Dashboard", Driver.driver.Title);
                //screenshots
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Pass, "Password is changed successfully"+ Base.test.AddScreenCapture(screenShotPath));

               
            }
            catch (Exception e)
            {
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Fail, "Change Password test failed"+ Base.test.AddScreenCapture(screenShotPath));
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }
        }
        internal void Existing_pwd()
        {
            
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
                //Skip
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                Thread.Sleep(1000);

                //Profile icon
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //Change password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //Current Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(3, "Current PWD"));
                Thread.Sleep(1000);

                //New Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(3, "New PWD"));
                Thread.Sleep(1000);

                //Confirm new Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(3, "Confirm new PWD"));
                Thread.Sleep(1000);

                //Change Password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Thread.Sleep(1000);
            try
            {

                IWebElement errortext = Driver.driver.FindElement(By.Id("NewPasswordTxt-error"));
                string msg = errortext.Text;
                Assert.AreEqual("* New Password must differ from old password.", msg);
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Pass, "Unable to change password as the new password and old password values are same, the test passed"+ Base.test.AddScreenCapture(screenShotPath));


            }
            catch (Exception e)
            {
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Fail, "Existing Password test failed"+Base.test.AddScreenCapture(screenShotPath));
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }
        }
            internal void Confirm_pwd()
        {
            
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
                //Skip
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                Thread.Sleep(1000);

                //Profile icon
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //Change password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //Current Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(4, "Current PWD"));
                Thread.Sleep(1000);

                //New Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(4, "New PWD"));
                Thread.Sleep(1000);

                //Confirm new Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(4, "Confirm new PWD"));
                Thread.Sleep(1000);

                //Change Password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Thread.Sleep(1000);
            try
            {

                IWebElement errortext = Driver.driver.FindElement(By.Id("ConfirmPasswordTxt-error"));
                string msg = errortext.Text;
                Assert.AreEqual("* The new password and confirmation password do not match.", msg);
                //Screenshot
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Pass, "Unable to change the password as the new password and the confirmation password do not match, the test passed" + Base.test.AddScreenCapture(screenShotPath));
                

            }
            catch (Exception e)
            {
                //Screenshot
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Fail, "Confirmation Password test failed" + Base.test.AddScreenCapture(screenShotPath));
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }
        }
        internal void validate_pwdlength()
        {
           
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
                //Skip
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                Thread.Sleep(1000);

                //Profile icon
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //Change password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //Current Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(5, "Current PWD"));
                Thread.Sleep(1000);

                //New Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(5, "New PWD"));
                Thread.Sleep(1000);

                //Confirm new Password
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(5, "Confirm new PWD"));
                Thread.Sleep(1000);

                //Change Password button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Thread.Sleep(1000);
            try
            {

                IWebElement errortext = Driver.driver.FindElement(By.Id("ConfirmPasswordTxt-error"));
                string msg = errortext.Text;
                Assert.AreEqual("* The confirm password must be at least 7 characters.", msg);
                //screenshots
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Pass, "Unable to change password as the password doesn't have minimum of 7 characters, the test passed"+Base.test.AddScreenCapture(screenShotPath));


            }
            catch (Exception e)
            {
                string screenShotPath = SaveScreenShotClass.SaveScreenshot(Driver.driver, "ScreenShotName");
                Base.test.Log(LogStatus.Fail, "Validate Password length test failed"+Base.test.AddScreenCapture(screenShotPath));
                
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }

        }
        }
    }

