using NUnit.Framework;
using SeleniumSample.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Interactions;
using System;

namespace SeleniumSample.TestSuites
{
    public class HW_2_Malikov

    {
        ChromeDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl(Utilities.URL);
            driver.Manage().Window.Maximize();
        }

        #region "Авторизация"
        [Test]
        [Description("Этот тест проверяет авторизацю")]
        [Order(1)]
        public void IsLoginSuccesfull()
        {
            var login_element = driver.FindElement(By.Id("user-name"));
            login_element.SendKeys("performance_glitch_user");

            var password_element = driver.FindElement(By.Id("password"));
            password_element.SendKeys("secret_sauce");

            var login_click_element = driver.FindElement(By.Id("login-button"));
            login_click_element.Click();
            Console.WriteLine("Авторизация");
        }
        #endregion

        #region "Добавить товар Sauce Labs Fleece Jacket в корзину"
        [Test]
        [Description("Этот тест добавляет Sauce Labs Fleece Jacket в корзину")]
        [Order(2)]
        public void AddProductSauceLabsFleeceJacketInBasket()
        {
            System.Threading.Thread.Sleep(3000);
            var SLFJ_element = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
            SLFJ_element.Click();
            Console.WriteLine("Добавить товар Sauce Labs Fleece Jacket в корзину");
        }
        #endregion

        #region "Переход в Корзину_1"
        [Test]
        [Description("Тест по нажатию кнопки 'Корзина' и переход в неё")]
        [Order(3)]
        public void GoToShoppingCart_1()
        {
            System.Threading.Thread.Sleep(1000);
            var Basket_element = driver.FindElement(By.Id("shopping_cart_container"));
            Basket_element.Click();
            Console.WriteLine("Переход в Корзину_1");
        }
        #endregion

        #region "Нажатие кнопки 'Countine Shopping'"
        [Test]
        [Description("Тест на нажатие кнопки 'Countine Shopping'")]
        [Order(4)]
        public void PressButtonCountineShopping()
        {
            System.Threading.Thread.Sleep(1000);
            var CountineShopping_element = driver.FindElement(By.Id("continue-shopping"));
            CountineShopping_element.Click();
            Console.WriteLine("Нажатие кнопки 'Countine Shopping'");
        }
        #endregion

        #region "Добавить товар Sauce Labs Bolt T-Shirt в корзину"
        [Test]
        [Description("Этот тест добавляет Sauce Labs Bolt T-Shirt в корзину")]
        [Order(5)]
        public void AddProductSauceLabsBoltT_ShirtInBasket()
        {
            System.Threading.Thread.Sleep(1000);
            var SLBTS_element = driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
            SLBTS_element.Click();
            Console.WriteLine("Добавить товар Sauce Labs Bolt T-Shirt в корзину");
        }
        #endregion

        #region "Переход в Корзину_2"
        [Test]
        [Description("Тест на нажатие кнопки 'Корзина' и переход в неё")]
        [Order(6)]
        public void GoToShoppingCart_2()
        {
            System.Threading.Thread.Sleep(1000);
            var Basket_element = driver.FindElement(By.Id("shopping_cart_container"));
            Basket_element.Click();
            Console.WriteLine("Переход в Корзину_2");
        }
        #endregion

        #region "Нажатие кнопки 'Checkout'"
        [Test]
        [Description("Тест на нажатие кнопки 'Checkout'")]
        [Order(7)]
        public void Checkout()
        {
            System.Threading.Thread.Sleep(1000);
            var Checkout_element = driver.FindElement(By.Id("checkout"));
            Checkout_element.Click();
            Console.WriteLine("Нажатие кнопки 'Checkout'");
        }
        #endregion

        #region "Заполнение полей: 'Имя', 'Фамилия', 'Зип-Код' и нажатие на кнопку 'Continue'"
        [Test]
        [Description("Тест на заполнение полей Имя, Фамилия, Зип-Код и нажатие кнопки 'Continue'")]
        [Order(8)]
        public void FillingInFields()
        {
            System.Threading.Thread.Sleep(1000);
            var FirstName_element = driver.FindElement(By.Id("first-name"));
            FirstName_element.SendKeys("Иван");

            var LastName_element = driver.FindElement(By.Id("last-name"));
            LastName_element.SendKeys("Иванов");

            var ZipCode_element = driver.FindElement(By.Id("postal-code"));
            ZipCode_element.SendKeys("8675309");

            var Continue_element = driver.FindElement(By.Id("continue"));
            Continue_element.Click();
            Console.WriteLine("Заполнение полей: 'Имя', 'Фамилия', 'Зип-Код' и нажатие на кнопку 'Continue'");
        }
        #endregion

        #region "Нажатие кнопки 'Finish'"
        [Test]
        [Description("Тест на нажатие кнопки 'Finish'")]
        [Order(9)]
        public void Finish()
        {
            System.Threading.Thread.Sleep(1000);
            var Finish_element = driver.FindElement(By.Id("finish"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(Finish_element);
            actions.Perform();
            Finish_element.Click();
            Console.WriteLine("Нажатие кнопки 'Finish'");
        }
        #endregion

        #region "Закрытие браузера"
        [Test]
        [Description("Закрытие браузера")]
        [Order(10)]
        public void Quit()
        {
            driver.Quit();
        }
        #endregion
    }

}
