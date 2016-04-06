using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace NavigatorTest
{
    class Program
    {
      public  IWebDriver driver = new FirefoxDriver();
        static void Main(string[] args)
        {           
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://navigator.ba");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }

        [TestCase]
        public void ZoomIn()
        {
            //Find the Element
            IWebElement zoom_in = driver.FindElement(By.ClassName("leaflet-control-zoom-in"));
            zoom_in.Click();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Console.WriteLine("Executed Test");

        }

        [TestCase]
        public void ZoomOut()
        {
            IWebElement zoom_out = driver.FindElement(By.ClassName("leaflet-control-zoom-out"));
            zoom_out.Click();
            driver.Navigate().Back();

        }

        [TestCase]
        public void Twitter()
        {
            IWebElement twitter = driver.FindElement(By.ClassName("iconav-twitter-2"));
            twitter.Click();
            driver.Navigate().Back();

        }
        [TestCase]
        public void Facebook()
        {
            IWebElement facebook = driver.FindElement(By.ClassName("iconav-facebook"));
            facebook.Click();
            driver.Navigate().Back();

        }
        [TestCase]
        public void GooglePlus()
        {
            IWebElement google = driver.FindElement(By.ClassName("iconav-googleplus"));
            google.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void SatalliteView()
        {
            Thread.Sleep(4000);
            IWebElement satallite = driver.FindElement(By.ClassName("leaflet-control-layers-switch "));
            satallite.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void SwitchToBosnian()
        {
            //Thread.Sleep(4000);
            IWebElement bosnian = driver.FindElement(By.ClassName("bs"));
            bosnian.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void SwitchToEnglish()
        {
            //Thread.Sleep(4000);
            IWebElement english= driver.FindElement(By.ClassName("btn-en"));
            english.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        
        [TestCase]
        public void GooglePlay()
        {
            
            IWebElement googlePlay = driver.FindElement(By.ClassName("apps-links"));
            googlePlay.Click();

        }
        
        [TestCase]
        public void ReportProblemAndCancel()
        {
            
            IWebElement problem= driver.FindElement(By.Id("ember585"));
            problem.Click();
            Thread.Sleep(3000);
            IWebElement name = driver.FindElement(By.Name("name_surname"));
            name.SendKeys("Amina");
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("amina@gamil.com");
            IWebElement comment = driver.FindElement(By.Name("comment"));
            comment.SendKeys("amina@gamil.com");
            IWebElement raddioB = driver.FindElement(By.ClassName("green"));
            raddioB.Click();
            IWebElement cancel = driver.FindElement(By.ClassName("grey-button"));
            cancel.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void ReportProblemSend()
        {
            //Thread.Sleep(4000);
            IWebElement problem = driver.FindElement(By.Id("ember585"));
            problem.Click();
            Thread.Sleep(3000);
            IWebElement name = driver.FindElement(By.Name("name_surname"));
            name.SendKeys("Amina");
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("amin444444a@gamil.com");
            IWebElement comment = driver.FindElement(By.Name("comment"));
            comment.SendKeys("amina@gamil.com");
            IWebElement raddioB = driver.FindElement(By.ClassName("green"));
            raddioB.Click();
            IWebElement send = driver.FindElement(By.ClassName("green-button"));
            send.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void CreatePlaceCancel()
        {
            //Thread.Sleep(4000);
            IWebElement problem = driver.FindElement(By.Id("ember570"));
            problem.Click();
            Thread.Sleep(3000);
            IWebElement name = driver.FindElement(By.Id("poi_name"));
            name.SendKeys("Amina");
            IWebElement city = driver.FindElement(By.Id("poi_city_name"));
            city.SendKeys("Sarajevo");
            IWebElement zip_code = driver.FindElement(By.Id("poi_zip_code"));
            zip_code.SendKeys("123300");
            IWebElement street = driver.FindElement(By.Id("poi_place_id"));
            street.SendKeys("Neka ulica");
            IWebElement house_number = driver.FindElement(By.Id("poi_house_number"));
            house_number.SendKeys("78");

            IWebElement a_street = driver.FindElement(By.Id("poi_street_name_alt"));
            a_street.SendKeys("neka druga");
            IWebElement comment = driver.FindElement(By.Id("poi_description"));
            comment.SendKeys("Komentar");
            comment.SendKeys(Keys.PageDown);

            Thread.Sleep(3000);

            IWebElement findCancel = driver.FindElement(By.Id("poi_comment"));
            findCancel.SendKeys(Keys.PageDown);


            IWebElement cancel = driver.FindElement(By.ClassName("btn cancel"));
            cancel.Click();

            

        }
        [TestCase]
        public void CreatePlaceSend()
        {
           
            IWebElement problem = driver.FindElement(By.Id("ember570"));
            problem.Click();
            Thread.Sleep(3000);
            IWebElement name = driver.FindElement(By.Id("poi_name"));
            name.SendKeys("Amina");
            IWebElement city = driver.FindElement(By.Id("poi_city_name"));
            city.SendKeys("Sarajevo");
            IWebElement zip_code = driver.FindElement(By.Id("poi_zip_code"));
            zip_code.SendKeys("123300");
            IWebElement street = driver.FindElement(By.Id("poi_place_id"));
            street.SendKeys("Neka ulica");
            IWebElement house_number = driver.FindElement(By.Id("poi_house_number"));
            house_number.SendKeys("78");

            IWebElement a_street = driver.FindElement(By.Id("poi_street_name_alt"));
            a_street.SendKeys("neka druga");
            IWebElement comment = driver.FindElement(By.Id("poi_description"));
            comment.SendKeys("Komentar");
            comment.SendKeys(Keys.PageDown);

            Thread.Sleep(3000);

            IWebElement findSend = driver.FindElement(By.Id("poi_comment"));
            findSend.SendKeys(Keys.PageDown);

            IWebElement send = driver.FindElement(By.ClassName("btn btn-success"));
            send.Click();   

        }
        
        [TestCase]
        public void SearchPlace()
        {
            IWebElement search = driver.FindElement(By.Id("ember562"));
            search.Click();
            search.SendKeys("Cinema City");
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void SearchStreet()
        {
            IWebElement search = driver.FindElement(By.Id("ember562"));
            search.Click();
            search.SendKeys("Dzemala Bijedica");
            driver.Navigate().Back();
            Thread.Sleep(3000);


        }
        [TestCase]
        public void Accommodation()
        {
            IWebElement accommodation = driver.FindElement(By.ClassName("accommodation"));
            accommodation.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Coffe()
        {
            IWebElement coffee = driver.FindElement(By.ClassName("coffee"));
            coffee.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);


        }
        [TestCase]
        public void Food()
        {
            IWebElement food = driver.FindElement(By.ClassName("food"));
            food.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Nightlife()
        {
            IWebElement nightlife = driver.FindElement(By.ClassName("nightlife"));
            nightlife.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Shopping()
        {
            IWebElement shopping = driver.FindElement(By.ClassName("shopping"));
            shopping.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Attractions()
        {
            IWebElement attractions = driver.FindElement(By.ClassName("attractions"));
            attractions.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Art()
        {
            IWebElement art = driver.FindElement(By.ClassName("art"));
            art.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Sport()
        {
            IWebElement sport = driver.FindElement(By.ClassName("sport"));
            sport.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Transport()
        {
            IWebElement transport = driver.FindElement(By.ClassName("transport"));
            transport.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Services()
        {
            IWebElement services = driver.FindElement(By.ClassName("services"));
            services.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Business()
        {
            IWebElement business = driver.FindElement(By.ClassName("business"));
            business.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TestCase]
        public void Street()
        {
            IWebElement street = driver.FindElement(By.ClassName("street"));
            street.Click();
            driver.Navigate().Back();
            Thread.Sleep(3000);

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }

    }
}
