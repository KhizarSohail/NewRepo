using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRM
{
    internal class AddUser : CorePage
    {
        By admin_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a");
        By add_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-header-container > button > i");
        By user_Role = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input");
        By emp_Name = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input");
        By status = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input");
        By username = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(4) > div > div:nth-child(2) > input");
        By password = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div.oxd-grid-item.oxd-grid-item--gutters.user-password-cell > div > div:nth-child(2) > input");
        By confirm_Pass = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div:nth-child(2) > div > div:nth-child(2) > input");
        By save_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space");
        public void AddingUser()
        {
            Click(admin_Btn);
            Thread.Sleep(1000);
            Click(add_Btn);
            Thread.Sleep(1000);
            Write(user_Role, "Admin");
            Write(user_Role, Keys.ArrowDown);
            Write(user_Role, Keys.ArrowDown);
            Write(user_Role, Keys.Enter);
            Thread.Sleep(1000);
            Write(emp_Name, "Toffee  Candy");
            Thread.Sleep(3000);
            Write(status, "Enabled");
            Thread.Sleep(1000);
            Write(username, "Cowabunga");
            Thread.Sleep(1000);
            Write(password, "Cowabunga@c123");
            Thread.Sleep(1000);
            Write(confirm_Pass, "Cowabunga@123");
            Thread.Sleep(1000);
            Write(save_Btn,Keys.Enter);
        }
    }
}
