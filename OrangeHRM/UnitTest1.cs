using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace OrangeHRM
{
    [TestClass]
    public class UnitTest1
    {
        Login obj_login = new Login();
        AddUser obj_AddUser = new AddUser();
        Update_Delete obj_updel = new Update_Delete();

        [TestMethod]
        [Priority(1)]
        [TestCategory("Valid Login Scenario")]
        public void Login_ValidInput_SuccessfulLogin()
        {
            CorePage.SeleniumDriver();
            obj_login.Login_Method();
        }
        
        [TestMethod]
        [Priority(2)]
        [TestCategory("Adding user with valid input")]
        public void AdminPanel_AddUser_ValidInput_SuccessfullyAdded()
        {
            Login_ValidInput_SuccessfulLogin();
            obj_AddUser.AddingUser();
            CorePage.Close();
        }

        [TestMethod]
        [Priority(3)]
        [TestCategory("Updating and Deleting the created user")]
        public void AdminPanel_UpdateAndDeleteUser_SuccessfullyDeleted()
        {
            Login_ValidInput_SuccessfulLogin();
            AdminPanel_AddUser_ValidInput_SuccessfullyAdded();
            obj_updel.Update_And_Delete();
            CorePage.Close();
        }

        [TestMethod]
        public void NewCase()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://accounts.heb.com/interaction/RXZjV4gZ3VPMzf1ea7-3i/register";


        }
    }
}
