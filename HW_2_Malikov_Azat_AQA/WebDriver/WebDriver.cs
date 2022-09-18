using OpenQA.Selenium.Chrome;

namespace SeleniumSample.WebDriver
{
    public class WebDriver
    {
        public ChromeDriver driver { get; set; }

        public WebDriver()
        {
            this.driver = new ChromeDriver();
        }
    }
}

