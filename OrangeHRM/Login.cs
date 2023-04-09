using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRM
{
    internal class Login : CorePage
    {
        By username = By.Name("username"); 
        By password = By.Name("password");
        By login_btn = By.CssSelector("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button");
        public void Login_Method() 
        {
            URL("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(1000);
            Write(username,"Admin");
            Thread.Sleep(1000);
            Write(password,"admin123");
            Thread.Sleep(1000);
            Click(login_btn);
            Thread.Sleep(1000);
        }
    }
}
